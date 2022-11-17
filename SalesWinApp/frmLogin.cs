using BusinessObject.Objects;
using BusinessObject.Services;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private MemberService memberService = new MemberService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Please input email");
            }
            else if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please input password");
            }
            else
            {
                var member = memberService.GetMembers()
                    .Where(member => member.Email.Equals(txtEmail.Text)
                    && member.Password.Equals(txtPassword.Text)).FirstOrDefault();

                if (member == null)
                {
                    MessageBox.Show("Invalid email or password");
                }
                else
                {
                    
                    if (member.Email.Equals(memberService.GetEmailAdmin()))
                    {
                        MessageBox.Show("You are admin");
                        frmMain frm = new frmMain()
                        {
                            CurMember = member
                        };
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
<<<<<<< HEAD
                        frmMembers frmMembers = new frmMembers
                        {
                            Member = member
                        };
                        this.Hide();
                        if (frmMembers.ShowDialog() == DialogResult.Cancel)
                        {
                            frmMembers.Hide();
                            this.Show();
                        }
=======

>>>>>>> feature/member-demo
                    }

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmCreateMember frmCreateMember = new frmCreateMember();
            this.Hide();
            if (frmCreateMember.ShowDialog() == DialogResult.Cancel)
            {
                frmCreateMember.Hide();
                this.Show();
            }
        }
    }
}