using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Field_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox1.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            if((TextBox1.Text.Equals("admin", StringComparison.OrdinalIgnoreCase)) && (TextBox2.Text.Equals("admin", StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Login Successful!");
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("please enter a valid username or password");
            }
        }

      
    }
}
