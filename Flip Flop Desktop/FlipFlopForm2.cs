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
    public partial class FlipFlopForm2 : Form
    {
        int or1 = 0;
        int and1 = 0;
        public FlipFlopForm2()
        {
            InitializeComponent();
        }

        void setOr1()
        {
            if (inputA.Text != "" && inputB.Text != "")
            {
            int boxA = int.Parse(inputA.Text);
            int boxB = int.Parse(inputB.Text);
                if (boxA == 1 || boxB == 1)
                {
                    or1 = 1;
                }
                else
                {
                    or1 = 0;
                }
                getOr1();
                result();
            }
        }

        void setAnd1()
        {
            if(inputC.Text != "" && inputD.Text != "")
            {
                int boxC = int.Parse(inputC.Text);
                int boxD = int.Parse(inputD.Text);
                if(boxC == 1 && boxD == 1)
                {
                    and1 = 1;
                }
                else
                {
                    and1 = 0;
                }
                getAnd1();
                result();
            }
        }

        void getOr1()
        {
            textboxOr1.Text = or1.ToString();
        }

        void getAnd1()
        {
            textboxAnd1.Text = and1.ToString();
        }

        int getAnd2()
        {
            if(or1 == 1 && and1 == 1)
            {
                textboxAnd2.Text = "1";
                return 1;
            }
            else
            {
                textboxAnd2.Text = "0";
                return 0;
            }
        }

        int getOr2()
        {
            if(or1 == 1 || and1 == 1)
            {
                textboxOr2.Text = "1";
                return 1;
            }
            else
            {
                textboxOr2.Text = "0";
                return 0;
            }
        }

        void result()
        {
            if(getAnd2() == 1 || getOr2() == 1)
            {
                resultBox.Text = "1";
                lightbox.Image = Flip_Flop_Desktop.Properties.Resources.lightOn;
            }
            else
            {
                resultBox.Text = "0";
                lightbox.Image = Flip_Flop_Desktop.Properties.Resources.lightOff;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void inputA_TextChanged(object sender, EventArgs e)
        {
            setOr1();
        }

        private void inputB_TextChanged(object sender, EventArgs e)
        {
            setOr1();
        }

        private void inputC_TextChanged(object sender, EventArgs e)
        {
            setAnd1();
        }

        private void inputD_TextChanged(object sender, EventArgs e)
        {
            setAnd1();
        }
    }
}
