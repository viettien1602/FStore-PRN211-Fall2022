using BusinessObject.Services;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmCreateMember : Form
    {
        private MemberService memberService = new MemberService();
        public frmCreateMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member member = memberService.GetMembers().FirstOrDefault(member => member.Email.Equals(txtEmail.Text));
            if (member != null)
            {
                MessageBox.Show("Email already exist.");
                this.Show();
            }
            else
            {
                member = new Member
                {
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
                memberService.Create(member);
                this.Hide();
                frmMembers frmMembers = new frmMembers
                {
                    Member = member
                };
                this.Hide();
                if (frmMembers.ShowDialog() == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmCreateMember_Load(object sender, EventArgs e)
        {

        }
    }
}
