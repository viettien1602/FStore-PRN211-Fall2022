﻿using BusinessObject.Services;
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
    public partial class frmMain : Form
    {
        private MemberService _memberService = new MemberService();

        public Member CurMember { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            load(CurMember);
        }

        private void load(Member member)
        {
            if (!member.Email.Equals(_memberService.GetEmailAdmin()))
            {
                menuManageMember.Visible = false;
                menuManageOrder.Visible = false;
                menuManageProduct.Visible = false;
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuManageMember_Click(object sender, EventArgs e)
        {
            frmMembersManagement frm = new frmMembersManagement();
            frm.Show();
        }
    }
}
