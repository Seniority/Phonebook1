namespace Phonebook1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.cbxNumType1 = new System.Windows.Forms.ComboBox();
            this.cbxNumType2 = new System.Windows.Forms.ComboBox();
            this.cbxNumType4 = new System.Windows.Forms.ComboBox();
            this.cbxNumType3 = new System.Windows.Forms.ComboBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtNumber4 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(792, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 173);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(855, 300);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.cbxNumType4);
            this.panel1.Controls.Add(this.cbxNumType3);
            this.panel1.Controls.Add(this.txtNumber3);
            this.panel1.Controls.Add(this.txtNumber4);
            this.panel1.Controls.Add(this.cbxNumType2);
            this.panel1.Controls.Add(this.cbxNumType1);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.txtNumber2);
            this.panel1.Controls.Add(this.txtNumber1);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.lblFirstname);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 114);
            this.panel1.TabIndex = 0;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(89, 3);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(157, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(3, 6);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(80, 17);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "First Name:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(335, 3);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(157, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(89, 29);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(157, 20);
            this.txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(335, 31);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(157, 20);
            this.txtNumber2.TabIndex = 6;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(252, 6);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(80, 17);
            this.lblLastname.TabIndex = 0;
            this.lblLastname.Text = "Last Name:";
            // 
            // cbxNumType1
            // 
            this.cbxNumType1.DisplayMember = "0";
            this.cbxNumType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumType1.FormattingEnabled = true;
            this.cbxNumType1.Items.AddRange(new object[] {
            "Phone",
            "Mobile",
            "Work",
            "Fax"});
            this.cbxNumType1.Location = new System.Drawing.Point(6, 29);
            this.cbxNumType1.Name = "cbxNumType1";
            this.cbxNumType1.Size = new System.Drawing.Size(77, 21);
            this.cbxNumType1.TabIndex = 3;
            // 
            // cbxNumType2
            // 
            this.cbxNumType2.DisplayMember = "1";
            this.cbxNumType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumType2.FormattingEnabled = true;
            this.cbxNumType2.Items.AddRange(new object[] {
            "Phone",
            "Mobile",
            "Work",
            "Fax"});
            this.cbxNumType2.Location = new System.Drawing.Point(252, 29);
            this.cbxNumType2.Name = "cbxNumType2";
            this.cbxNumType2.Size = new System.Drawing.Size(77, 21);
            this.cbxNumType2.TabIndex = 5;
            // 
            // cbxNumType4
            // 
            this.cbxNumType4.DisplayMember = "3";
            this.cbxNumType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumType4.FormattingEnabled = true;
            this.cbxNumType4.Items.AddRange(new object[] {
            "Phone",
            "Mobile",
            "Work",
            "Fax"});
            this.cbxNumType4.Location = new System.Drawing.Point(252, 56);
            this.cbxNumType4.Name = "cbxNumType4";
            this.cbxNumType4.Size = new System.Drawing.Size(77, 21);
            this.cbxNumType4.TabIndex = 9;
            // 
            // cbxNumType3
            // 
            this.cbxNumType3.DisplayMember = "2";
            this.cbxNumType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumType3.FormattingEnabled = true;
            this.cbxNumType3.Items.AddRange(new object[] {
            "Phone",
            "Mobile",
            "Work",
            "Fax"});
            this.cbxNumType3.Location = new System.Drawing.Point(6, 54);
            this.cbxNumType3.Name = "cbxNumType3";
            this.cbxNumType3.Size = new System.Drawing.Size(77, 21);
            this.cbxNumType3.TabIndex = 7;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(89, 56);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(157, 20);
            this.txtNumber3.TabIndex = 8;
            // 
            // txtNumber4
            // 
            this.txtNumber4.Location = new System.Drawing.Point(335, 56);
            this.txtNumber4.Name = "txtNumber4";
            this.txtNumber4.Size = new System.Drawing.Size(157, 20);
            this.txtNumber4.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(37, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(403, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(498, 6);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(568, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(287, 100);
            this.txtAddress.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 147);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(766, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(711, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(630, 479);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(549, 479);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(31, 147);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 511);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbxNumType4;
        private System.Windows.Forms.ComboBox cbxNumType3;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtNumber4;
        private System.Windows.Forms.ComboBox cbxNumType2;
        private System.Windows.Forms.ComboBox cbxNumType1;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

