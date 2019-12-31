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
    public partial class CompanyForm : MetroForm
    {
        private Delegates.BackToHome BackHome { set; get; }
        private DataSet Ds { set; get; }
        private string Id { set; get; }
        private string Name { set; get; }
        private string Address { set; get; }
        private string ContactNo { set; get; }
        private string Email { set; get; }
        private string LogoPath { set; get; }
        

        public CompanyForm(Delegates.BackToHome backHome, DataSet ds)
        {
            InitializeComponent();
            this.BackHome = backHome;
            this.Ds = ds;
            SetAll();
            string sql = JobRepo.GetAllJobOfCompany(this.Id);
            this.PopulateDGVPostedJobs(sql);
        }
        public CompanyForm(Delegates.BackToHome backHome, DataGridViewRow row)
        {
            InitializeComponent();
            this.BackHome = backHome;
            SetAll(row);
            this.pnlCumpanySecureButton.Visible = false;
        }
        private void SetAll()
        {
            this.Id = this.lblId.Text = this.Ds.Tables[0].Rows[0]["id"].ToString();
            this.Name = this.lblName.Text = this.Ds.Tables[0].Rows[0]["name"].ToString();
            this.Address = this.lblAddress.Text = this.Ds.Tables[0].Rows[0]["address"].ToString();
            this.ContactNo = this.lblContact.Text = this.Ds.Tables[0].Rows[0]["contactno"].ToString();
            this.Email = this.lblEamil.Text = this.Ds.Tables[0].Rows[0]["email"].ToString();
            this.LogoPath = this.Ds.Tables[0].Rows[0]["logopath"].ToString();
            this.pbCompanyPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                this.pbCompanyPhoto.Image = System.Drawing.Image.FromFile(this.LogoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Text = this.Name;

        }
        private void SetAll(DataGridViewRow row)
        {
            int i = 0;
            this.Id = this.lblId.Text = row.Cells[i++].Value.ToString();
            i++;
            this.Name = this.lblName.Text = row.Cells[i++].Value.ToString();
            this.Address = this.lblAddress.Text = row.Cells[i++].Value.ToString();
            this.Email = this.lblEamil.Text = row.Cells[i++].Value.ToString();
            this.ContactNo = this.lblContact.Text = row.Cells[i++].Value.ToString();
            this.LogoPath = row.Cells[i++].Value.ToString();
            this.pbCompanyPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                this.pbCompanyPhoto.Image = System.Drawing.Image.FromFile(this.LogoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Text = this.Name;
        }

        private void CompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.BackHome();
                this.Dispose();
            }
            catch
            {

            }
        }

        private void BtnClosePostedJobs_Click(object sender, EventArgs e)
        {
            this.pnlViewPostedJobs.Visible = false;
        }

        private void BtnPostJobCirculer_Click(object sender, EventArgs e)
        {
            Delegates.BackToCompany backHere = this.BackHere;
            new JobCircularForm(BackHere, this.Id).Visible = true;
            this.Visible = false;
        }

        private void BackHere()
        {

            string sql = JobRepo.GetAllJobOfCompany(this.Id);
            this.PopulateDGVPostedJobs(sql);
            this.Visible = true;
        }

        private void BtnViewPostedJobs_Click(object sender, EventArgs e)
        {
            this.pnlViewPostedJobs.Visible = true;
        }

        private void PopulateDGVPostedJobs(string sql)
        {
            try
            {
                DataSet ds = DataAccess.ExecuteQuery(sql);
                this.dgvPostedJobs.AutoGenerateColumns = true;
                this.dgvPostedJobs.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearchPostedJobs_TextChanged(object sender, EventArgs e)
        {
            string sql = JobRepo.SearchByTitle(this.Id,this.txtSearchPostedJobs.Text);
            this.PopulateDGVPostedJobs(sql);
        }

        private void DgvPostedJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Delegates.BackToCompany back = this.BackHere;
            DataGridViewRow row = this.dgvPostedJobs.CurrentRow;
            new JobForm(row, back).Visible = true;
            this.Visible = false;
        }

        private void BtnSearchJobSeekers_Click(object sender, EventArgs e)
        {
            Delegates.BackToCompany back = this.BackHere;
            new SearchForm(back).Visible = true;
            this.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Delegates.BackToCompany back = this.BackHere;
            Delegates.DestroyCompany destroy = this.Destroyform;
            new SignupForm(back,destroy,this.BackHome, this.Ds).Visible = true;
            this.Visible = false;
        }
        private void Destroyform()
        {
            this.Dispose();
        }
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are sure to delete this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    JobRepo.DeleteFromJobSeekerJob(this.Id);
                    
                    JobRepo.DeleteJob(this.Id);
                    
                    CompanyRepo.DeleteCompany(this.Id);
                    
                    MessageBox.Show("Company profile deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.BackHome();
                this.Dispose();
            }
            else
            {
                return;
            }
        }
    }
}
