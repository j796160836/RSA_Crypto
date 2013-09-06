using RasCryptor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RasCryptorService _rsa = new RasCryptorService("B_RsaCspParameters_Key");

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(public_text.Text) || string.IsNullOrEmpty(msg_text.Text))
            {
                return;
            }

            _rsa.PublicKey = public_text.Text;
            crypt_text.Text = _rsa.EncryptString(msg_text.Text);
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(private_text.Text) || string.IsNullOrEmpty(crypt_text.Text))
            {
                return;
            }

            _rsa.PrivateKey = private_text.Text;
            org_text.Text = _rsa.DecryptString(crypt_text.Text);
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            _rsa.GenerateKey();
            private_text.Text = _rsa.PrivateKey;
            public_text.Text = _rsa.PublicKey;
        }
    }
}
