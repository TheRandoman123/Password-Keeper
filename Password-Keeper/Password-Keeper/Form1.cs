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
            
            string Sign_In_Username_Input = Sign_Up_TextBox_Username.Text + ", ";

            string Sign_In_Password_Input =  Sign_Up_TextBox_Password.Text;


            var fileCreate = File.Create(@"C:\Users\nerfs\Desktop\C# test folder\test.txt");
            fileCreate.Close();
            
            
            File.AppendAllText(@"C:\Users\nerfs\Desktop\C# test folder\test.txt", Sign_In_Username_Input);
            
            File.AppendAllText(@"C:\Users\nerfs\Desktop\C# test folder\test.txt", Sign_In_Password_Input);

            MessageBox.Show("Complete");
          
        }
        
    }
}
