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
    public partial class JobForm : MetroForm
    {
        private string BackForm { set; get; }
        private DataSet CompanyDs { set; get; }
        private DataGridViewRow Row { set; get; }
        private Delegates.BackToCompany BackToCompany { set; get; }
        private Delegates.BackToHome BackToHome { set; get; }
        private Delegates.BackToSearch BackToSearch{ set; get; }
        private string CompanyId { set; get; }
        private int JobId { set; get; }
        private string Title { set; get; }
        private string Type { set; get; }
        private string Category { set; get; }
        private ushort Vacancy { set; get; }
        private string Address { set; get; }
        private double Salary { set; get; }
        private string DeadLine { set; get; }
        private string Description { set; get; }
        private string CompanyName { set; get; }
        private string JobSeekerId { set; get; }
        public JobForm(DataGridViewRow row,Delegates.BackToCompany back)
        {
            InitializeComponent();
            this.Row = row;
            this.BackToCompany = back;
            this.SetAll();
            this.pnlVewPeoples.Visible = true;
            this.BackForm = "Company";
        }
        public JobForm( Delegates.BackToSearch back, DataGridViewRow row)
        {
            InitializeComponent();
            this.Row = row;
            this.BackToSearch = back;
            this.SetAll();
            this.lblMessagetoSignin.Visible = true;
            this.BackForm = "Search";
        }
        public JobForm(Delegates.BackToHome back, DataGridViewRow row)
        {
            InitializeComponent();
            this.Row = row;
            this.BackToHome = back;
            this.SetAll();
            this.lblMessagetoSignin.Visible = true;
            this.BackForm = "Home";
        }
        public JobForm(Delegates.BackToSearch back, DataGridViewRow row,string id)
        {
            InitializeComponent();
            this.Row = row;
            this.BackToSearch = back;
            this.SetAll();
            this.pnlApply.Visible = true;
            this.BackForm = "Search";
            this.JobSeekerId = id;
        }


        private void SetAll()
        {
            this.JobId= Convert.ToInt32(this.Row.Cells[0].Value);
            this.Title = this.lblOutputTitle.Text = this.Row.Cells[1].Value.ToString();
            this.Type = this.lblOutputType.Text = this.Row.Cells[2].Value.ToString();
            this.Category = this.lblOutputCategory.Text = this.Row.Cells[3].Value.ToString();
            this.Description = this.lblOutputDescription.Text = this.Row.Cells[4].Value.ToString();
            this.Vacancy = Convert.ToUInt16(this.Row.Cells[5].Value);
            this.lblOutputVacancy.Text = this.Vacancy.ToString();
            string[] deadline = this.Row.Cells[6].Value.ToString().Split(' ');
            this.DeadLine = this.lblOutputDeadline.Text =deadline[0] ;
            this.Address = this.lblOutputAddress.Text = this.Row.Cells[7].Value.ToString();
            this.Salary = Convert.ToDouble(this.Row.Cells[8].Value);
            this.lblOutputSalary.Text = this.Salary.ToString();
            this.CompanyId= this.Row.Cells[9].Value.ToString();
            this.CompanyDs = CompanyRepo.GetAll(this.CompanyId);
            this.lblOutputCompanyName.Text = this.CompanyDs.Tables[0].Rows[0]["name"].ToString();
            string sql = JobSeekerRepo.GetAppliedJobSeeker(this.JobId);
            this.PopulateDGVAppliedJobSeekers(sql);

        }

        private void PopulateDGVAppliedJobSeekers(string sql)
        {
            try
            {
                DataSet Ds = DataAccess.ExecuteQuery(sql);
                this.dgvAppliedJobSeekers.AutoGenerateColumns = true;
                this.dgvAppliedJobSeekers.DataSource = Ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void BtnViewPoeples_Click(object sender, EventArgs e)
        {
            this.pnlAppliedJobSeekers.Visible = true;
        }

        private void BtnCloseApliedJobSeeker_Click(object sender, EventArgs e)
        {
            this.pnlAppliedJobSeekers.Visible = false;
        }

        private void DgvAppliedJobSeekers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAppliedJobSeekers.CurrentRow;
            Delegates.BackToJobForm Back = this.BackHere;
            new JobSeekerForm(Back,row).Visible = true;
            this.Visible = false;

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (this.BackForm == "Company")
            {
                this.BackToCompany();
                
            }
            else if (this.BackForm == "Search")
            {
                this.BackToSearch();
            }
            else
            {
                this.BackToHome();
            }
            this.Dispose();
        }

        private void BackHere()
        {
            
            this.Visible = true;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                JobSeekerRepo.InsertJobssekerJob(this.JobSeekerId, this.JobId.ToString());
                MessageBox.Show("Application Sent Successfully!", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("You have applied already!","Message",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void JobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            new JobCircularForm(this.BackToCompany, this.Row).Visible = true;
            this.Dispose();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Are sure to delete this job circuler?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    JobRepo.DeleteJob(this.JobId);
                    JobRepo.DeleteJobSeekerJob(this.JobId);
                    MessageBox.Show("Job Circuler deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.BackToCompany();
                this.Dispose();
            }
            else
            {
                return;
            }

            
        }

        private void LblMessagetoSignin_Click(object sender, EventArgs e)
        {
            new SigninForm(this.BackToHome).Visible = true;
            this.Dispose();
        }
    }
}
