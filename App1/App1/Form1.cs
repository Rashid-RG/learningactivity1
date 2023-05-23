using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        // Variable Declare

        private int number1;
        private int number2;
        private int result;
        ErrorProvider errorProvider;


        private int intValidation;
        public Form1()
        {
            InitializeComponent();

            // Initialise Variables on form constructor.
            number1 = 0;
            number2 = 0;
            errorProvider = new ErrorProvider();

            // change attribute

            txtResult.ReadOnly = true;
        }

        private void txtNumbe1_Validating(object sender, CancelEventArgs e)
        {
            // Clear errorProvider


            errorProvider.SetError(txtNumbe1, "");
            if ( int.TryParse(txtNumbe1.Text, out intValidation))
            { errorProvider.SetError(txtNumbe1, " please Fill the reqired field");
            
            }
        }

        private void txtNumber2_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtNumber2, "");
            if (int.TryParse(txtNumber2.Text, out intValidation))
            {
                errorProvider.SetError(txtNumber2, " please Fill the reqired field");

            }
        }

        private void txtResult_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtResult, "");
            if (int.TryParse(txtResult.Text, out intValidation))
            {
                errorProvider.SetError(txtResult, " please Fill the reqired field");

            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateChildren(ValidationConstraints.Enabled))
                {
                    number1 = int.Parse(txtNumbe1.Text);
                    number2 = int.Parse(txtNumber2.Text);
                    result = (number1 + number2);
                    txtResult.Text = result.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
