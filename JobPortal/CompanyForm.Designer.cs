namespace JobPortal
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlViewPostedJobs = new System.Windows.Forms.Panel();
            this.btnClosePostedJobs = new System.Windows.Forms.Button();
            this.txtSearchPostedJobs = new System.Windows.Forms.TextBox();
            this.dgvPostedJobs = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEamil = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbCompanyPhoto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchJobSeekers = new System.Windows.Forms.Button();
            this.btnViewPostedJobs = new System.Windows.Forms.Button();
            this.btnPostJobCirculer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlCumpanySecureButton = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlViewPostedJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostedJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyPhoto)).BeginInit();
            this.pnlCumpanySecureButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlViewPostedJobs);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblEamil);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pbCompanyPhoto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 364);
            this.panel1.TabIndex = 0;
            // 
            // pnlViewPostedJobs
            // 
            this.pnlViewPostedJobs.BackColor = System.Drawing.Color.Plum;
            this.pnlViewPostedJobs.Controls.Add(this.btnClosePostedJobs);
            this.pnlViewPostedJobs.Controls.Add(this.txtSearchPostedJobs);
            this.pnlViewPostedJobs.Controls.Add(this.dgvPostedJobs);
            this.pnlViewPostedJobs.Location = new System.Drawing.Point(340, 3);
            this.pnlViewPostedJobs.Name = "pnlViewPostedJobs";
            this.pnlViewPostedJobs.Size = new System.Drawing.Size(391, 332);
            this.pnlViewPostedJobs.TabIndex = 16;
            this.pnlViewPostedJobs.Visible = false;
            // 
            // btnClosePostedJobs
            // 
            this.btnClosePostedJobs.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePostedJobs.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnClosePostedJobs.FlatAppearance.BorderSize = 0;
            this.btnClosePostedJobs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnClosePostedJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClosePostedJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnClosePostedJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePostedJobs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePostedJobs.ForeColor = System.Drawing.Color.White;
            this.btnClosePostedJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePostedJobs.Image")));
            this.btnClosePostedJobs.Location = new System.Drawing.Point(356, 3);
            this.btnClosePostedJobs.Name = "btnClosePostedJobs";
            this.btnClosePostedJobs.Size = new System.Drawing.Size(32, 31);
            this.btnClosePostedJobs.TabIndex = 17;
            this.btnClosePostedJobs.UseVisualStyleBackColor = false;
            this.btnClosePostedJobs.Click += new System.EventHandler(this.BtnClosePostedJobs_Click);
            // 
            // txtSearchPostedJobs
            // 
            this.txtSearchPostedJobs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPostedJobs.Location = new System.Drawing.Point(3, 40);
            this.txtSearchPostedJobs.Name = "txtSearchPostedJobs";
            this.txtSearchPostedJobs.Size = new System.Drawing.Size(385, 26);
            this.txtSearchPostedJobs.TabIndex = 16;
            this.txtSearchPostedJobs.TextChanged += new System.EventHandler(this.TxtSearchPostedJobs_TextChanged);
            // 
            // dgvPostedJobs
            // 
            this.dgvPostedJobs.AllowUserToAddRows = false;
            this.dgvPostedJobs.AllowUserToDeleteRows = false;
            this.dgvPostedJobs.AllowUserToOrderColumns = true;
            this.dgvPostedJobs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvPostedJobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPostedJobs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPostedJobs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPostedJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPostedJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostedJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.type,
            this.category,
            this.description,
            this.vacancy,
            this.deadline,
            this.address,
            this.salary,
            this.companyid});
            this.dgvPostedJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPostedJobs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPostedJobs.EnableHeadersVisualStyles = false;
            this.dgvPostedJobs.GridColor = System.Drawing.Color.White;
            this.dgvPostedJobs.Location = new System.Drawing.Point(3, 71);
            this.dgvPostedJobs.MultiSelect = false;
            this.dgvPostedJobs.Name = "dgvPostedJobs";
            this.dgvPostedJobs.ReadOnly = true;
            this.dgvPostedJobs.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvPostedJobs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPostedJobs.RowTemplate.DividerHeight = 2;
            this.dgvPostedJobs.RowTemplate.Height = 25;
            this.dgvPostedJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostedJobs.Size = new System.Drawing.Size(385, 258);
            this.dgvPostedJobs.TabIndex = 15;
            this.dgvPostedJobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPostedJobs_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Job ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Visible = false;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Decription";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // vacancy
            // 
            this.vacancy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vacancy.DataPropertyName = "vacancy";
            this.vacancy.HeaderText = "Vacancy";
            this.vacancy.Name = "vacancy";
            this.vacancy.ReadOnly = true;
            this.vacancy.Visible = false;
            // 
            // deadline
            // 
            this.deadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deadline.DataPropertyName = "deadline";
            this.deadline.HeaderText = "Deadline";
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            this.deadline.Visible = false;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Visible = false;
            // 
            // companyid
            // 
            this.companyid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyid.DataPropertyName = "companyid";
            this.companyid.HeaderText = "Company Id";
            this.companyid.Name = "companyid";
            this.companyid.ReadOnly = true;
            this.companyid.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 35);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblEamil
            // 
            this.lblEamil.AutoSize = true;
            this.lblEamil.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEamil.ForeColor = System.Drawing.Color.Indigo;
            this.lblEamil.Location = new System.Drawing.Point(128, 203);
            this.lblEamil.Name = "lblEamil";
            this.lblEamil.Size = new System.Drawing.Size(63, 24);
            this.lblEamil.TabIndex = 11;
            this.lblEamil.Text = "label8";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Indigo;
            this.lblContact.Location = new System.Drawing.Point(128, 179);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 24);
            this.lblContact.TabIndex = 10;
            this.lblContact.Text = "label9";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Indigo;
            this.lblAddress.Location = new System.Drawing.Point(128, 227);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 24);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "label10";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Indigo;
            this.lblId.Location = new System.Drawing.Point(128, 155);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 24);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "label11";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(128, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "label12";
            // 
            // pbCompanyPhoto
            // 
            this.pbCompanyPhoto.BackColor = System.Drawing.Color.Indigo;
            this.pbCompanyPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbCompanyPhoto.Image")));
            this.pbCompanyPhoto.Location = new System.Drawing.Point(3, 3);
            this.pbCompanyPhoto.Name = "pbCompanyPhoto";
            this.pbCompanyPhoto.Size = new System.Drawing.Size(109, 109);
            this.pbCompanyPhoto.TabIndex = 6;
            this.pbCompanyPhoto.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(7, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact no:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(7, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(7, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(7, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnSearchJobSeekers
            // 
            this.btnSearchJobSeekers.AccessibleDescription = "Search People";
            this.btnSearchJobSeekers.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchJobSeekers.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnSearchJobSeekers.FlatAppearance.BorderSize = 0;
            this.btnSearchJobSeekers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnSearchJobSeekers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchJobSeekers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnSearchJobSeekers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchJobSeekers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchJobSeekers.ForeColor = System.Drawing.Color.White;
            this.btnSearchJobSeekers.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchJobSeekers.Image")));
            this.btnSearchJobSeekers.Location = new System.Drawing.Point(106, 3);
            this.btnSearchJobSeekers.Name = "btnSearchJobSeekers";
            this.btnSearchJobSeekers.Size = new System.Drawing.Size(43, 35);
            this.btnSearchJobSeekers.TabIndex = 17;
            this.btnSearchJobSeekers.UseVisualStyleBackColor = false;
            this.btnSearchJobSeekers.Click += new System.EventHandler(this.BtnSearchJobSeekers_Click);
            // 
            // btnViewPostedJobs
            // 
            this.btnViewPostedJobs.BackColor = System.Drawing.Color.Indigo;
            this.btnViewPostedJobs.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnViewPostedJobs.FlatAppearance.BorderSize = 2;
            this.btnViewPostedJobs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnViewPostedJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnViewPostedJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnViewPostedJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPostedJobs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPostedJobs.ForeColor = System.Drawing.Color.White;
            this.btnViewPostedJobs.Location = new System.Drawing.Point(348, 3);
            this.btnViewPostedJobs.Name = "btnViewPostedJobs";
            this.btnViewPostedJobs.Size = new System.Drawing.Size(168, 34);
            this.btnViewPostedJobs.TabIndex = 15;
            this.btnViewPostedJobs.Text = "View Posted Jobs";
            this.btnViewPostedJobs.UseVisualStyleBackColor = false;
            this.btnViewPostedJobs.Click += new System.EventHandler(this.BtnViewPostedJobs_Click);
            // 
            // btnPostJobCirculer
            // 
            this.btnPostJobCirculer.BackColor = System.Drawing.Color.Indigo;
            this.btnPostJobCirculer.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnPostJobCirculer.FlatAppearance.BorderSize = 2;
            this.btnPostJobCirculer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnPostJobCirculer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPostJobCirculer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnPostJobCirculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostJobCirculer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostJobCirculer.ForeColor = System.Drawing.Color.White;
            this.btnPostJobCirculer.Location = new System.Drawing.Point(155, 3);
            this.btnPostJobCirculer.Name = "btnPostJobCirculer";
            this.btnPostJobCirculer.Size = new System.Drawing.Size(187, 35);
            this.btnPostJobCirculer.TabIndex = 13;
            this.btnPostJobCirculer.Text = "Post a Job Circuler";
            this.btnPostJobCirculer.UseVisualStyleBackColor = false;
            this.btnPostJobCirculer.Click += new System.EventHandler(this.BtnPostJobCirculer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "Delete Account";
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(57, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = "Edit Account";
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(8, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(43, 35);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // pnlCumpanySecureButton
            // 
            this.pnlCumpanySecureButton.Controls.Add(this.btnEdit);
            this.pnlCumpanySecureButton.Controls.Add(this.btnDelete);
            this.pnlCumpanySecureButton.Controls.Add(this.btnSearchJobSeekers);
            this.pnlCumpanySecureButton.Controls.Add(this.btnPostJobCirculer);
            this.pnlCumpanySecureButton.Controls.Add(this.btnViewPostedJobs);
            this.pnlCumpanySecureButton.Location = new System.Drawing.Point(255, 23);
            this.pnlCumpanySecureButton.Name = "pnlCumpanySecureButton";
            this.pnlCumpanySecureButton.Size = new System.Drawing.Size(520, 41);
            this.pnlCumpanySecureButton.TabIndex = 18;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCumpanySecureButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompanyForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Comapny";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlViewPostedJobs.ResumeLayout(false);
            this.pnlViewPostedJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostedJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyPhoto)).EndInit();
            this.pnlCumpanySecureButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEamil;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbCompanyPhoto;
        private System.Windows.Forms.Button btnPostJobCirculer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewPostedJobs;
        private System.Windows.Forms.Panel pnlViewPostedJobs;
        private System.Windows.Forms.Button btnClosePostedJobs;
        private System.Windows.Forms.TextBox txtSearchPostedJobs;
        private System.Windows.Forms.DataGridView dgvPostedJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancy;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyid;
        private System.Windows.Forms.Button btnSearchJobSeekers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlCumpanySecureButton;
    }
}