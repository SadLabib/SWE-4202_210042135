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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Log_in
{
    public partial class log : Form
    {
        public string uname;
        public static log form1instance;
        public log()
        {
            InitializeComponent();
            form1instance = this;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign f2 = new sign();
            f2.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string file = "E:\\ProjectOOC\\Lab9\\Log in\\username_pass.txt";
            bool flg1 = false, flg2 = false;
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                int i = 1;
                foreach (string line in lines)
                {
                    if (i % 2 == 1 && line == user_textBox.Text) flg1 = true;
                    if (i % 2 == 0 && line == pass__textBox.Text) flg2 = true;
                    i++;
                }
                if (flg1 && flg2)
                {
                    uname = user_textBox.Text;
                    dashboard d = new dashboard();
                    d.Show();
                    this.Hide();
                }
            }
        }
    }
}
