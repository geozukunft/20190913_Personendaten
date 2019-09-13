using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personendaten
{
    public partial class Form1 : Form
    {
        private string gender;
        public Form1()
        {
            InitializeComponent();
            gboGender.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gboGender_Enter(object sender, EventArgs e)
        {

        }

        private void cmdResult_Click(object sender, EventArgs e)
        {
            if(rdoFemale.Checked == true)
            {
                gender = rdoFemale.Text;
                lblResult.BackColor = Color.Pink;
            }
            else if(rdoMale.Checked == true)
            {
                gender = rdoMale.Text;
                lblResult.BackColor = Color.Blue;
            }
            else
            {
                gender = "An exception was thrown 0x000001";
            }
            lblResult.Text = "Sie heißen " + txtFirstName.Text + " " + txtLastname.Text +
                "\nSie sind " + numBirthyear.Value + " geboren" +
                "\nIhr Geschlecht ist " + gender;


        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
