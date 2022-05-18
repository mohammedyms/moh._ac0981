using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        userman usr = new userman();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = "mohammad", password = "1234";
            if (txtusername.Text == username && txtpassword.Text == password)
            {
                usr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("un correct password !!!");
            }
        }
    }
}
