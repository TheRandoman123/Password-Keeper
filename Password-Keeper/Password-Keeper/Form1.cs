using System;
using System.Windows.Forms;
using System.IO;
using Encript_And_Decript;
using Microsoft.VisualBasic;


namespace Password_Keeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Sign_up_button(object sender, EventArgs e)
        {
             string profile_name = (profile_name_textbox_sign_up.Text);

             string userName = Environment.UserName;

             string filePath = (@"C:\Users\" + userName + @"\Desktop\Github\Password Keeper\" + profile_name + ".txt");
            
             string Sign_In_Username_Input = AesCryp.Encrypt(Sign_Up_TextBox_Username.Text);

             string Sign_In_Password_Input = AesCryp.Encrypt(Sign_Up_TextBox_Password.Text);


            if (File.Exists(filePath) == true)
            {
                MessageBox.Show("That Username has all ready been taken");

                Sign_Up_TextBox_Username.Clear();

                Sign_Up_TextBox_Password.Clear();
            }
            else
            {
               
                File.WriteAllText(filePath, Sign_In_Username_Input);
            
                File.WriteAllText(filePath, Sign_In_Password_Input);

                profile_name_textbox_sign_up.Clear();

                Sign_Up_TextBox_Username.Clear();

                Sign_Up_TextBox_Password.Clear();

                MessageBox.Show("Complete");
          }
        }

        private void Sign_in_button(object sender, EventArgs e)
        {


            string profile_name = (profile_name_textbox_sign_up.Text);

            string userName = Environment.UserName;

            string filePath = (@"C:\Users\" + userName + @"\Desktop\Github\Password Keeper\" + profile_name + ".txt");
            
            string Sign_In_Username_Input = AesCryp.Encrypt(Sign_In_TextBox_Username.Text);
            
            string Sign_In_Password_Input = AesCryp.Encrypt(Sign_In_TextBox_Password.Text);

            string textBoxOutput= Sign_In_Password_Input;

            string fileRead = File.ReadAllText(filePath);

            
            if (Sign_In_Password_Input + Sign_In_Username_Input == fileRead)
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

                