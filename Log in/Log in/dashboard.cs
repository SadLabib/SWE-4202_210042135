using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            label2.Text = "Welcome! " + log.form1instance.uname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log l = new log();
            l.Show();
            this.Hide();
        }
    }
}
