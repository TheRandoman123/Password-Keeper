using System;
using System.Windows.Forms;
using System.IO;


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

            string filePath = Encript_And_Decript.Encrypt(@"C:\Users\nerfs\Desktop\C# test folder\test.txt");
           


            string Sign_In_Username_Input = Sign_Up_TextBox_Username.Text;

            string Sign_In_Password_Input =  Sign_Up_TextBox_Password.Text;


            var fileCreate = File.Create(@"C:\Users\nerfs\Desktop\C# test folder\test.txt");
            fileCreate.Close();
            
            
            File.AppendAllText(@"C:\Users\nerfs\Desktop\C# test folder\test.txt", Sign_In_Username_Input);
            
            File.AppendAllText(@"C:\Users\nerfs\Desktop\C# test folder\test.txt", Sign_In_Password_Input);

            Sign_Up_TextBox_Username.Clear();

            Sign_Up_TextBox_Password.Clear();

            MessageBox.Show("Complete");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ()
            {

            }
        }
    }
}
