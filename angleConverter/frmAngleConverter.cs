using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleConverter
{
    public partial class frmDegreeConverter : Form
    {
        public frmDegreeConverter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Double revolution = Convert.ToDouble(txtRevolutions.Text); // input revolutions
                Double degrees = 0; // initialise input field
                degrees = revolution * 360;

                Double radians = degrees * (Math.PI / 180);
                Double milliradians = 1000 * radians;

                Double gradian = 400 * revolution;
                Double arcminute = 60 * degrees;

                // output to screen textbox
                txtDegrees.Text = degrees.ToString();
                txtRadians.Text = radians.ToString();
                txtMilliradians.Text = milliradians.ToString();
                txtGradians.Text = gradian.ToString();
                txtArcminutes.Text = arcminute.ToString();

                txtRevolutions.Focus();
            }
            catch
            {
                MessageBox.Show(
                    "Please enter a number only!", "Entry Error");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRevolutions_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDegrees_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtArcminutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGradians_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRadians_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMilliradians_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
