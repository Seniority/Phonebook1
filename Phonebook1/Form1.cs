using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxNumType1.SelectedIndex = 0;
            cbxNumType2.SelectedIndex = 1;
            cbxNumType3.SelectedIndex = 2;
            cbxNumType4.SelectedIndex = 3;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Number 1
        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            if (txtNumber1.Text == "Primary Number")
            {
                txtNumber1.Clear();
                txtNumber1.ForeColor = Color.Black;
            }
        }

        private void txtNumber1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber1.Text))
            {
                txtNumber1.Text = "Primary Number";
                txtNumber1.ForeColor = SystemColors.ScrollBar;
            }
        }

        // Number 2
        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            if (txtNumber2.Text == "Secondary Number")
            {
                txtNumber2.Clear();
                txtNumber2.ForeColor = Color.Black;
            }
        }

        private void txtNumber2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber2.Text))
            {
                txtNumber2.Text = "Secondary Number";
                txtNumber2.ForeColor = SystemColors.ScrollBar;
            }
        }

        // Number 3
        private void txtNumber3_Enter(object sender, EventArgs e)
        {
            if (txtNumber3.Text == "Other")
            {
                txtNumber3.Clear();
                txtNumber3.ForeColor = Color.Black;
            }
        }

        private void txtNumber3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber3.Text))
            {
                txtNumber3.Text = "Other";
                txtNumber3.ForeColor = SystemColors.ScrollBar;
            }
        }

        // Number 4
        private void txtNumber4_Enter(object sender, EventArgs e)
        {
            if (txtNumber4.Text == "Fax")
            {
                txtNumber4.Clear();
                txtNumber4.ForeColor = Color.Black;
            }
        }

        private void txtNumber4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber4.Text))
            {
                txtNumber4.Text = "Fax";
                txtNumber4.ForeColor = SystemColors.ScrollBar;
            }
        }


    } //end Class
} //end Namespace
