using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace MedicineOrderingSystem
{
    public partial class Form_Report_Search : Form
    {
        public Form_Report_Search()
        {
            InitializeComponent();
        }

        private void btn_LoadReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SearchParam.Text))
            {
                MessageBox.Show("Please enter an ID to search!");
                return;
            }

            try
            {
                string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";

                string query = "SELECT * FROM PATIENT WHERE PatientID = " + txt_SearchParam.Text;

                OracleDataAdapter adapter = new OracleDataAdapter(query, ordb);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ReportDocument cryRpt = new ReportDocument();

                cryRpt.Load("PatientReport.rpt");

                cryRpt.SetDataSource(dt);

                cryRpt.SetParameterValue("SearchID", txt_SearchParam.Text);

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }

        }
    }
}
