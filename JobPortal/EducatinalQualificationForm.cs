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
    public partial class EducatinalQualificationForm : MetroForm
    {
        private delegate bool GPAorCGPA(string cgpa);
        private Delegates.BackToJobSeekerForm BackToJobSeeker { set; get; }
        private DataGridViewRow Row { set; get; }
        private SignupForm SUF { set; get; }
        private string BackPage { set; get; }
        private string JobSeekerId { set; get; }
        private string OldDegree { set; get; }
        private string Degree { set; get; }
        private double Cgpa { set; get; }
        private string Major { set; get; }
        private string PassingYear { set; get; }
        private string Institute { set; get; }
        private string Board { set; get; }
        public EducatinalQualificationForm(Delegates.BackToJobSeekerForm btJSF, DataGridViewRow row)
        {
            InitializeComponent();
            this.BackToJobSeeker = btJSF;
            this.Row = row;
            this.SetAll();
            
        }
        public void SetAll()
        {
            int i = 0;
            this.OldDegree = this.Degree = this.txtDegree.Text = this.Row.Cells[i++].Value.ToString();
            this.Major=this.txtMajor.Text = this.Row.Cells[i++].Value.ToString();
            this.dtpPassingYear.Text = this.Row.Cells[i++].Value.ToString();
            this.Institute=this.txtInstituteName.Text = this.Row.Cells[i++].Value.ToString(); 
            this.txtCgpa.Text = this.Row.Cells[i++].Value.ToString();
            this.Cgpa = Convert.ToDouble(this.txtCgpa.Text);
            this.Board=this.cmbBoard.Text = this.Row.Cells[i++].Value.ToString();
            this.JobSeekerId = this.Row.Cells[i++].Value.ToString();
            this.Text = "Update Eduaction Info";
            
        }

        public EducatinalQualificationForm(SignupForm suf)
        {
            InitializeComponent();
            this.SUF = suf;
            this.BackPage = "SignUp";
            this.JobSeekerId = this.SUF.JobSeekerId;
            

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (this.BackPage == "SignUp")
            {
                this.SUF.Visible = true;
                
            }
            else
            {
                this.BackToJobSeeker();
            }
            this.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //List<string> list = new List<string>();
            string sql;
            this.Degree = this.txtDegree.Text;
            this.Major = this.txtMajor.Text;
            this.PassingYear = this.dtpPassingYear.Text;
            this.Institute = this.txtInstituteName.Text;
            
            this.Board = this.cmbBoard.Text;
            if (Validation.Text(this.Degree, this.Major, this.PassingYear, this.Institute, this.Board, this.txtCgpa.Text))
            {
                GPAorCGPA gpaOrCgpa;
                if (this.cmbGPAorCGPA.Text == "GPA")
                {
                    gpaOrCgpa = Validation.ValidGpa;
                }
                else if(this.cmbGPAorCGPA.Text=="CGPA")
                {
                    gpaOrCgpa = Validation.ValidCgpa;
                }
                else
                {
                    MessageBox.Show("Please select GPA or CGPA","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                
                if (gpaOrCgpa(this.txtCgpa.Text))
                {
                    this.Cgpa = Convert.ToDouble(this.txtCgpa.Text);
                    if (OldDegree == null)
                    {
                        try
                        {

                            EducationalQualificationRepo.InsertEducationInfo(this.Degree, this.Major, this.dtpPassingYear.Value.ToString(), this.Institute, this.Cgpa.ToString(), this.Board, this.JobSeekerId);
                           
                            MessageBox.Show("Eduacational Background Added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
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
                            EducationalQualificationRepo.UpdateEducationInfo(this.Degree, this.Major, this.dtpPassingYear.Value.ToString(), this.Institute, this.Cgpa.ToString(), this.Board, this.JobSeekerId,this.OldDegree);
                            MessageBox.Show("Eduacational Background updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (this.BackPage == "SignUp")
                    {
                        this.SUF.Visible = true;
                    }
                    else
                    {
                        this.BackToJobSeeker();
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("CGPA Scale is 4.00 and GPA Scale is 5.00!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("All fields are required to fill!","Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EducatinalQualificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
