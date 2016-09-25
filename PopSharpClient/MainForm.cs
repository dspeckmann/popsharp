using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSpeckmann.PopSharp;

namespace DSpeckmann.PopSharpClient
{
    public partial class MainForm : Form
    {
        private Email[] emails;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Host = "pop.gmail.com";
            uriBuilder.Port = 995;
            Pop3Connection pop = new Pop3Connection(uriBuilder.Uri, true);
            pop.Login("pop3sharp", "gmailtest");
            emails = pop.GetEmails();
            emailListBox.DataSource = emails;
            pop.Close();
        }

        private void emailListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Email selectedEmail = (Email)emailListBox.SelectedItem;
            rawTextBox.Text = selectedEmail.Message;
            emailView.DocumentText = selectedEmail.Message;
        }
    }
}
