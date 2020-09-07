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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            {
                string s = textBox2.Text;
                if ((s.Length >= 6 && s.Any(char.IsUpper) && s.Any(char.IsDigit) &&
                   s.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) >= 0))
                {
                    string log = Convert.ToString(textBox1.Text);
                    StreamWriter qw = new StreamWriter(log + ".txt");
                    qw.WriteLine(textBox1.Text);
                    qw.WriteLine(textBox2.Text);
                    qw.Close();
                    {
                        Form1 d2 = new Form1();
                        d2.Show();
                        this.Close();
                    }
                }
                else if (s.Length < 6)
                {
                    MessageBox.Show("В пароле необходимо минимум 6 символов");
                }
                else if (s.Any(char.IsUpper) == false)
                {
                    MessageBox.Show("В пароле нужна минимум 1 прописная буква");
                }
                else if (s.Any(char.IsDigit) == false)
                {
                    MessageBox.Show("В пароле нужна минимум 1 цифра");
                }
                else if (s.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) < 0)
                {
                    MessageBox.Show("В пароле нужен минимум один символ из набора: ! @ # $ % ^");
                }
                
            }






            
        


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Минимум 6 символов. \n-Минимум 1 прописная буква." +
                " \n-Минимум 1 цифра. \n-Минимум один символ из набора: ! @ # $ % ^ ", "Условия пароля");

        }
    }
}
