namespace JobPortal
{
    partial class JobForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlJobInformation = new System.Windows.Forms.Panel();
            this.pnlApply = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlAppliedJobSeekers = new System.Windows.Forms.Panel();
            this.dgvAppliedJobSeekers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workexperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pothopath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobseekerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCloseApliedJobSeeker = new System.Windows.Forms.Button();
            this.lblMessagetoSignin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOutputDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutputCompanyName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblOutputCategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblOutputSalary = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblOutputAddress = new System.Windows.Forms.Label();
            this.lblOutputDeadline = new System.Windows.Forms.Label();
            this.lblOutputVacancy = new System.Windows.Forms.Label();
            this.lblOutputType = new System.Windows.Forms.Label();
            this.lblOutputTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblVacancy = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlVewPeoples = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewPoeples = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlJobInformation.SuspendLayout();
            this.pnlApply.SuspendLayout();
            this.pnlAppliedJobSeekers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedJobSeekers)).BeginInit();
            this.pnlVewPeoples.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitle.Location = new System.Drawing.Point(51, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // pnlJobInformation
            // 
            this.pnlJobInformation.Controls.Add(this.pnlApply);
            this.pnlJobInformation.Controls.Add(this.pnlAppliedJobSeekers);
            this.pnlJobInformation.Controls.Add(this.lblMessagetoSignin);
            this.pnlJobInformation.Controls.Add(this.btnBack);
            this.pnlJobInformation.Controls.Add(this.lblOutputDescription);
            this.pnlJobInformation.Controls.Add(this.label2);
            this.pnlJobInformation.Controls.Add(this.lblOutputCompanyName);
            this.pnlJobInformation.Controls.Add(this.lblCompany);
            this.pnlJobInformation.Controls.Add(this.lblOutputCategory);
            this.pnlJobInformation.Controls.Add(this.lblCategory);
            this.pnlJobInformation.Controls.Add(this.lblOutputSalary);
            this.pnlJobInformation.Controls.Add(this.lblSalary);
            this.pnlJobInformation.Controls.Add(this.lblOutputAddress);
            this.pnlJobInformation.Controls.Add(this.lblOutputDeadline);
            this.pnlJobInformation.Controls.Add(this.lblOutputVacancy);
            this.pnlJobInformation.Controls.Add(this.lblOutputType);
            this.pnlJobInformation.Controls.Add(this.lblOutputTitle);
            this.pnlJobInformation.Controls.Add(this.lblAddress);
            this.pnlJobInformation.Controls.Add(this.lblDeadline);
            this.pnlJobInformation.Controls.Add(this.lblVacancy);
            this.pnlJobInformation.Controls.Add(this.lblType);
            this.pnlJobInformation.Controls.Add(this.lblTitle);
            this.pnlJobInformation.Location = new System.Drawing.Point(23, 63);
            this.pnlJobInformation.Name = "pnlJobInformation";
            this.pnlJobInformation.Size = new System.Drawing.Size(754, 353);
            this.pnlJobInformation.TabIndex = 1;
            // 
            // pnlApply
            // 
            this.pnlApply.Controls.Add(this.btnApply);
            this.pnlApply.Location = new System.Drawing.Point(112, 260);
            this.pnlApply.Name = "pnlApply";
            this.pnlApply.Size = new System.Drawing.Size(104, 44);
            this.pnlApply.TabIndex = 24;
            this.pnlApply.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnApply.FlatAppearance.BorderSize = 2;
            this.btnApply.FlatAppearance.CheckedBackColor = System.Drawing.Color.SaddleBrown;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(3, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 37);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // pnlAppliedJobSeekers
            // 
            this.pnlAppliedJobSeekers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAppliedJobSeekers.Controls.Add(this.dgvAppliedJobSeekers);
            this.pnlAppliedJobSeekers.Controls.Add(this.btnCloseApliedJobSeeker);
            this.pnlAppliedJobSeekers.Location = new System.Drawing.Point(432, 64);
            this.pnlAppliedJobSeekers.Name = "pnlAppliedJobSeekers";
            this.pnlAppliedJobSeekers.Size = new System.Drawing.Size(322, 282);
            this.pnlAppliedJobSeekers.TabIndex = 21;
            this.pnlAppliedJobSeekers.Visible = false;
            // 
            // dgvAppliedJobSeekers
            // 
            this.dgvAppliedJobSeekers.AllowUserToAddRows = false;
            this.dgvAppliedJobSeekers.AllowUserToDeleteRows = false;
            this.dgvAppliedJobSeekers.AllowUserToOrderColumns = true;
            this.dgvAppliedJobSeekers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAppliedJobSeekers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppliedJobSeekers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppliedJobSeekers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliedJobSeekers.ColumnHeadersVisible = false;
            this.dgvAppliedJobSeekers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.password,
            this.name,
            this.address,
            this.contactno,
            this.email,
            this.gender,
            this.dateofbirth,
            this.bloodgroup,
            this.skill,
            this.workexperience,
            this.pothopath,
            this.jobseekerid,
            this.jobid});
            this.dgvAppliedJobSeekers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppliedJobSeekers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppliedJobSeekers.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvAppliedJobSeekers.Location = new System.Drawing.Point(3, 42);
            this.dgvAppliedJobSeekers.Name = "dgvAppliedJobSeekers";
            this.dgvAppliedJobSeekers.ReadOnly = true;
            this.dgvAppliedJobSeekers.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAppliedJobSeekers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppliedJobSeekers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAppliedJobSeekers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppliedJobSeekers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dgvAppliedJobSeekers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.dgvAppliedJobSeekers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAppliedJobSeekers.RowTemplate.DividerHeight = 1;
            this.dgvAppliedJobSeekers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppliedJobSeekers.Size = new System.Drawing.Size(316, 237);
            this.dgvAppliedJobSeekers.TabIndex = 15;
            this.dgvAppliedJobSeekers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAppliedJobSeekers_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // contactno
            // 
            this.contactno.DataPropertyName = "contactno";
            this.contactno.HeaderText = "Contact";
            this.contactno.Name = "contactno";
            this.contactno.ReadOnly = true;
            this.contactno.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Visible = false;
            // 
            // dateofbirth
            // 
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "DateOfBirth";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            this.dateofbirth.Visible = false;
            // 
            // bloodgroup
            // 
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "Blood Group";
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            this.bloodgroup.Visible = false;
            // 
            // skill
            // 
            this.skill.DataPropertyName = "skill";
            this.skill.HeaderText = "Skills";
            this.skill.Name = "skill";
            this.skill.ReadOnly = true;
            this.skill.Visible = false;
            // 
            // workexperience
            // 
            this.workexperience.DataPropertyName = "workexperience";
            this.workexperience.HeaderText = "Experience";
            this.workexperience.Name = "workexperience";
            this.workexperience.ReadOnly = true;
            this.workexperience.Visible = false;
            // 
            // pothopath
            // 
            this.pothopath.DataPropertyName = "photopath";
            this.pothopath.HeaderText = "Photo";
            this.pothopath.Name = "pothopath";
            this.pothopath.ReadOnly = true;
            this.pothopath.Visible = false;
            // 
            // jobseekerid
            // 
            this.jobseekerid.DataPropertyName = "jobseekerid";
            this.jobseekerid.HeaderText = "Jobseekerid";
            this.jobseekerid.Name = "jobseekerid";
            this.jobseekerid.ReadOnly = true;
            this.jobseekerid.Visible = false;
            // 
            // jobid
            // 
            this.jobid.DataPropertyName = "jobid";
            this.jobid.HeaderText = "Job Id";
            this.jobid.Name = "jobid";
            this.jobid.ReadOnly = true;
            this.jobid.Visible = false;
            // 
            // btnCloseApliedJobSeeker
            // 
            this.btnCloseApliedJobSeeker.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApliedJobSeeker.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnCloseApliedJobSeeker.FlatAppearance.BorderSize = 0;
            this.btnCloseApliedJobSeeker.FlatAppearance.CheckedBackColor = System.Drawing.Color.SaddleBrown;
            this.btnCloseApliedJobSeeker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnCloseApliedJobSeeker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnCloseApliedJobSeeker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApliedJobSeeker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApliedJobSeeker.ForeColor = System.Drawing.Color.White;
            this.btnCloseApliedJobSeeker.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApliedJobSeeker.Image")));
            this.btnCloseApliedJobSeeker.Location = new System.Drawing.Point(286, 3);
            this.btnCloseApliedJobSeeker.Name = "btnCloseApliedJobSeeker";
            this.btnCloseApliedJobSeeker.Size = new System.Drawing.Size(33, 33);
            this.btnCloseApliedJobSeeker.TabIndex = 17;
            this.btnCloseApliedJobSeeker.UseVisualStyleBackColor = false;
            this.btnCloseApliedJobSeeker.Click += new System.EventHandler(this.BtnCloseApliedJobSeeker_Click);
            // 
            // lblMessagetoSignin
            // 
            this.lblMessagetoSignin.AutoSize = true;
            this.lblMessagetoSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMessagetoSignin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessagetoSignin.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessagetoSignin.Location = new System.Drawing.Point(51, 238);
            this.lblMessagetoSignin.Name = "lblMessagetoSignin";
            this.lblMessagetoSignin.Size = new System.Drawing.Size(150, 19);
            this.lblMessagetoSignin.TabIndex = 26;
            this.lblMessagetoSignin.Text = "Please Sign In to Apply";
            this.lblMessagetoSignin.Visible = false;
            this.lblMessagetoSignin.Click += new System.EventHandler(this.LblMessagetoSignin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 309);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 37);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblOutputDescription
            // 
            this.lblOutputDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDescription.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputDescription.Location = new System.Drawing.Point(337, 50);
            this.lblOutputDescription.Name = "lblOutputDescription";
            this.lblOutputDescription.Size = new System.Drawing.Size(413, 293);
            this.lblOutputDescription.TabIndex = 23;
            this.lblOutputDescription.Text = "lblOutputDescription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(337, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Description:";
            // 
            // lblOutputCompanyName
            // 
            this.lblOutputCompanyName.AutoSize = true;
            this.lblOutputCompanyName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputCompanyName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputCompanyName.Location = new System.Drawing.Point(158, 26);
            this.lblOutputCompanyName.Name = "lblOutputCompanyName";
            this.lblOutputCompanyName.Size = new System.Drawing.Size(156, 22);
            this.lblOutputCompanyName.TabIndex = 20;
            this.lblOutputCompanyName.Text = "lblCompanyName";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCompany.Location = new System.Drawing.Point(51, 26);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(93, 22);
            this.lblCompany.TabIndex = 19;
            this.lblCompany.Text = "Company:";
            // 
            // lblOutputCategory
            // 
            this.lblOutputCategory.AutoSize = true;
            this.lblOutputCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputCategory.Location = new System.Drawing.Point(157, 96);
            this.lblOutputCategory.Name = "lblOutputCategory";
            this.lblOutputCategory.Size = new System.Drawing.Size(59, 22);
            this.lblOutputCategory.TabIndex = 18;
            this.lblOutputCategory.Text = "label7";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCategory.Location = new System.Drawing.Point(51, 96);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 22);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // lblOutputSalary
            // 
            this.lblOutputSalary.AutoSize = true;
            this.lblOutputSalary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputSalary.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputSalary.Location = new System.Drawing.Point(157, 162);
            this.lblOutputSalary.Name = "lblOutputSalary";
            this.lblOutputSalary.Size = new System.Drawing.Size(59, 22);
            this.lblOutputSalary.TabIndex = 16;
            this.lblOutputSalary.Text = "label1";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSalary.Location = new System.Drawing.Point(51, 162);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(68, 22);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary:";
            // 
            // lblOutputAddress
            // 
            this.lblOutputAddress.AutoSize = true;
            this.lblOutputAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputAddress.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputAddress.Location = new System.Drawing.Point(157, 185);
            this.lblOutputAddress.Name = "lblOutputAddress";
            this.lblOutputAddress.Size = new System.Drawing.Size(69, 22);
            this.lblOutputAddress.TabIndex = 11;
            this.lblOutputAddress.Text = "label10";
            // 
            // lblOutputDeadline
            // 
            this.lblOutputDeadline.AutoSize = true;
            this.lblOutputDeadline.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDeadline.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputDeadline.Location = new System.Drawing.Point(158, 140);
            this.lblOutputDeadline.Name = "lblOutputDeadline";
            this.lblOutputDeadline.Size = new System.Drawing.Size(68, 22);
            this.lblOutputDeadline.TabIndex = 10;
            this.lblOutputDeadline.Text = "label11";
            // 
            // lblOutputVacancy
            // 
            this.lblOutputVacancy.AutoSize = true;
            this.lblOutputVacancy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputVacancy.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputVacancy.Location = new System.Drawing.Point(158, 116);
            this.lblOutputVacancy.Name = "lblOutputVacancy";
            this.lblOutputVacancy.Size = new System.Drawing.Size(69, 22);
            this.lblOutputVacancy.TabIndex = 9;
            this.lblOutputVacancy.Text = "label12";
            // 
            // lblOutputType
            // 
            this.lblOutputType.AutoSize = true;
            this.lblOutputType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputType.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputType.Location = new System.Drawing.Point(158, 73);
            this.lblOutputType.Name = "lblOutputType";
            this.lblOutputType.Size = new System.Drawing.Size(69, 22);
            this.lblOutputType.TabIndex = 8;
            this.lblOutputType.Text = "label13";
            // 
            // lblOutputTitle
            // 
            this.lblOutputTitle.AutoSize = true;
            this.lblOutputTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOutputTitle.Location = new System.Drawing.Point(158, 50);
            this.lblOutputTitle.Name = "lblOutputTitle";
            this.lblOutputTitle.Size = new System.Drawing.Size(69, 22);
            this.lblOutputTitle.TabIndex = 7;
            this.lblOutputTitle.Text = "label14";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAddress.Location = new System.Drawing.Point(49, 185);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 22);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDeadline.Location = new System.Drawing.Point(51, 140);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(82, 22);
            this.lblDeadline.TabIndex = 3;
            this.lblDeadline.Text = "Deadine:";
            // 
            // lblVacancy
            // 
            this.lblVacancy.AutoSize = true;
            this.lblVacancy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancy.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblVacancy.Location = new System.Drawing.Point(49, 116);
            this.lblVacancy.Name = "lblVacancy";
            this.lblVacancy.Size = new System.Drawing.Size(83, 22);
            this.lblVacancy.TabIndex = 2;
            this.lblVacancy.Text = "Vacancy:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblType.Location = new System.Drawing.Point(51, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 22);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type:";
            // 
            // pnlVewPeoples
            // 
            this.pnlVewPeoples.Controls.Add(this.btnDelete);
            this.pnlVewPeoples.Controls.Add(this.btnViewPoeples);
            this.pnlVewPeoples.Controls.Add(this.btnEdit);
            this.pnlVewPeoples.Location = new System.Drawing.Point(469, 18);
            this.pnlVewPeoples.Name = "pnlVewPeoples";
            this.pnlVewPeoples.Size = new System.Drawing.Size(308, 46);
            this.pnlVewPeoples.TabIndex = 25;
            this.pnlVewPeoples.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(54, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 37);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnViewPoeples
            // 
            this.btnViewPoeples.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnViewPoeples.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnViewPoeples.FlatAppearance.BorderSize = 2;
            this.btnViewPoeples.FlatAppearance.CheckedBackColor = System.Drawing.Color.SaddleBrown;
            this.btnViewPoeples.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnViewPoeples.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnViewPoeples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPoeples.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPoeples.ForeColor = System.Drawing.Color.White;
            this.btnViewPoeples.Location = new System.Drawing.Point(101, 4);
            this.btnViewPoeples.Name = "btnViewPoeples";
            this.btnViewPoeples.Size = new System.Drawing.Size(203, 37);
            this.btnViewPoeples.TabIndex = 14;
            this.btnViewPoeples.Text = "View Peoples Applied";
            this.btnViewPoeples.UseVisualStyleBackColor = false;
            this.btnViewPoeples.Click += new System.EventHandler(this.BtnViewPoeples_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(5, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(43, 37);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.pnlJobInformation);
            this.Controls.Add(this.pnlVewPeoples);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JobForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Job Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JobForm_FormClosed);
            this.pnlJobInformation.ResumeLayout(false);
            this.pnlJobInformation.PerformLayout();
            this.pnlApply.ResumeLayout(false);
            this.pnlAppliedJobSeekers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedJobSeekers)).EndInit();
            this.pnlVewPeoples.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlJobInformation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblVacancy;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblOutputAddress;
        private System.Windows.Forms.Label lblOutputDeadline;
        private System.Windows.Forms.Label lblOutputVacancy;
        private System.Windows.Forms.Label lblOutputType;
        private System.Windows.Forms.Label lblOutputTitle;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblOutputCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblOutputSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblOutputCompanyName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Panel pnlAppliedJobSeekers;
        private System.Windows.Forms.Button btnCloseApliedJobSeeker;
        private System.Windows.Forms.DataGridView dgvAppliedJobSeekers;
        private System.Windows.Forms.Label lblOutputDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlApply;
        private System.Windows.Forms.Panel pnlVewPeoples;
        private System.Windows.Forms.Button btnViewPoeples;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill;
        private System.Windows.Forms.DataGridViewTextBoxColumn workexperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn pothopath;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobseekerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobid;
        private System.Windows.Forms.Label lblMessagetoSignin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}