using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.PopSharp
{
    public class Pop3Connection
    {
        private Uri uri;
        private bool useTls;
        private TcpClient tcp;
        private SslStream ssl;

        public Pop3Connection(Uri uri, bool useTls)
        {
            this.uri = uri;
            this.useTls = useTls;

            tcp = new TcpClient(uri.Host, uri.Port);
            ssl = new SslStream(tcp.GetStream());
            ssl.AuthenticateAsClient(uri.Host);

            Console.WriteLine(readLine());
        }

        private string readLine()
        {
            StringBuilder stringBuilder = new StringBuilder();
            char c;
            while(true)
            {
                c = (char)ssl.ReadByte();
                if (stringBuilder.Length >= 1 && stringBuilder[stringBuilder.Length - 1] == '\r' && c == '\n')
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    break;
                }
                stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        private string[] readLines()
        {
            List<string> lines = new List<string>();
            string lastLine;
            while (true)
            {
                lastLine = readLine();
                if (lastLine == ".") break;
                lines.Add(lastLine);
            }

            return lines.ToArray();
        }

        public void Login(string username, string password)
        {
            byte[] msg = Encoding.ASCII.GetBytes("USER " + username + "\r\n");
            ssl.Write(msg);
            Console.WriteLine(readLine());

            msg = Encoding.ASCII.GetBytes("PASS " + password + "\r\n");
            ssl.Write(msg);
            Console.WriteLine(readLine());

            msg = Encoding.ASCII.GetBytes("STAT\r\n");
            ssl.Write(msg);
            Console.WriteLine(readLine());
        }

        public Email[] GetEmails()
        {
            byte[] msg = Encoding.ASCII.GetBytes("LIST\r\n");
            ssl.Write(msg);
            readLine(); // TODO: Check for success
            string[] lines = readLines();
            List<int> ids = new List<int>();
            foreach (string line in lines)
            {
                ids.Add(int.Parse(line[0].ToString()));
            }

            Email[] emails = new Email[ids.Count];
            for(int i = 0; i < ids.Count; i++)
            {
                msg = Encoding.ASCII.GetBytes("RETR " + ids[i].ToString() + "\r\n");
                ssl.Write(msg);
                string response = readLine();
                Console.WriteLine(response);
                lines = readLines();
                emails[i] = new Email(ids[i], lines);
            }
        
            return emails;
        }

        public void Close()
        {
            ssl.Close();
            tcp.Close();
        }
    }
}
