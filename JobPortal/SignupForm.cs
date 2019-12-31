using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;

namespace JobPortal
{
    public partial class SignupForm : MetroForm
    {
        private string Purpose { set; get; }
        private DataSet Ds { set; get; }
        private Delegates.BackToCompany backToCompany { set; get; }
        private int CompanySerial { set; get; }
        private int JobSeekerSerial { set; get; }
        internal string JobSeekerId { set; get; }
        private string CompanyId { set; get; }
        private string Name { set; get; }
        private string Password { set; get; }
        private string Address { set; get; }
        private string Email { set; get; }
        private string ContactNo { set; get; }
        private string CompanyLogoPath { set; get; }
        private string JobSeekerPhotoPath { set; get; }
        private bool JobSeekerPhotoSelected { set; get; }
        private bool CompanyLogoSelected { set; get; }
        private string Gender { set; get; }
        private string DateOfBirth { set; get; }
        private string Skills { set; get; }
        private string BloodGroup { set; get; }
        private int Experience { set; get; }
        private Delegates.BackToHome Back { set; get; }
        private Delegates.DestroyCompany DestroyCompany { set; get; }
        private Delegates.BackToJobSeekerForm BackToJobSeeker { set; get; }
        private Delegates.DestroyJobSeeker DestroyJobSeeker { set; get; }
        private string BackForm { set; get; }

        public SignupForm(Delegates.BackToHome back)
        {
            InitializeComponent();
            this.Back = back;
            this.CompanySerial = DataAccess.CompanySerial();
            this.JobSeekerSerial = DataAccess.JobSeekerSerial();
            this.JobSeekerId = "JS-" + this.JobSeekerSerial.ToString("D4");
            this.CompanyId = "C-" + this.CompanySerial.ToString("D4");
            this.CompanyLogoPath = "-";
            this.JobSeekerPhotoPath = "-";
            this.cmbCompanyOrJobSeeker.SelectedIndex = 1;
            this.JobSeekerPhotoSelected = this.CompanyLogoSelected = false;
            this.BackForm = "Home";
            
        }

        public SignupForm(Delegates.BackToJobSeekerForm back, Delegates.DestroyJobSeeker destroy,Delegates.BackToHome backToHome, DataSet ds)
        {
            InitializeComponent();
            this.pnlCompany.Visible = false;
            this.Back = backToHome;
            this.DestroyJobSeeker = destroy;
            this.BackToJobSeeker = back;
            this.Ds = ds;
            this.pnlCompanyOrJobSeeker.Visible = false;
            this.SetJobseeker();
            this.Text = "Update Account";
        }
        public SignupForm(Delegates.BackToCompany back,Delegates.DestroyCompany destroy,Delegates.BackToHome backHome, DataSet ds)
        {
            InitializeComponent();
            this.pnlCompanyOrJobSeeker.Visible = false;
            this.pnlCompany.Visible = true;
            this.pnlJobSeeker.Visible = false;
            this.backToCompany = back;
            this.DestroyCompany = destroy;
            this.Back = backHome;
            this.Purpose = "update";
            this.Ds = ds;
            this.setCompany();
            this.Text = "Update Account";
        }

        private void SetJobseeker()
        {
            
            
            

            this.JobSeekerId = this.Ds.Tables[0].Rows[0]["id"].ToString();
            this.Name = this.txtJobSeekerName.Text = this.Ds.Tables[0].Rows[0]["name"].ToString();
            this.Password = this.txtJobSeekerPassword.Text = this.Ds.Tables[0].Rows[0]["password"].ToString();
            this.Address = this.txtJobSeekerAddress.Text = this.Ds.Tables[0].Rows[0]["address"].ToString();
            this.ContactNo = this.txtJobSeekerContactNo.Text = this.Ds.Tables[0].Rows[0]["contactno"].ToString();
            this.Email = this.txtJobSeekerEmail.Text = this.Ds.Tables[0].Rows[0]["email"].ToString();
            if (this.Ds.Tables[0].Rows[0]["gender"].ToString() == "Female")
            {
                this.Gender = this.rbFemale.Text;
                this.rbFemale.Checked = true;
            }
            else if (this.Ds.Tables[0].Rows[0]["gender"].ToString() == "Male")
            {
                this.Gender = this.rbMale.Text;
                this.rbMale.Checked = true;
            }
            else { this.Gender = null; }
            string[] datefbabirth = this.Ds.Tables[0].Rows[0]["dateofbirth"].ToString().Split(' ');
            this.DateOfBirth = this.dtJobSeekerDateOfBirth.Text = datefbabirth[0];
            this.Skills = this.txtJobSeekerSkills.Text = this.Ds.Tables[0].Rows[0]["skill"].ToString();
            this.BloodGroup = this.cmbBloodGroup.Text = this.Ds.Tables[0].Rows[0]["bloodgroup"].ToString();
            this.txtJobSeekerExperience.Text = this.Ds.Tables[0].Rows[0]["workexperience"].ToString();
            this.JobSeekerPhotoPath = this.Ds.Tables[0].Rows[0]["photopath"].ToString();
            this.pbJobSeekerPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                this.pbJobSeekerPhoto.Image = System.Drawing.Image.FromFile(this.JobSeekerPhotoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.JobSeekerPhotoSelected = true;
            this.pnlAddEducationalBackGround.Visible = true;
            this.btnBack.Visible = false;
        }
        private void setCompany()
        {
            this.CompanyId = this.Ds.Tables[0].Rows[0]["id"].ToString();
            this.Password =this.txtCompanyPassword.Text= this.Ds.Tables[0].Rows[0]["password"].ToString();
            this.Name = this.txtCompanyName.Text = this.Ds.Tables[0].Rows[0]["name"].ToString();
            this.Address = this.txtCompanyAddress.Text = this.Ds.Tables[0].Rows[0]["address"].ToString();
            this.ContactNo = this.txtCompanyContact.Text = this.Ds.Tables[0].Rows[0]["contactno"].ToString();
            this.Email = this.txtCompanyEmail.Text = this.Ds.Tables[0].Rows[0]["email"].ToString();
            this.CompanyLogoPath = this.Ds.Tables[0].Rows[0]["logopath"].ToString();
            this.pbCompanyLogo.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                this.pbCompanyLogo.Image = System.Drawing.Image.FromFile(this.CompanyLogoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.CompanyLogoSelected = true;
            this.btnBack.Visible = false;
        }

        private void BtnSaveJobSeekerProfile_Click(object sender, EventArgs e)
        {
            this.Name = this.txtJobSeekerName.Text;
            this.Password = this.txtJobSeekerPassword.Text;
            this.Address = this.txtJobSeekerAddress.Text;
            this.ContactNo = this.txtJobSeekerContactNo.Text;
            this.Email = this.txtJobSeekerEmail.Text;
            if (rbFemale.Checked == true) { this.Gender = this.rbFemale.Text; }
            else if (rbMale.Checked == true) { this.Gender = this.rbMale.Text; }
            else { this.Gender = null; }
            this.DateOfBirth = this.dtJobSeekerDateOfBirth.Text;
            this.Skills = this.txtJobSeekerSkills.Text;
            this.BloodGroup = this.cmbBloodGroup.Text;
            if (this.txtJobSeekerExperience.Text == "") { this.Experience = 0; }
            else { this.Experience = Convert.ToInt32(this.txtJobSeekerExperience.Text); }

            if (this.JobSeekerPhotoSelected)
            {
                if (Validation.Text(this.Name, this.Password, this.Address, this.ContactNo, this.Email, this.Gender, this.DateOfBirth.ToString(), this.BloodGroup, this.Skills))
                {
                    if (Validation.ValidEmail(this.Email) && Validation.IsNumber(this.ContactNo))
                    {
                        string sql;
                        if (this.JobSeekerSerial != 0)
                        {
                            try
                            {
                                JobSeekerRepo.InsertJobseeker(this.JobSeekerId, this.Password, this.Name, this.Address, this.ContactNo, this.Email, this.Gender, this.DateOfBirth, this.BloodGroup, this.Skills, this.Experience.ToString(), this.JobSeekerPhotoPath);
                                MessageBox.Show("Account Created SuccessFully!\nYour ID is " + this.JobSeekerId, "Message!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                DataAccess.UpdateJobSeekerSerial();
                                this.pnlAddEducationalBackGround.Visible = true;
                                this.Back();
                                this.Dispose();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {
                                
                                JobSeekerRepo.UpdateJobseeker(this.Password ,this.Name,this.Address, this.ContactNo ,this.Email,this.Gender,this.DateOfBirth,this.BloodGroup ,this.Skills , this.Experience.ToString() , this.JobSeekerPhotoPath,this.JobSeekerId);
                                MessageBox.Show("Profile Updated, You need to sign in again!","Info!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {

                                new SigninForm(this.Back).Visible = true;
                                this.DestroyJobSeeker();
                                this.Dispose();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email or Contact number is not in valid format", "'Format Issue!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("All the boxes are required to fillup.", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please upload a Profile photo", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAddEducation_Click(object sender, EventArgs e)
        {
            new EducatinalQualificationForm(this).Visible = true;
        }

        private void CmbCompanyOrJobSeeker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCompanyOrJobSeeker.SelectedIndex == 0)
            {
                this.pnlJobSeeker.Visible = false;
                this.pnlCompany.Visible = true;

            }
            else if (this.cmbCompanyOrJobSeeker.SelectedIndex== 1)
            {
                this.pnlCompany.Visible = false;
                this.pnlJobSeeker.Visible = true;

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Back();
            this.Dispose();
        }

        private void PbJobSeekerPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "All (*.jpg, *.png, *.bmp)|*.*|jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
                {

                    this.JobSeekerPhotoSelected = true;
                    this.pbJobSeekerPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pbJobSeekerPhoto.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    this.JobSeekerPhotoPath = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PbCompanyLogo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "All (*.jpg, *.png, *.bmp)|*.*|jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
                {
                    this.CompanyLogoSelected = true;
                    this.pbCompanyLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pbCompanyLogo.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    this.CompanyLogoPath = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSaveCompanyProfile_Click(object sender, EventArgs e)
        {
            this.Name = this.txtCompanyName.Text;
            this.Password = this.txtCompanyPassword.Text;
            this.Address = this.txtCompanyAddress.Text;
            this.ContactNo = this.txtCompanyContact.Text;
            this.Email = this.txtCompanyEmail.Text;
            if (this.CompanyLogoSelected)
            {
                if (Validation.Text(this.Name, this.Password, this.Address, this.ContactNo, this.Email))
                {
                    if (Validation.ValidEmail(this.Email) && Validation.IsNumber(this.ContactNo))
                    {
                        string sql;
                        try
                        {
                            if (this.Purpose != "update")
                            {
                                
                                CompanyRepo.InsertCompany(this.CompanyId, this.Password, this.Name, this.Address,this.Email, this.ContactNo, this.CompanyLogoPath);
                                MessageBox.Show("Account Creadted SuccessFully!\nYour Company ID is " + this.CompanyId, "Message!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                DataAccess.UpdateCompanySerial();
                            }
                            else
                            {
                                
                                CompanyRepo.UpdateCompany(this.Password, this.Name, this.Address, this.Email, this.ContactNo, this.CompanyLogoPath, this.CompanyId);
                                MessageBox.Show("Account Updated", "Info!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                new SigninForm(this.Back).Visible = true;
                                this.DestroyCompany();
                                this.Dispose();


                            }
                            this.Back();
                            this.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email or Contact number is not in valid format", "'Format Issue!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("All the boxes are required to fillup.", "Message!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation );
                }
            }
            else
            {
                MessageBox.Show("Please upload a company logo", "Message!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancelJobSeeker_Click(object sender, EventArgs e)
        {
            if (this.BackForm == "Home")
            {
                this.Back();
            }
            else
            {
                this.BackToJobSeeker();
            }
            this.Dispose();
        }

        private void BtnCancelCompany_Click(object sender, EventArgs e)
        {
            if (this.BackForm == "Home")
            {
                this.Back();
            }
            else
            {
                this.backToCompany();
            }
            this.Dispose();
        }
    }
}
