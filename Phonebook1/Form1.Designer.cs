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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbxNumType4 = new System.Windows.Forms.ComboBox();
            this.cbxNumType3 = new System.Windows.Forms.ComboBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtNumber4 = new System.Windows.Forms.TextBox();
            this.cbxNumType2 = new System.Windows.Forms.ComboBox();
            this.cbxNumType1 = new System.Windows.Forms.ComboBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phonebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Phonebook1.AppData();
            this.phonebookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource7)).BeginInit();
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.number1DataGridViewTextBoxColumn,
            this.number2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.number3DataGridViewTextBoxColumn,
            this.number4DataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.phonebookBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 173);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(855, 300);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
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
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(568, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(287, 100);
            this.txtAddress.TabIndex = 12;
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
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(89, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(403, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // cbxNumType4
            // 
            this.cbxNumType4.DisplayMember = "3";
            this.cbxNumType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumType4.FormattingEnabled = true;
            this.cbxNumType4.Items.AddRange(new object[] {
            "-Type-",
            "Phone",
            "Mobile",
            "Business/Office",
            "Fax",
            "Other"});
            this.cbxNumType4.Location = new System.Drawing.Point(255, 54);
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
            "-Type-",
            "Phone",
            "Mobile",
            "Business/Office",
            "Fax",
            "Other"});
            this.cbxNumType3.Location = new System.Drawing.Point(6, 54);
            this.cbxNumType3.Name = "cbxNumType3";
            this.cbxNumType3.Size = new System.Drawing.Size(77, 21);
            this.cbxNumType3.TabIndex = 7;
            // 
            // txtNumber3
            // 
            this.txtNumber3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Number 3", true));
            this.txtNumber3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumber3.Location = new System.Drawing.Point(89, 54);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(157, 20);
            this.txtNumber3.TabIndex = 8;
            this.txtNumber3.Text = "Other";
            this.txtNumber3.Enter += new System.EventHandler(this.txtNumber3_Enter);
            this.txtNumber3.Leave += new System.EventHandler(this.txtNumber3_Leave);
            // 
            // txtNumber4
            // 
            this.txtNumber4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Number 4", true));
            this.txtNumber4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumber4.Location = new System.Drawing.Point(335, 56);
            this.txtNumber4.Name = "txtNumber4";
            this.txtNumber4.Size = new System.Drawing.Size(157, 20);
            this.txtNumber4.TabIndex = 10;
            this.txtNumber4.Text = "Other";
            this.txtNumber4.Enter += new System.EventHandler(this.txtNumber4_Enter);
            this.txtNumber4.Leave += new System.EventHandler(this.txtNumber4_Leave);
            // 
            // cbxNumType2
            // 
            this.cbxNumType2.DisplayMember = "1";
            this.cbxNumType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumType2.FormattingEnabled = true;
            this.cbxNumType2.Items.AddRange(new object[] {
            "-Type-",
            "Phone",
            "Mobile",
            "Business/Office",
            "Fax",
            "Other"});
            this.cbxNumType2.Location = new System.Drawing.Point(255, 29);
            this.cbxNumType2.Name = "cbxNumType2";
            this.cbxNumType2.Size = new System.Drawing.Size(77, 21);
            this.cbxNumType2.TabIndex = 5;
            // 
            // cbxNumType1
            // 
            this.cbxNumType1.DisplayMember = "0";
            this.cbxNumType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumType1.FormattingEnabled = true;
            this.cbxNumType1.Items.AddRange(new object[] {
            "-Type-",
            "Phone",
            "Mobile",
            "Business/Office",
            "Fax",
            "Other"});
            this.cbxNumType1.Location = new System.Drawing.Point(6, 29);
            this.cbxNumType1.Name = "cbxNumType1";
            this.cbxNumType1.Size = new System.Drawing.Size(77, 21);
            this.cbxNumType1.TabIndex = 3;
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
            // txtNumber2
            // 
            this.txtNumber2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Number 2", true));
            this.txtNumber2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumber2.Location = new System.Drawing.Point(335, 29);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(157, 20);
            this.txtNumber2.TabIndex = 6;
            this.txtNumber2.Text = "Secondary Number";
            this.txtNumber2.Enter += new System.EventHandler(this.txtNumber2_Enter);
            this.txtNumber2.Leave += new System.EventHandler(this.txtNumber2_Leave);
            // 
            // txtNumber1
            // 
            this.txtNumber1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Number 1", true));
            this.txtNumber1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumber1.Location = new System.Drawing.Point(89, 29);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(157, 20);
            this.txtNumber1.TabIndex = 4;
            this.txtNumber1.Text = "Primary Number";
            this.txtNumber1.Enter += new System.EventHandler(this.txtNumber1_Enter);
            this.txtNumber1.Leave += new System.EventHandler(this.txtNumber1_Leave);
            // 
            // txtLastname
            // 
            this.txtLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Last Name", true));
            this.txtLastname.Location = new System.Drawing.Point(335, 3);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(157, 20);
            this.txtLastname.TabIndex = 2;
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
            // txtFirstname
            // 
            this.txtFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "First Name", true));
            this.txtFirstname.Location = new System.Drawing.Point(89, 3);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(157, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 147);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(766, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(711, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(630, 479);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(549, 479);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(879, 24);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // phonebookBindingSource
            // 
            this.phonebookBindingSource.DataMember = "Phonebook";
            this.phonebookBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonebookBindingSource1
            // 
            this.phonebookBindingSource1.DataMember = "Phonebook";
            this.phonebookBindingSource1.DataSource = this.appData;
            // 
            // phonebookBindingSource2
            // 
            this.phonebookBindingSource2.DataMember = "Phonebook";
            this.phonebookBindingSource2.DataSource = this.appData;
            // 
            // phonebookBindingSource3
            // 
            this.phonebookBindingSource3.DataMember = "Phonebook";
            this.phonebookBindingSource3.DataSource = this.appData;
            // 
            // phonebookBindingSource4
            // 
            this.phonebookBindingSource4.DataMember = "Phonebook";
            this.phonebookBindingSource4.DataSource = this.appData;
            // 
            // phonebookBindingSource5
            // 
            this.phonebookBindingSource5.DataMember = "Phonebook";
            this.phonebookBindingSource5.DataSource = this.appData;
            // 
            // phonebookBindingSource6
            // 
            this.phonebookBindingSource6.DataMember = "Phonebook";
            this.phonebookBindingSource6.DataSource = this.appData;
            // 
            // phonebookBindingSource7
            // 
            this.phonebookBindingSource7.DataMember = "Phonebook";
            this.phonebookBindingSource7.DataSource = this.appData;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // number1DataGridViewTextBoxColumn
            // 
            this.number1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number1DataGridViewTextBoxColumn.DataPropertyName = "Number 1";
            this.number1DataGridViewTextBoxColumn.HeaderText = "Number 1";
            this.number1DataGridViewTextBoxColumn.Name = "number1DataGridViewTextBoxColumn";
            this.number1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // number2DataGridViewTextBoxColumn
            // 
            this.number2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number2DataGridViewTextBoxColumn.DataPropertyName = "Number 2";
            this.number2DataGridViewTextBoxColumn.HeaderText = "Number 2";
            this.number2DataGridViewTextBoxColumn.Name = "number2DataGridViewTextBoxColumn";
            this.number2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // number3DataGridViewTextBoxColumn
            // 
            this.number3DataGridViewTextBoxColumn.DataPropertyName = "Number 3";
            this.number3DataGridViewTextBoxColumn.HeaderText = "Number 3";
            this.number3DataGridViewTextBoxColumn.Name = "number3DataGridViewTextBoxColumn";
            this.number3DataGridViewTextBoxColumn.Visible = false;
            // 
            // number4DataGridViewTextBoxColumn
            // 
            this.number4DataGridViewTextBoxColumn.DataPropertyName = "Number 4";
            this.number4DataGridViewTextBoxColumn.HeaderText = "Number 4";
            this.number4DataGridViewTextBoxColumn.Name = "number4DataGridViewTextBoxColumn";
            this.number4DataGridViewTextBoxColumn.Visible = false;
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
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource7)).EndInit();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.BindingSource phonebookBindingSource7;
        private AppData appData;
        private System.Windows.Forms.BindingSource phonebookBindingSource6;
        private System.Windows.Forms.BindingSource phonebookBindingSource4;
        private System.Windows.Forms.BindingSource phonebookBindingSource5;
        private System.Windows.Forms.BindingSource phonebookBindingSource3;
        private System.Windows.Forms.BindingSource phonebookBindingSource2;
        private System.Windows.Forms.BindingSource phonebookBindingSource1;
        private System.Windows.Forms.BindingSource phonebookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number4DataGridViewTextBoxColumn;
    }
}

