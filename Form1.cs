using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*********************************************************
         * Executed when the form is first loaded
         * Sets lblDate to the current date
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }


        private void btnHonors_Click(object sender, EventArgs e)
        {
            double gpa;

            try
            {
                gpa = Convert.ToSingle(txtGPA.Text);
                lblMessage.Text = "";

                if(gpa <= 0 || gpa > 4)
                {
                    MessageBox.Show("Please enter a valid GPA", "Invalid GPA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (gpa >= 3.75) // Honors
                {
                    lblMessage.Text = "HONORS STUDENTS";
                    MessageBox.Show("Congratulations " + txtFirstName.Text.ToUpper() +
                        "!! You will graduate with honors.",
                        "HONORS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else // No Honors
                {
                    MessageBox.Show("Sorry - No honors for you - better luck next time",
                        "No Honors");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //*****************************************************************************
        //Exit the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
