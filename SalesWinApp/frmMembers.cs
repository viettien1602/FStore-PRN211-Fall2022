﻿using System;
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
    public partial class frmMembers : Form
    {

        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {

        }

        private void LoadMembers()
        {
            /* var members = _memberRepository.GetMembers();
            _source = new BindingSource();
            _source.DataSource = members;
            dgvMemberList.DataSource = _source; */
        }

    }
}
