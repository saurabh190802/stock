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
    public partial class getintouch : Form
    {
        public getintouch()
        {
            InitializeComponent();
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome Welcome = new welcome();
            Welcome.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
