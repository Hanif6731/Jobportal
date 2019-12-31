namespace JobPortal
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlJobSeeker = new System.Windows.Forms.Panel();
            this.btnSearchJobSeeker = new System.Windows.Forms.Button();
            this.txtCgpa2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchJobSeekerBoard = new System.Windows.Forms.TextBox();
            this.txtSearchJobSeekerCGPA = new System.Windows.Forms.TextBox();
            this.txtSearchJobSeekerName = new System.Windows.Forms.TextBox();
            this.dgvJobSeekers = new System.Windows.Forms.DataGridView();
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
            this.pnlJob = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchJobAddress = new System.Windows.Forms.TextBox();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.dgvJob = new System.Windows.Forms.DataGridView();
            this.jid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchJobtitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            this.pnlJobSeeker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSeekers)).BeginInit();
            this.pnlJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnBack);
            this.pnlSearch.Controls.Add(this.pnlJobSeeker);
            this.pnlSearch.Controls.Add(this.pnlJob);
            this.pnlSearch.Location = new System.Drawing.Point(23, 63);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(754, 364);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 35);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pnlJobSeeker
            // 
            this.pnlJobSeeker.Controls.Add(this.btnSearchJobSeeker);
            this.pnlJobSeeker.Controls.Add(this.txtCgpa2);
            this.pnlJobSeeker.Controls.Add(this.label3);
            this.pnlJobSeeker.Controls.Add(this.label2);
            this.pnlJobSeeker.Controls.Add(this.label1);
            this.pnlJobSeeker.Controls.Add(this.txtSearchJobSeekerBoard);
            this.pnlJobSeeker.Controls.Add(this.txtSearchJobSeekerCGPA);
            this.pnlJobSeeker.Controls.Add(this.txtSearchJobSeekerName);
            this.pnlJobSeeker.Controls.Add(this.dgvJobSeekers);
            this.pnlJobSeeker.Location = new System.Drawing.Point(0, 13);
            this.pnlJobSeeker.Name = "pnlJobSeeker";
            this.pnlJobSeeker.Size = new System.Drawing.Size(754, 310);
            this.pnlJobSeeker.TabIndex = 19;
            this.pnlJobSeeker.Visible = false;
            // 
            // btnSearchJobSeeker
            // 
            this.btnSearchJobSeeker.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearchJobSeeker.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSearchJobSeeker.FlatAppearance.BorderSize = 2;
            this.btnSearchJobSeeker.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.btnSearchJobSeeker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnSearchJobSeeker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearchJobSeeker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchJobSeeker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchJobSeeker.ForeColor = System.Drawing.Color.White;
            this.btnSearchJobSeeker.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchJobSeeker.Image")));
            this.btnSearchJobSeeker.Location = new System.Drawing.Point(699, 27);
            this.btnSearchJobSeeker.Name = "btnSearchJobSeeker";
            this.btnSearchJobSeeker.Size = new System.Drawing.Size(52, 40);
            this.btnSearchJobSeeker.TabIndex = 25;
            this.btnSearchJobSeeker.UseVisualStyleBackColor = false;
            this.btnSearchJobSeeker.Click += new System.EventHandler(this.BtnSearchJobSeeker_Click);
            // 
            // txtCgpa2
            // 
            this.txtCgpa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCgpa2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCgpa2.ForeColor = System.Drawing.Color.Black;
            this.txtCgpa2.Location = new System.Drawing.Point(643, 34);
            this.txtCgpa2.Name = "txtCgpa2";
            this.txtCgpa2.Size = new System.Drawing.Size(50, 29);
            this.txtCgpa2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(250, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Board:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(428, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "CGPA Range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // txtSearchJobSeekerBoard
            // 
            this.txtSearchJobSeekerBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchJobSeekerBoard.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchJobSeekerBoard.ForeColor = System.Drawing.Color.Black;
            this.txtSearchJobSeekerBoard.Location = new System.Drawing.Point(254, 34);
            this.txtSearchJobSeekerBoard.Name = "txtSearchJobSeekerBoard";
            this.txtSearchJobSeekerBoard.Size = new System.Drawing.Size(164, 29);
            this.txtSearchJobSeekerBoard.TabIndex = 20;
            this.txtSearchJobSeekerBoard.TextChanged += new System.EventHandler(this.TxtSearchJobSeekerBoard_TextChanged);
            // 
            // txtSearchJobSeekerCGPA
            // 
            this.txtSearchJobSeekerCGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchJobSeekerCGPA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchJobSeekerCGPA.ForeColor = System.Drawing.Color.Black;
            this.txtSearchJobSeekerCGPA.Location = new System.Drawing.Point(585, 34);
            this.txtSearchJobSeekerCGPA.Name = "txtSearchJobSeekerCGPA";
            this.txtSearchJobSeekerCGPA.Size = new System.Drawing.Size(52, 29);
            this.txtSearchJobSeekerCGPA.TabIndex = 19;
            // 
            // txtSearchJobSeekerName
            // 
            this.txtSearchJobSeekerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchJobSeekerName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchJobSeekerName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchJobSeekerName.Location = new System.Drawing.Point(6, 34);
            this.txtSearchJobSeekerName.Name = "txtSearchJobSeekerName";
            this.txtSearchJobSeekerName.Size = new System.Drawing.Size(245, 29);
            this.txtSearchJobSeekerName.TabIndex = 18;
            this.txtSearchJobSeekerName.TextChanged += new System.EventHandler(this.TxtSearchJobSeekerName_TextChanged);
            // 
            // dgvJobSeekers
            // 
            this.dgvJobSeekers.AllowUserToAddRows = false;
            this.dgvJobSeekers.AllowUserToDeleteRows = false;
            this.dgvJobSeekers.AllowUserToOrderColumns = true;
            this.dgvJobSeekers.AllowUserToResizeRows = false;
            this.dgvJobSeekers.BackgroundColor = System.Drawing.Color.White;
            this.dgvJobSeekers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJobSeekers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobSeekers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvJobSeekers.ColumnHeadersHeight = 30;
            this.dgvJobSeekers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvJobSeekers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.pothopath});
            this.dgvJobSeekers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobSeekers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvJobSeekers.EnableHeadersVisualStyles = false;
            this.dgvJobSeekers.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvJobSeekers.Location = new System.Drawing.Point(3, 69);
            this.dgvJobSeekers.MultiSelect = false;
            this.dgvJobSeekers.Name = "dgvJobSeekers";
            this.dgvJobSeekers.ReadOnly = true;
            this.dgvJobSeekers.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvJobSeekers.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvJobSeekers.RowTemplate.DividerHeight = 1;
            this.dgvJobSeekers.RowTemplate.Height = 26;
            this.dgvJobSeekers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobSeekers.Size = new System.Drawing.Size(748, 230);
            this.dgvJobSeekers.TabIndex = 17;
            this.dgvJobSeekers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJobSeekers_CellDoubleClick);
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
            this.skill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skill.DataPropertyName = "skill";
            this.skill.HeaderText = "Skills";
            this.skill.Name = "skill";
            this.skill.ReadOnly = true;
            // 
            // workexperience
            // 
            this.workexperience.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workexperience.DataPropertyName = "workexperience";
            this.workexperience.HeaderText = "Experience";
            this.workexperience.Name = "workexperience";
            this.workexperience.ReadOnly = true;
            // 
            // pothopath
            // 
            this.pothopath.DataPropertyName = "photopath";
            this.pothopath.HeaderText = "Photo";
            this.pothopath.Name = "pothopath";
            this.pothopath.ReadOnly = true;
            this.pothopath.Visible = false;
            // 
            // pnlJob
            // 
            this.pnlJob.Controls.Add(this.label6);
            this.pnlJob.Controls.Add(this.label5);
            this.pnlJob.Controls.Add(this.label4);
            this.pnlJob.Controls.Add(this.txtSearchJobAddress);
            this.pnlJob.Controls.Add(this.txtSearchCategory);
            this.pnlJob.Controls.Add(this.dgvJob);
            this.pnlJob.Controls.Add(this.txtSearchJobtitle);
            this.pnlJob.Controls.Add(this.btnSearch);
            this.pnlJob.Location = new System.Drawing.Point(0, 3);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(754, 318);
            this.pnlJob.TabIndex = 26;
            this.pnlJob.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(465, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Area:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(235, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Title:";
            // 
            // txtSearchJobAddress
            // 
            this.txtSearchJobAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchJobAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchJobAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchJobAddress.Location = new System.Drawing.Point(468, 33);
            this.txtSearchJobAddress.Name = "txtSearchJobAddress";
            this.txtSearchJobAddress.Size = new System.Drawing.Size(225, 29);
            this.txtSearchJobAddress.TabIndex = 22;
            this.txtSearchJobAddress.TextChanged += new System.EventHandler(this.TxtSearchJobAddress_TextChanged);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.Location = new System.Drawing.Point(238, 33);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(224, 29);
            this.txtSearchCategory.TabIndex = 21;
            this.txtSearchCategory.TextChanged += new System.EventHandler(this.TxtSearchCategory_TextChanged);
            // 
            // dgvJob
            // 
            this.dgvJob.AllowUserToAddRows = false;
            this.dgvJob.AllowUserToDeleteRows = false;
            this.dgvJob.AllowUserToOrderColumns = true;
            this.dgvJob.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvJob.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvJob.BackgroundColor = System.Drawing.Color.White;
            this.dgvJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJob.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jid,
            this.title,
            this.type,
            this.category,
            this.description,
            this.vacancy,
            this.deadline,
            this.jaddress,
            this.salary,
            this.companyid});
            this.dgvJob.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJob.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvJob.EnableHeadersVisualStyles = false;
            this.dgvJob.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvJob.Location = new System.Drawing.Point(8, 72);
            this.dgvJob.Name = "dgvJob";
            this.dgvJob.ReadOnly = true;
            this.dgvJob.RowHeadersVisible = false;
            this.dgvJob.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvJob.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvJob.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.dgvJob.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvJob.RowTemplate.DividerHeight = 1;
            this.dgvJob.RowTemplate.Height = 26;
            this.dgvJob.RowTemplate.ReadOnly = true;
            this.dgvJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJob.Size = new System.Drawing.Size(743, 243);
            this.dgvJob.TabIndex = 20;
            this.dgvJob.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJob_CellDoubleClick);
            // 
            // jid
            // 
            this.jid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jid.DataPropertyName = "id";
            this.jid.HeaderText = "Job ID";
            this.jid.Name = "jid";
            this.jid.ReadOnly = true;
            this.jid.Visible = false;
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
            // 
            // deadline
            // 
            this.deadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deadline.DataPropertyName = "deadline";
            this.deadline.HeaderText = "Deadline";
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            // 
            // jaddress
            // 
            this.jaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jaddress.DataPropertyName = "address";
            this.jaddress.HeaderText = "Address";
            this.jaddress.Name = "jaddress";
            this.jaddress.ReadOnly = true;
            this.jaddress.Visible = false;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
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
            // txtSearchJobtitle
            // 
            this.txtSearchJobtitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchJobtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchJobtitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchJobtitle.Location = new System.Drawing.Point(8, 33);
            this.txtSearchJobtitle.Name = "txtSearchJobtitle";
            this.txtSearchJobtitle.Size = new System.Drawing.Size(224, 29);
            this.txtSearchJobtitle.TabIndex = 19;
            this.txtSearchJobtitle.TextChanged += new System.EventHandler(this.TxtSearchJobtitle_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(699, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 37);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Search Job";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.pnlSearch.ResumeLayout(false);
            this.pnlJobSeeker.ResumeLayout(false);
            this.pnlJobSeeker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSeekers)).EndInit();
            this.pnlJob.ResumeLayout(false);
            this.pnlJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.Panel pnlJobSeeker;
        private System.Windows.Forms.Button btnSearchJobSeeker;
        private System.Windows.Forms.TextBox txtCgpa2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchJobSeekerBoard;
        private System.Windows.Forms.TextBox txtSearchJobSeekerCGPA;
        private System.Windows.Forms.TextBox txtSearchJobSeekerName;
        private System.Windows.Forms.DataGridView dgvJobSeekers;
        private System.Windows.Forms.TextBox txtSearchJobAddress;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.DataGridView dgvJob;
        private System.Windows.Forms.TextBox txtSearchJobtitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn jid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancy;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn jaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyid;
        private System.Windows.Forms.Button btnBack;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}