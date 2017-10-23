using System;
using System.Windows.Forms;
using System.IO;
using Encript_And_Decript;



namespace Password_Keeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var filePath = filePathBox.Text();//Becasue of this

            string Sign_In_Username_Input = AesCryp.Encrypt(Sign_Up_TextBox_Username.Text);

            string Sign_In_Password_Input =  AesCryp.Encrypt(Sign_Up_TextBox_Password.Text);

			
            var fileCreate = File.Create(filePath);    //finish fixing this error 
            fileCreate.Close();
            
            
            File.AppendAllText(filePath, Sign_In_Username_Input);
            
            File.AppendAllText(filePath, Sign_In_Password_Input);

            Sign_Up_TextBox_Username.Clear();

            Sign_Up_TextBox_Password.Clear();

            MessageBox.Show("Complete");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string filePath = filePathBox.Text();


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

        private string filePathBox()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

                