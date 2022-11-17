using Microsoft.Data.SqlClient;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            /*
            chart.Series["Salary"].XValueMember = "name";
            chart.Series["Salary"].YValueMembers = "salary";
            this.chart.Titles.Add("Salary Chart for Employee");
            chart.Series["Salary"].ChartType = SeriesChartType.Bar;
            chart.Series["Salary"].IsValueShownAsLabel = true;
            con.Close();
            */
        }
    }
}
