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
    public partial class SearchForm : MetroForm
    {
        private Delegates.BackToJobSeekerForm BackToJobSeeker { set; get; }
        private Delegates.BackToHome BacktoHome { set; get; }
        private Delegates.BackToCompany BackToCompany { set; get; }
        private double Cgpa1 { set; get; }
        private double Cgpa2 { set; get; }
        private string Max { set; get; }
        private string Min { set; get; }
        internal string CurrentUser { set; get; }
        private string Sql { set; get; }
        
        private DataSet Ds { set; get; }
        private string JobseekerId { set; get; }
        public SearchForm(Delegates.BackToHome backtoHome)
        {
            InitializeComponent();
            this.BacktoHome = backtoHome;
            this.CurrentUser = "Guest";
            this.pnlJob.Visible = true;
            this.PopulateDefaultDGV();


        }
        private void PopulateDefaultDGV()
        {
            string sql =JobRepo.GetNewJobs();
            this.PopulateDGVJob(sql);
            this.PopulateDGVJobSeekers();
            
        }
        public SearchForm(Delegates.BackToJobSeekerForm backtoJobSeeker,string id)
        {
            InitializeComponent();
            this.BackToJobSeeker = backtoJobSeeker;
            this.CurrentUser = "JobSeeker";
            this.JobseekerId = id;
            this.pnlJob.Visible = true;
            this.PopulateDefaultDGV();
            
        }
        public SearchForm(Delegates.BackToCompany backToCompany)
        {
            InitializeComponent();
            this.BackToCompany = backToCompany;
            this.CurrentUser = "Company";
            this.pnlJobSeeker.Visible = true;
            this.PopulateDefaultDGV();
            this.Text = "Search Peoples";

        }

        private void TxtSearchJobtitle_TextChanged(object sender, EventArgs e)
        {
            this.Sql = JobRepo.SearchByTitle(this.txtSearchJobtitle.Text);
            this.PopulateDGVJob(this.Sql);
        }

        private void TxtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            this.Sql = JobRepo.SearchByCategory(this.txtSearchCategory.Text);
            this.PopulateDGVJob(this.Sql);
        }

        private void TxtSearchJobAddress_TextChanged(object sender, EventArgs e)
        {
            this.Sql = JobRepo.SearchByAddress(this.txtSearchJobAddress.Text);
            this.PopulateDGVJob(this.Sql);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Sql = JobRepo.SearchSpecificJob(this.txtSearchCategory.Text, this.txtSearchJobAddress.Text, this.txtSearchJobtitle.Text);
            this.PopulateDGVJob(this.Sql);
        }
        private void PopulateDGVJob(string sql)
        {
            try
            {
                DataSet ds = DataAccess.ExecuteQuery(sql);
                this.dgvJob.AutoGenerateColumns = true;
                this.dgvJob.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateDGVJobSeekers(string sql = "select * from jobseeker")
        {
            try
            {
                DataSet ds = DataAccess.ExecuteQuery(sql);
                this.dgvJobSeekers.AutoGenerateColumns = true;
                this.dgvJobSeekers.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvJob_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Delegates.BackToSearch back = this.BackHere;
            DataGridViewRow row = this.dgvJob.CurrentRow;
            if(this.CurrentUser=="Guest")
                new JobForm(back, row).Visible = true;
            else if(this.CurrentUser=="JobSeeker")
                new JobForm(back, row,this.JobseekerId).Visible = true;
            this.Visible = false;
        }
        private void BackHere()
        {
            this.Visible = true;
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (this.CurrentUser == "Guest")
            {
                this.BacktoHome();
                
            }
            else if (this.CurrentUser == "JobSeeker")
            {
                this.BackToJobSeeker();
            }
            else
            {
                this.BackToCompany();
            }
            this.Dispose();
        }

        private void TxtSearchJobSeekerName_TextChanged(object sender, EventArgs e)
        {
            string sql = JobSeekerRepo.SearchJobSeekerByName(this.txtSearchJobSeekerName.Text);
            this.PopulateDGVJobSeekers(sql);
        }

        private void TxtSearchJobSeekerBoard_TextChanged(object sender, EventArgs e)
        {
            string sql = JobSeekerRepo.SearchJobSeekerByBoard(this.txtSearchJobSeekerBoard.Text);
            this.PopulateDGVJobSeekers(sql);
        }

        private void DgvJobSeekers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvJobSeekers.CurrentRow;
            new JobSeekerForm(this.BackToCompany, row).Visible = true;
            this.Dispose();
        }

        private void BtnSearchJobSeeker_Click(object sender, EventArgs e)
        {
            if (Validation.IsDouble(this.txtSearchJobSeekerCGPA.Text, this.txtCgpa2.Text))
            {
                this.Cgpa1 = Convert.ToDouble(this.txtSearchJobSeekerCGPA.Text);
                this.Cgpa2 = Convert.ToDouble(this.txtCgpa2.Text);
                
            }
            this.Max = Math.Max(this.Cgpa1, this.Cgpa2).ToString();
            this.Min = Math.Min(this.Cgpa1, this.Cgpa2).ToString();

            string sql = JobSeekerRepo.SearchJobSeeker(this.txtSearchJobSeekerName.Text, this.txtSearchJobSeekerBoard.Text, this.Min, this.Max);
            this.PopulateDGVJobSeekers(sql);
        }
    }
}
