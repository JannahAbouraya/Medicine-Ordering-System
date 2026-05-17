using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace MedicineOrderingSystem
{
    public partial class Form_Report_Refills : Form
    {
        ReportDocument cryRpt;

        public Form_Report_Refills()
        {
            InitializeComponent();
        }



        private void Form_Report_Refills_Load(object sender, EventArgs e)
        {
            try
            {
                cryRpt = new ReportDocument();

                cryRpt.Load("RefillsReport.rpt");
                cryRpt.SetDatabaseLogon("scott", "tiger", "orcl", "");

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Refills report: " + ex.Message);
            }
        }
    }
}