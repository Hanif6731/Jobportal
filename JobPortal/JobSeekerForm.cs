using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace JobPortal
{
    public partial class JobSeekerForm : MetroForm
    {
        private string BackPage { set; get; }
        private DataGridViewRow Row { set; get; }
        internal Delegates.BackToHome BackHome { set; get; }
        private Delegates.BackToJobForm BackToJob { set; get; }
        private Delegates.BackToCompany BackToCompany { set; get; }
        private DataSet Ds { set; get; }
        internal  string Id { set; get; }
        internal  string Password { set; get; }
        internal  string Name { set; get; }
        internal  string Address { set; get; }
        internal  string ContactNo { set; get; }
        internal  string Email { set; get; }
        internal  string Gender { set; get; }
        internal  string DateOfBirth { set; get; }
        internal  string BloodGroup { set; get; }
        internal  string Experience { set; get; }
        internal  string PhotoPath { set; get; }
        internal string Skill { set; get; }
        
        public JobSeekerForm(Delegates.BackToHome backHome,DataSet ds)
        {
            InitializeComponent();
            this.Ds = ds;
            this.BackHome = backHome;
            this.SetAll();
            this.btnEditEducation.Visible = true;
            this.btnDeleteEducation.Visible = true;
            this.BackPage = "Home";
            
            
        }
        public JobSeekerForm(Delegates.BackToJobForm backToJob, DataGridViewRow row)
        {
            InitializeComponent();
            this.BackToJob = backToJob;
            this.SetAll(row);
            this.pnlLogout.Visible = false;
            this.BackPage = "Job";
            


        }
        public JobSeekerForm(Delegates.BackToCompany back, DataGridViewRow row)
        {
            InitializeComponent();
            this.BackToCompany = back;
            this.SetAll(row);
            this.pnlLogout.Visible = false;
            this.BackPage = "Company";
            this.Text = "Curriculum Vitae";


        }
        private void SetAll()
        {

            this.Id=this.lblOutputId.Text = this.Ds.Tables[0].Rows[0]["id"].ToString();
            this.Password = this.Ds.Tables[0].Rows[0]["password"].ToString();
            this.Name = this.lblOutputName.Text = this.Ds.Tables[0].Rows[0]["name"].ToString();
            this.Address = this.lblOutputAddress.Text = this.Ds.Tables[0].Rows[0]["address"].ToString();
            this.ContactNo = this.lblOutputContactNo.Text = this.Ds.Tables[0].Rows[0]["contactno"].ToString();
            this.Email = this.lblOutputEmail.Text = this.Ds.Tables[0].Rows[0]["email"].ToString();
            this.Gender = this.lblOutputGender.Text = this.Ds.Tables[0].Rows[0]["gender"].ToString();
            string[] datefbabirth = this.Ds.Tables[0].Rows[0]["dateofbirth"].ToString().Split(' ');
            this.DateOfBirth = this.lblOutputDateOfBirth.Text = datefbabirth[0] ;

            this.BloodGroup = this.lblOutputBloodGroup.Text = this.Ds.Tables[0].Rows[0]["bloodgroup"].ToString();
            this.Skill = this.lblOutputSkill.Text = this.Ds.Tables[0].Rows[0]["skill"].ToString();
            this.Experience = this.lblOutputWorkExperience.Text = this.Ds.Tables[0].Rows[0]["workexperience"].ToString()+" Years";
            this.PhotoPath = this.Ds.Tables[0].Rows[0]["photopath"].ToString();
            this.pbJobSeekerPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                this.pbJobSeekerPhoto.Image = System.Drawing.Image.FromFile(this.PhotoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.PopulateDataGridView();
            this.Text = this.Name;
        }
        private void SetAll(DataGridViewRow row)
        {
            int i = 0;
            this.Id = this.lblOutputId.Text = row.Cells[i++].Value.ToString();
            this.Password= row.Cells[i++].Value.ToString();
            this.Name = this.lblOutputName.Text = row.Cells[i++].Value.ToString();
            this.Address = this.lblOutputAddress.Text = row.Cells[i++].Value.ToString();
            this.ContactNo = this.lblOutputContactNo.Text = row.Cells[i++].Value.ToString();
            this.Email = this.lblOutputEmail.Text = row.Cells[i++].Value.ToString();
            this.Gender = this.lblOutputGender.Text = row.Cells[i++].Value.ToString();
            string[] datefbabirth = row.Cells[i++].Value.ToString().Split(' ');
            this.DateOfBirth = this.lblOutputDateOfBirth.Text = datefbabirth[0];
            this.BloodGroup = this.lblOutputBloodGroup.Text = row.Cells[i++].Value.ToString();
            this.Skill = this.lblOutputSkill.Text = row.Cells[i++].Value.ToString();
            this.Experience = this.lblOutputWorkExperience.Text = row.Cells[i++].Value.ToString() + " Years";
            this.PhotoPath = row.Cells[i].Value.ToString();
            this.pbJobSeekerPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                this.pbJobSeekerPhoto.Image = System.Drawing.Image.FromFile(this.PhotoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.PopulateDataGridView();
            this.Text = this.Name;
        }

        private void BtnViewEducationalBackGround_Click(object sender, EventArgs e)
        {
            this.pnlDegree.Visible = true;
        }

        private void BtnCloseDegree_Click(object sender, EventArgs e)
        {
            this.pnlEducationalBacground.Visible = false;
            this.pnlDegree.Visible = false;
        }

        private void BtnColseEducationalbackground_Click(object sender, EventArgs e)
        {
            this.pnlEducationalBacground.Visible = false;
            this.pnlDegree.Visible = true;
        }

        private void JobSeekerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (this.BackPage == "Job")
            {
                this.BackToJob();
                
            }
            else if (this.BackPage == "Company")
            {
                this.BackToCompany();

            }
            else
            {
                this.BackHome();
            }
            this.Dispose();
        }
        private void PopulateDGVDegree(String sql)
        {
            try
            {
                DataSet ds = DataAccess.ExecuteQuery(sql);
                this.dgvJobSeekerDegree.AutoGenerateColumns = true;
                this.dgvJobSeekerDegree.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void PopulateDataGridView()
        {
            string sql = EducationalQualificationRepo.GetAll(this.Id);
            this.PopulateDGVDegree(sql);
        }
        private void BtnSearchJob_Click(object sender, EventArgs e)
        {
            Delegates.BackToJobSeekerForm back = this.BackHere;
            new SearchForm(back, this.Id).Visible = true;
            this.Visible = false;

        }
        internal void BackHere()
        {
            this.Visible = true;
            this.PopulateDataGridView();
        }
        private void Destroy()
        {
            this.Dispose();
        }

        private void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            Delegates.BackToJobSeekerForm back = this.BackHere;
            Delegates.DestroyJobSeeker destroy = this.Destroy;
            new SignupForm(back,destroy,this.BackHome,this.Ds).Visible = true;
            this.Visible = false;
            
        }

        

        private void DgvJobSeekerDegree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            this.Row = this.dgvJobSeekerDegree.CurrentRow;
            this.lblDegree.Text = this.Row.Cells[i++].Value.ToString();
            this.lblMajor.Text = this.Row.Cells[i++].Value.ToString();
            this.lblPassingYear.Text = this.Row.Cells[i++].Value.ToString();
            string[] date = lblPassingYear.Text.Split(' ');
            string[] year = date[0].Split('/');
            this.lblPassingYear.Text = year[2];
            this.lblInstitute.Text = this.Row.Cells[i++].Value.ToString();
            this.lblcgpa.Text= this.Row.Cells[i++].Value.ToString();
            this.lblBoard.Text = this.Row.Cells[i++].Value.ToString();
            this.pnlEducationalBacground.Visible = true;
        }

        private void BtnEditEducation_Click(object sender, EventArgs e)
        {
            Delegates.BackToJobSeekerForm back = this.BackHere;
            new EducatinalQualificationForm(back, this.Row).Visible=true;
            this.pnlEducationalBacground.Visible = false;
            this.Visible = false;
        }

        private void BtnDeleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are sure to delete this Profile?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    JobSeekerRepo.DeleteJobseekerjob(this.Id);
                    EducationalQualificationRepo.DeleteEducationInfo(this.Id);
                    JobSeekerRepo.DeleteJobSeeker(this.Id);
                    MessageBox.Show("Profile deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.BackHome();
                this.Dispose();
            }
            else
            {
                return;
            }
        }

        private void BtnDeleteEducation_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are sure to delete this Education history?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    

                    
                    EducationalQualificationRepo.DeleteEducationInfo(this.Id, this.lblDegree.Text);
                    MessageBox.Show("Education info deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.pnlEducationalBacground.Visible = false;
                this.PopulateDataGridView();
            }
            else
            {
                return;
            }
        }
    }
}
