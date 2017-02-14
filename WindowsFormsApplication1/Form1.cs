using PresidentialEligibilityCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckEligibilityButton_Click(object sender, EventArgs e)
        {
            PresidentialEligibility pE = new PresidentialEligibility(naturalCitizenCheckBox.Checked, int.Parse(yearOfBirthAnswer.Text),
                int.Parse(yearsResidedAnswer.Text), int.Parse(priorTermsAnswer.Text), impeachedCheckBox.Checked, rebelledCheckBox.Checked);

            string title = "Presidential Eligibility";

            if (pE.isEligible())
                MessageBox.Show("Eligible to be President of US", title);
            else
                MessageBox.Show("Not Eligible to be President of US", title);


        }
    }
}
