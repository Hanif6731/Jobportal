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
    public partial class SigninForm : MetroForm
    {
        private string Id { set; get; }
        private string Password { set; get; }
        public DataSet Ds { set; get; }
        private string User { set; get; }
        private Delegates.BackToHome BackHome { set; get; }
        public SigninForm(Delegates.BackToHome backHome)
        {
            InitializeComponent();
            this.BackHome = backHome;
        }

        private void LblCreateAccount_Click(object sender, EventArgs e)
        {
            new SignupForm(this.BackHome).Visible = true;
            this.Dispose();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            this.Id = this.txtUserId.Text;
            this.Password = this.txtPassword.Text;
            if (Validation.Text(this.Id, this.Password))
            {
                if (this.ValidateLogin())
                {
                    
                    GoNext();
                    this.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Input User Id and Password, please!", "Warning!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }



        private bool ValidateLogin()
        {

            string sql;

            try
            {
                if (this.Id.StartsWith("C-"))
                {
                    this.User = "Company";
                    sql = CompanyRepo.CompanySignIn(this.Id, this.Password);
                }
                else if (this.Id.StartsWith("JS-")) 
                {
                    this.User = "JobSeeker";
                    sql = JobSeekerRepo.JobSeekerSignIn(this.Id,this.Password);
                }
                else
                {
                    MessageBox.Show("User Id is incorrect.\nTry Again.", "Not Found!!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    return false;
                }
                this.Ds = DataAccess.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.Ds.Tables[0].Rows.Count==1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("User Doesn't Exists", "Not Found!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return false;
            }
        }
        private void GoNext()
        {
            if (this.User == "Company")
            {
                new CompanyForm(this.BackHome, this.Ds).Visible = true;
            }
            else if (this.User == "JobSeeker")
            {
                new JobSeekerForm(this.BackHome,this.Ds).Visible = true;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackHome();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SigninForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
