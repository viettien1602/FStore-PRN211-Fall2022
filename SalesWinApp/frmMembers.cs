using BusinessObject.Objects;
using BusinessObject.Services;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        private MemberService memberService = new();
        public Member Member { get; set; }

        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            txtMemberId.Text = Member.MemberId.ToString();
            txtMemberId.Enabled = false;
            txtEmail.Text = Member.Email;
            txtCompanyName.Text = Member.CompanyName;
            txtCity.Text = Member.City;
            txtCountry.Text = Member.Country;
            if (Member.Email.Equals(memberService.GetEmailAdmin()))
            {
                btnOrdersHistory.Visible = false;
                btnBuyProducts.Visible = false;
                btnLogout.Text = "Cancel";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Member? checkMember = memberService.GetMembers().FirstOrDefault(member =>
            {
                return member.Email.Equals(txtEmail.Text) && member.MemberId != Member.MemberId;
            });
            if (checkMember != null)
            {
                MessageBox.Show("Email already exist");
                txtEmail.Text = Member.Email;
                txtCompanyName.Text = Member.CompanyName;
                txtCity.Text = Member.City;
                txtCountry.Text = Member.Country;
            }
            else
            {
                Member = memberService.GetMembers().FirstOrDefault(member => member.MemberId == Member.MemberId);
                Member.Email = txtEmail.Text;
                Member.CompanyName = txtCompanyName.Text;
                Member.City = txtCity.Text;
                Member.Country = txtCountry.Text;
                memberService.Update(Member);
                MessageBox.Show("Update successfully");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders
            {
                MemberId = Member.MemberId
            };
            this.Hide();
            if (frmOrders.ShowDialog() == DialogResult.Cancel)
            {
                frmOrders.Hide();
                this.Show();
            }
        }

        private void btnBuyProducts_Click(object sender, EventArgs e)
        {
            frmBuyProducts frmBuyProducts = new frmBuyProducts
            {
                MemberId= Member.MemberId
            };
            this.Hide();
            if (frmBuyProducts.ShowDialog() == DialogResult.Cancel)
            {
                frmBuyProducts.Hide();
                this.Show();
            }
        }
    }
}
