using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineOrderingSystem
{
    public partial class Main_Interface : Form
    {
        public Main_Interface()
        {
            InitializeComponent();
        }

        private void Main_Interface_Load(object sender, EventArgs e)
        {

        }

        private void btn_Conn_Med_Click(object sender, EventArgs e)
        {
            Form_MedicationManagement frm = new Form_MedicationManagement();
            frm.ShowDialog();
        }

        private void btn_Conn_Track_Click(object sender, EventArgs e)
        {
            Form_OrderTracking frm = new Form_OrderTracking();
            frm.ShowDialog();
        }

        private void btn_Disconn_Patients_Click(object sender, EventArgs e)
        {
            Form_PatientRegistration frm = new Form_PatientRegistration();
            frm.ShowDialog();
        }

        private void btn_Disconn_Drivers_Click(object sender, EventArgs e)
        {
            Form_DriverManagement frm = new Form_DriverManagement();
            frm.ShowDialog();

        }



        private void btn_Rep_Orders_Click(object sender, EventArgs e)
        {
            Form_Report_Search frm = new Form_Report_Search();
            frm.ShowDialog();
        }

        private void btn_ReportRefills_Click(object sender, EventArgs e)
        {
            Form_Report_Refills frm = new Form_Report_Refills();
            frm.ShowDialog();
        }
    }
}
