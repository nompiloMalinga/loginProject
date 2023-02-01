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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void DanceTimer_Tick(object sender, EventArgs e)
        {
            PictureBox1.Left -= 1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DanceTimer.Stop();
        }
    }
}
