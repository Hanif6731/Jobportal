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
    public partial class JobCircularForm : MetroForm
    {
        private Delegates.BackToCompany BackToCompany{set;get;}
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
        private DataGridViewRow Row { set; get; }
        private string Purpose { set; get; }

        public JobCircularForm(Delegates.BackToCompany back,string companyId)
        {
            InitializeComponent();
            this.BackToCompany = back;
            this.CompanyId = companyId;
            this.JobId = DataAccess.SearchMaxJobID() + 1;
            this.Purpose = "addJob";
        }
        public JobCircularForm(Delegates.BackToCompany back, DataGridViewRow row)
        {
            InitializeComponent();
            this.BackToCompany = back;
            this.Row = row;
            this.Purpose = "update";
            this.SetAll();
            
        }

        private void SetAll()
        {
            this.JobId = Convert.ToInt32(this.Row.Cells[0].Value);
            this.Title = this.txtTitle.Text = this.Row.Cells[1].Value.ToString();
            this.Type = this.cmbType.Text = this.Row.Cells[2].Value.ToString();
            this.Category = this.txtCategory.Text = this.Row.Cells[3].Value.ToString();
            this.Description = this.txtDescription.Text = this.Row.Cells[4].Value.ToString();
            this.Vacancy = Convert.ToUInt16(this.Row.Cells[5].Value);
            this.txtVacancy.Text = this.Vacancy.ToString();
            this.DeadLine = this.dtpDeadline.Text = this.Row.Cells[6].Value.ToString();
            this.Address = this.txtAddress.Text = this.Row.Cells[7].Value.ToString();
            this.Salary = Convert.ToDouble(this.Row.Cells[8].Value);
            this.txtSalary.Text = this.Salary.ToString();
            this.CompanyId = this.Row.Cells[9].Value.ToString();
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string sql;
            this.Title = this.txtTitle.Text;
            this.Type = this.cmbType.Text;
            this.Category = this.txtCategory.Text;
            this.Address = this.txtAddress.Text;
            this.DeadLine = this.dtpDeadline.Text;
            this.Description = this.txtDescription.Text;
            if (Validation.Text(this.Title, this.Type, this.Category,this.Description, this.txtVacancy.Text,this.txtSalary.Text, this.Address, this.DeadLine))
            {
                try
                {
                    string message;
                    
                    if (Validation.IsNumber(this.txtVacancy.Text) && Validation.IsDouble(this.txtSalary.Text))
                    {
                        this.Vacancy = Convert.ToUInt16(this.txtVacancy.Text);
                        this.Salary = Convert.ToDouble(this.txtSalary.Text);
                        if (this.Purpose == "addJob")
                        {
                            sql = JobRepo.InsertJob(this.JobId.ToString(), this.Title, this.Type, this.Category, this.Description, this.Vacancy.ToString(), this.DeadLine, this.Address, this.Salary.ToString(), this.CompanyId);
                            message = "Job Published successfully";
                        }
                        else
                        {
                            sql = JobRepo.UpdateJob(this.Title, this.Type, this.Category, this.Description, this.Vacancy.ToString(), this.DeadLine, this.Address, this.Salary.ToString(), this.JobId.ToString());
                            message = "Job updated successfully";
                        }
                        DataAccess.ExecuteUpdateQuery(sql);
                        MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.BackToCompany();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Vacancy or Salary Should be Digits", "Message!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("All fields are required to fillup", "Message!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.BackToCompany();
            this.Dispose();
        }

        private void JobCircularForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
