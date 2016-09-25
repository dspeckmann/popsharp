using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSpeckmann.PopSharp
{
    public class Email
    {
        public int Id { get; }
        public string Subject { get; }
        public string Sender { get; }
        public string Recipient { get; }
        public DateTime Date { get; }
        public string Message { get; }

        public Email(int id, string[] content)
        {
            Id = id;

            bool header = true;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < content.Length; i++)
            {
                if (header)
                {
                    if (string.IsNullOrEmpty(content[i]))
                    {
                        header = false;
                        continue;
                    }

                    string[] items = content[i].Split(new char[] { ':' }, 2);
                    if (items.Length < 2)
                    {
                        continue;
                    }
                    string key = items[0].Trim();
                    string value = items[1].Trim();

                    switch(key)
                    {
                        case "Subject":
                            Subject = decodeHeader(value);
                            break;
                        case "From":
                            Sender = decodeHeader(value);
                            break;
                        case "To":
                            Recipient = decodeHeader(value);
                            break;
                        case "Date":
                            Date = DateTime.Parse(decodeHeader(value));
                            break;
                    }
                }
                else
                {
                    stringBuilder.Append(content[i]);
                    stringBuilder.Append("\r\n");
                }
            }
            Message = stringBuilder.ToString();
        }

        private string decodeHeader(string originalHeader)
        {
            // Decode headers according to RFC 1342 with the following regex: =\?(.*)\?[B,Q]\?(.*)\?=
            Regex regex = new Regex("=\\?(.*)\\?([B,Q])\\?(.*)\\?=");
            Match match = regex.Match(originalHeader);

            if (match.Groups.Count < 4) return originalHeader;
            
            string charsetString = match.Groups[1].ToString();
            string encodingString = match.Groups[2].ToString();
            string encodedSubject = match.Groups[3].ToString();

            Encoding encoding = Encoding.GetEncoding(charsetString);
            if (encodingString == "B")
            {
                byte[] subjectBytes = Convert.FromBase64String(encodedSubject);
                return encoding.GetString(subjectBytes);
            }
            else
            {
                // Q-Encoding according to RFC 1342: =([0-9]|[A-F]){2}
                // Support for multiple byte long code points: (=(([A-F]|[0-9]){2}))+ (got to strip the equal signs though)
                Regex r2 = new Regex("(=(([A-F]|[0-9]){2}))+");
                MatchCollection matches = r2.Matches(encodedSubject);
                List<KeyValuePair<int, string>> replacements = new List<KeyValuePair<int, string>>();
                for (int j = matches.Count - 1; j >= 0; j--)
                {
                    string matchedString = matches[j].ToString();
                    string hexString = matchedString.Replace("=", string.Empty);
                    // Convert from base 16 string to integer to byte array
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(hexString, 16));
                    bytes = bytes.Reverse().Skip(1).ToArray();
                    string decodedString = encoding.GetString(bytes);
                    Console.WriteLine("Decoded: " + decodedString);
                    encodedSubject = encodedSubject.Replace(matchedString, decodedString);
                }
                return encodedSubject.Replace('_', ' ');
            }
        }
    }
}
