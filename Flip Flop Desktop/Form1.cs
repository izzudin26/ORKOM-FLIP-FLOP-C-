using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flip_Flop_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlipFlopForms1 flip1 = new FlipFlopForms1();
            flip1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlipFlopForm2 flip2 = new FlipFlopForm2();
            flip2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
