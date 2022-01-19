using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        int NumberOfClick = 0;
        private void buttonlearnmore_Click(object sender, EventArgs e)
        {
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    panel4.Show();
                    panel2.Show();
                    buttonlearnmore.Text = "READ LESS";
                    break;
                case 2:
                    panel2.Hide();
                    panel4.Hide();
                    buttonlearnmore.Text = "READ MORE";
                    NumberOfClick = 0;
                    break;
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            createcompany createc = new createcompany();
            createc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            getintouch get = new getintouch();
            get.ShowDialog();
        }

        private void welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            panel4.Hide();
            panel2.Hide();
            buttonlogin.Focus();
        }
    }
}
