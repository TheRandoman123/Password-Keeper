using System;
using System.Windows.Forms;
using System.IO;
using Encript_And_Decript;
using Microsoft.VisualBasic;


namespace Password_Keeper
{
    public partial class profile_name_sign_in_label : Form
    {
        public profile_name_sign_in_label()
        {
            InitializeComponent();
        }
        
        private void Sign_up_button(object sender, EventArgs e)
        {
             string profile_name = (profile_name_textbox_sign_up.Text);

             string user_name = Environment.UserName;

             string file_path = (@"C:\Users\" + user_name + @"\Desktop\Password Keeper\" + profile_name + ".txt");

             string Sign_In_Username_Input = AesCryp.Encrypt(Sign_Up_TextBox_Username.Text);

             string Sign_In_Password_Input = AesCryp.Encrypt(Sign_Up_TextBox_Password.Text);


            if (File.Exists(file_path) == true)
            {
                MessageBox.Show("That Username has all ready been taken!");
               

                profile_name_textbox_sign_up.Clear();

                Sign_Up_TextBox_Username.Clear();

                Sign_Up_TextBox_Password.Clear();
            }
            else
            {
                StreamWriter sw = new StreamWriter(file_path, true);
                sw.Write(Sign_In_Username_Input);
                sw.Write(Sign_In_Password_Input);
                sw.Close();

                profile_name_textbox_sign_up.Clear();

                Sign_Up_TextBox_Username.Clear();

                Sign_Up_TextBox_Password.Clear();

                MessageBox.Show("Complete");
          }
        }

        private void Sign_in_button(object sender, EventArgs e)
        {


            string profile_name = (profile_name_sign_in_textbox.Text);
            
            string user_name = Environment.UserName;

            string file_path = (@"C:\Users\" + user_name + @"\Desktop\Password Keeper\" + profile_name + ".txt");
            
            string Sign_In_Username_Input = AesCryp.Encrypt(Sign_In_TextBox_Username.Text);
            
            string Sign_In_Password_Input = AesCryp.Encrypt(Sign_In_TextBox_Password.Text);

            string textBoxOutput= Sign_In_Password_Input;

            string file_read = File.ReadAllText(file_path);

            
            if (Sign_In_Password_Input + Sign_In_Username_Input == file_read)
            {
                Sign_In_TextBox_Username.Clear();

                Sign_In_TextBox_Password.Clear();

                var PC = new Password_Center();
                PC.Show();
                
			}
            
            else
                {
                MessageBox.Show("Wrong password or username, try again.");
                }
            }

        
    }
    }

                