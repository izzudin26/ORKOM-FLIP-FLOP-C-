using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Flip_Flop_Desktop
{
    public partial class FlipFlopForms1 : Form
    {
        int and1 = 0;
        int and2 = 0;
        public FlipFlopForms1()
        {
            InitializeComponent();
        }

        public void setAnd1()
        {
            if (textboxA.Text != "" && textboxB.Text != "")
            {
                int boxA = int.Parse(textboxA.Text);
                int boxB = int.Parse(textboxB.Text);
                if (boxA == 1 && boxB == 1)
                {
                    and1 = 1;
                    getAnd1();
                }
                else
                {
                    and1 = 0;
                    getAnd1();
                }
            }
        }


        void setAnd2()
        {
            if(textboxC.Text != "" && textboxD.Text != "")
            {
                int boxC = int.Parse(textboxC.Text);
                int boxD = int.Parse(textboxD.Text);
                if(boxC == 1 && boxD == 1)
                {
                    and2 = 1;
                }
                else
                {
                    and2 = 0;
                }
                getAnd2();
            }
        }

        void getAnd1()
        {
            textboxAnd1.Text = and1.ToString();
            setOr();
        }

        void getAnd2()
        {
            textboxAnd2.Text = and2.ToString();
            setOr();
        }

        void setOr()
        {
            if(and1 == 1 || and2 == 1)
            {
                textboxOr.Text = "1";
                lightBox.Image = Flip_Flop_Desktop.Properties.Resources.lightOn;
            }
            else
            {
                textboxOr.Text = "0";
                lightBox.Image = Flip_Flop_Desktop.Properties.Resources.lightOff;
            }
        }

        private void textboxA_TextChanged(object sender, EventArgs e)
        {
            setAnd1();
        }

        private void textboxB_TextChanged(object sender, EventArgs e)
        {
            setAnd1();
        }

        private void textboxC_TextChanged(object sender, EventArgs e)
        {
            setAnd2();
        }

        private void textboxD_TextChanged(object sender, EventArgs e)
        {
            setAnd2();
        }

        private void FlipFlopForms1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
