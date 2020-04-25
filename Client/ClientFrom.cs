using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class ClientFrom : Form
    {
        private CryptoClient client;

        public ClientFrom()
        {
            InitializeComponent();
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

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("No connection!");
                return;
            }

            string message = MessageRichBox.Text;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Empty message!");
                return;
            }

            client.SendData(new UnicodeEncoding().GetBytes("4"));
            client.SendData(new UnicodeEncoding().GetBytes("Sign"));

            byte[] sign = CryptoActions.Sign(message);
            client.SendData(sign);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var address = AddressTextBox.Text;
            var _port = PortTextBox.Text;

            if (string.IsNullOrEmpty(address) && string.IsNullOrEmpty(_port))
            {
                MessageBox.Show("Empty server IP adress or port!");
                return;
            }

            try
            {
                var port = Convert.ToInt32(_port);
                client = new CryptoClient(address, port);
                client.InitNetworkStream();
                MessageBox.Show($"Connected to {address}");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Exception: {exp}");
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                client.SendData(new UnicodeEncoding().GetBytes("5"));
                client.SendData(new UnicodeEncoding().GetBytes("Close"));
                client.CloseNetworkStream();
                client.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Exception: {exp}");
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string message = MessageRichBox.Text;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Empty message!");
                return;
            }

            client.SendData(new UnicodeEncoding().GetBytes("7"));
            client.SendData(new UnicodeEncoding().GetBytes("Encrypt"));

            byte[] signedData = CryptoActions.Sign(message);
            byte[] encryptedData = CryptoActions.Encrypt(signedData);
            client.SendData(encryptedData);
        }
    }
}
