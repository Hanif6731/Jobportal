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
    public partial class HomeForm : MetroForm
    {
        
        public HomeForm()
        {
            InitializeComponent();
            this.BackHere();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Delegates.BackToHome backToHome = this.BackHere;
            new SignupForm(backToHome).Visible = true;
            this.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Delegates.BackToHome backToHome = this.BackHere;
            new SearchForm(backToHome).Visible = true;
            this.Visible = false;
            
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Delegates.BackToHome backToHome = this.BackHere;
            new SigninForm(backToHome).Visible = true;
            this.Visible = false;
        }



        public void PopulateDGVNewJobs(string sql )
        {
            try
            {
                DataSet ds = DataAccess.ExecuteQuery(sql);
                this.dgvNewJobs.AutoGenerateColumns = true;
                this.dgvNewJobs.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PopulateDGVDeadlineToday(string sql)
        {
            try
            {
                DataSet ds = DataAccess.ExecuteQuery(sql);
                this.dgvJobDeadlineToday.AutoGenerateColumns = true;
                this.dgvJobDeadlineToday.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void PopulateDGVFeatueredCompany(string sql = @"select * from company order by id;")
        {
            try
            {
                DataSet ds = DataAccess.ExecuteQuery(sql);
                this.dgvFeaturedCompany.AutoGenerateColumns = true;
                this.dgvFeaturedCompany.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BackHere()
        {
            this.PopulateDGVFeatueredCompany();
            string sql = JobRepo.GetDeadlineTodayJobs();
            this.PopulateDGVDeadlineToday(sql);
            sql = JobRepo.GetNewJobs();
            this.PopulateDGVNewJobs(sql);
            this.Visible = true;
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DgvNewJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Delegates.BackToHome back = this.BackHere;
            DataGridViewRow row = this.dgvNewJobs.CurrentRow;
            new JobForm(back, row).Visible = true;
            this.Visible = false;
        }

        private void DgvFeaturedCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Delegates.BackToHome back = this.BackHere;
            DataGridViewRow row = this.dgvFeaturedCompany.CurrentRow;
            new CompanyForm(back, row).Visible = true;
            this.Visible = false;

        }

        private void DgvJobDeadlineToday_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Delegates.BackToHome back = this.BackHere;
            DataGridViewRow row = this.dgvJobDeadlineToday.CurrentRow;
            new JobForm(back, row).Visible = true;
            this.Visible = false;
        }
    }
}
