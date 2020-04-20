using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class ClientFrom : Form
    {
        public ClientFrom()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = MessageRichBox.Text;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Empty message!");
                return;
            }
            MessageBox.Show(message);
        }

        private void HashButton_Click(object sender, EventArgs e)
        {
            string message = MessageRichBox.Text;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Empty message!");
                return;
            }

            byte[] hash = CryptoActions.GetHash(message);
            string textBoxHash = BitConverter.ToString(hash)
                .Replace("-", string.Empty)
                .ToLower();
            MessageHashTextBox.Text = textBoxHash;
        }

        private void LoadCertificates()
        {
            certsListBox.Items.Clear();
            const string certsPath = "C:\\certs\\";
            string[] fileEntries = Directory.GetFiles(certsPath);
            certsListBox.Items.AddRange(fileEntries);
        }

        private void ClientFrom_Load(object sender, EventArgs e)
        {
            LoadCertificates();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            LoadCertificates();
        }
    }
}
