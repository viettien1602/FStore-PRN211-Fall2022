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
    public partial class frmMembersManagement : Form
    {
        private MemberService _memberService = new MemberService();

        private BindingSource _source;
        public frmMembersManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            var members = _memberService.GetMembers().Select(m => new
            {
                MemberId = m.MemberId,
                Email = m.Email,
                CompanyName = m.CompanyName,
                City = m.City,
                Country = m.Country
            }); 
            _source = new BindingSource();
            _source.DataSource = members;
            dgvMemberList.DataSource = _source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = dgvMemberList.SelectedRows[0].Cells[0].Value;
            if (id is not null)
            {
                Member selectedMember = _memberService.GetMembers().FirstOrDefault(x => x.MemberId == (int)id);
                if (selectedMember.Email.Equals(_memberService.GetEmailAdmin()))
                {
                    MessageBox.Show("Can not remove admin!");
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Do you want to delete?", "Cancel", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        bool s = _memberService.DeleteMember(selectedMember);
                        if (s)
                        {
                            LoadMembers();
                            MessageBox.Show("Sucessfully deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Unsuccessfully deleted!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Unsuccessfully deleted!!!");
            }
        }
    }
}
