using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            // Set combobox default values
            cbxNumType1.SelectedIndex = 0;
            cbxNumType2.SelectedIndex = 0;
            cbxNumType3.SelectedIndex = 0;
            cbxNumType4.SelectedIndex = 0;
        }

        static AppData db;
        protected static AppData App
        {
            get
            {
                if (db == null)
                {
                    db = new AppData();
                }
                return db;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
            {
                App.Phonebook.ReadXml(fileName);
            }
            phonebookBindingSource.DataSource = App.Phonebook;
            panel1.Enabled = false;
        }

        /*--------------------------------------------------------------------- Menu Strip ---------------------------------------------------------------------*/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*--------------------------------------------------------------------- Form Panel ---------------------------------------------------------------------*/
        // Textbox for Number 1
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

        // Textbox for Number 2
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

        // Textbox for Number 3
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

        // Textbox for Number 4
        private void txtNumber4_Enter(object sender, EventArgs e)
        {
            if (txtNumber4.Text == "Other")
            {
                txtNumber4.Clear();
                txtNumber4.ForeColor = Color.Black;
            }
        }

        private void txtNumber4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber4.Text))
            {
                txtNumber4.Text = "Other";
                txtNumber4.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                App.Phonebook.AddPhonebookRow(App.Phonebook.NewPhonebookRow());
                phonebookBindingSource.MoveLast();
                txtFirstname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Phonebook.RejectChanges();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtFirstname.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                phonebookBindingSource.EndEdit();
                App.Phonebook.AcceptChanges();
                App.Phonebook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                panel1.Enabled = false;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Phonebook.RejectChanges();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            phonebookBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phonebookBindingSource.RemoveCurrent();
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
                        
        }
    } //end Class
} //end Namespace
