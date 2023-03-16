using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in
{
    public partial class sign : Form
    {
        public sign()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log l1 = new log();
            l1.Show();
            this.Hide();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            string file = "E:\\ProjectOOC\\Lab9\\Log in\\username_pass.txt";
            bool flg = true;
            if (File.Exists(file))
            {
                if (textBox1.Text.Length >= 6 && textBox2.Text.Length >= 6)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        if (line == textBox1.Text)
                        {
                            flg = false; break;
                        }
                    }
                    if (flg == true)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            File.AppendAllText(file, "\n");
                            File.AppendAllText(file, textBox1.Text);
                            File.AppendAllText(file, "\n");
                            File.AppendAllText(file, textBox2.Text);
                      
                            log f1 = new log();
                            f1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A user with the same user name already exists!");
                    }
                }
                else
                {
                    MessageBox.Show("Username and password must be at least six characters!");
                }
            }

        }
    }
    
}
