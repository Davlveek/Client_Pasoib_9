using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string hash = CryptoActions.GetHash(message);
            MessageBox.Show(hash);
        }
    }
}
