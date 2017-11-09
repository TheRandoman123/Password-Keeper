using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Encriptor_And_Decriptor.Encript_And_Decript;

namespace Encriptor_And_Decriptor
{
    public partial class Decriptor : Form
    {
        public Decriptor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            open_file.ShowDialog();

            string file = open_file.FileName;

            string read_file = File.ReadAllText(file);

            if (decrypt_checkbox.Checked = true && encrypt_checkbox.Checked == true)
            {
                MessageBox.Show("Sorry you cant Encrypt and Decrypt both at the same time, please only select on operation");
                
            }

            else
            {
                if (encrypt_checkbox.Checked == true)
                {
                    string encripted_text = AesCryp.Encrypt(read_file);
                    textbox_output.Text = encripted_text;
                }

                else if (decrypt_checkbox.Checked == true)
                {
                    string decrypted_text = AesCryp.Decrypt(read_file);
                    textbox_output.Text = decrypted_text;
                }

            }



        }

        private void clear_textboxes_Click(object sender, EventArgs e)
        {
            textbox_output.Clear();

            file_textbox.Clear();

        }

        private void decript_and_encrypt_button_Click(object sender, EventArgs e)
        {
            if (decrypt_checkbox.Checked = true && encrypt_checkbox.Checked == true)
            {
                MessageBox.Show("Sorry you cant Encrypt and Decrypt both at the same time, please only select on operation");
            }


            else if (decrypt_checkbox.Checked == false && encrypt_checkbox.Checked == false)
            {
                MessageBox.Show("Sorry you must select an operation from the checkbox up above");
            }

            else
            {
                string file = file_textbox.Text;
                
                if (encrypt_checkbox.Checked == true)
                {
                    string encripted_text = AesCryp.Encrypt(file);
                    textbox_output.Text = encripted_text;
                    
                }

                else if (decrypt_checkbox.Checked == true)
                {
                    string decrypted_text = AesCryp.Decrypt(file);
                    textbox_output.Text = decrypted_text;
                }
            }
        }
    }


    namespace Encript_And_Decript
    {
        class AesCryp
        {
            public static string IV = "qo1lc3sjd8zpt9cx";  // 16 chars = 128 bytes
            public static string Key = "ow7dxys8glfor9tnc2ansdfo1etkfjcv";   // 32 chars = 256 bytes

            public static string Encrypt(string decrypted)
            {
                byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
                AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
                encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);

                byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                icrypt.Dispose();

                return Convert.ToBase64String(enc);
            }

            public static string Decrypt(string encrypted)
            {
                byte[] encbytes = Convert.FromBase64String(encrypted);
                AesCryptoServiceProvider encdec = new AesCryptoServiceProvider
                {
                    BlockSize = 128,
                    KeySize = 256,
                    Key = ASCIIEncoding.ASCII.GetBytes(Key),
                    IV = Encoding.ASCII.GetBytes(IV),
                    Padding = PaddingMode.PKCS7,
                    Mode = CipherMode.CBC
                };

                ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

                byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
                icrypt.Dispose();

                return ASCIIEncoding.ASCII.GetString(dec);
            }
        }
    }
}


