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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
            label3.Visible = false;
            StreamWriter File = new StreamWriter("File.txt");
            File.WriteLine("admin");
            File.WriteLine("Admin@123");

            File.Close();

        }

       public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            



            
           
           StringBuilder Login = new StringBuilder(textBox2.Text);
           StringBuilder pasword = new StringBuilder(textBox1.Text);
            String[] str = System.IO.File.ReadAllLines(Login+".txt");

            string s = textBox1.Text;

            if ((s.Length >= 6 && s.Any(char.IsUpper) && s.Any(char.IsDigit) &&
                s.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) >= 0) &&
                (str[0] == Login.ToString() && str[1] == pasword.ToString()))
            {
                MessageBox.Show("Вход прошел успешно");
                Application.Exit();


            }

            else   { MessageBox.Show("Данные введены неверно"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form3 frm1 = new Form3();
            frm1.Show();
            this.Visible = false;
        }
    }
}
