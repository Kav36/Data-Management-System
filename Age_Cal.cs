using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_testing
{
    public partial class frmca : Form
    {
        public frmca()
        {
            InitializeComponent();
        }

        private void btndobcal_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dob = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime current = DateTime.Now;
                // get the current date to calculate
                TimeSpan t = current - dob;
                DateTime age = DateTime.MinValue.AddDays(t.Days);
                txtyr.Text = " you have " + (age.Year - 1).ToString() + " years " + (age.Month - 1) + " months " + (age.Day - 1) + " days old. ";
            }
            catch
            {
                MessageBox.Show("System can't calculate the future years.");
                txtyr.Clear();
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtyr.Clear();
        }

        private void frmca_Load(object sender, EventArgs e)
        {

        }
    }
}
