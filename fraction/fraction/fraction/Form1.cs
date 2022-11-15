using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fraction
{
    public partial class Fraction : Form
    {
        fraction myfraction = new fraction();
        public Fraction()
        {
            InitializeComponent();
        }

        private void CopyNumer_Click(object sender, EventArgs e)
        {
            int temp;
            try
            {
               temp = Convert.ToInt32(NumertextBox.Text);
            }
            catch (Exception excep)
            { MsgLabel.Text = "Message: Please Give A Valid Value";
              return;
            }
            myfraction.Numerator = temp;
            NumerLabel.Text = Convert.ToString(temp);
        }

        private void CopyDenom_Click(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt32(DenortextBox.Text);
            }
            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please Give A Valid Value";
                return;
            }
            myfraction.Denominator = temp;
            DenomLabel.Text = Convert.ToString(temp);
        }

        private void DisplayvaluecheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (DisplayvaluecheckBox.Checked == true)
            {
                if (_3digitradioButton1.Checked == true)
                {
                    ValueLabel.Text = myfraction.Value().ToString("0.000");
                }
                if (_5digitradioButton.Checked == true)
                {
                    ValueLabel.Text = myfraction.Value().ToString("0.00000");
                }
                if (_10digitradioButton.Checked == true)
                {
                    ValueLabel.Text = myfraction.Value().ToString("0.0000000000");
                }
            }
            else
                ValueLabel.Text = "";
        }
    }
}
