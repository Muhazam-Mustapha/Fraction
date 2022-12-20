using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class MainForm : Form
    {
        Fraction myFraction = new Fraction();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CopyNumerButton_Click(object sender, EventArgs e)
        {
            int temp;

            try { 
               temp = Convert.ToInt32(NumerTextBox.Text); }
            catch (Exception excep) {
                MsgLabel.Text = "Message: Please give a valid value";
                return; }

            myFraction.Numerator = temp;
            NumerLabel.Text = Convert.ToString(temp);
        }

        private void DenomCopyButton_Click(object sender, EventArgs e)
        {
            int temp;

            try { 
               temp = Convert.ToInt32(DenomTextBox.Text); }
            catch (Exception excep) {
                MsgLabel.Text = "Message: Please give a valid value";
                return; }

            myFraction.Denominator = temp;
            DenomLabel.Text = Convert.ToString(temp);
        }

        private void DisplayValuaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DisplayValueCheckBox.Checked == true) {
               if (_3DigRadioButton.Checked == true)
                  ValueLabel.Text = myFraction.Value().ToString("0.000");
               if (_5DigRadioButton.Checked == true)
                  ValueLabel.Text = myFraction.Value().ToString("0.00000");
               if (_10DigRadioButton.Checked == true)
                  ValueLabel.Text = myFraction.Value().ToString("0.0000000000"); }
            else
               ValueLabel.Text = "";
        }

        private void NormalizeButton_Click(object sender, EventArgs e)
        {
            myFraction.Normalize();

            NumerLabel.Text = myFraction.Numerator.ToString();
            DenomLabel.Text = myFraction.Denominator.ToString();
        }
    }
}
