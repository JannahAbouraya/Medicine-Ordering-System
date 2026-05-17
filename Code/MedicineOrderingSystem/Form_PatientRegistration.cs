using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace MedicineOrderingSystem
{
    public partial class Form_PatientRegistration : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;"; 
        OracleDataAdapter adapter;
        DataSet ds;

        public Form_PatientRegistration()
        {
            InitializeComponent();
        }

        private void btn_LoadPatients_Click(object sender, EventArgs e)
        {

            try
            {
                string query;

                if (string.IsNullOrWhiteSpace(txt_SearchPhone.Text))
                {
                    query = "SELECT * FROM PATIENT";
                    adapter = new OracleDataAdapter(query, ordb);
                }
                else
                {
                    query = "SELECT * FROM PATIENT WHERE PatientPhone = :phone";
                    adapter = new OracleDataAdapter(query, ordb);
                    adapter.SelectCommand.Parameters.Add("phone", txt_SearchPhone.Text);
                }

                ds = new DataSet();

                adapter.Fill(ds, "PatientsData");

                dataGridView1.DataSource = ds.Tables["PatientsData"];

                if (ds.Tables["PatientsData"].Rows.Count == 0)
                {
                    MessageBox.Show("No patients found. You can add new ones in the grid below!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void btn_SavePatients_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (adapter == null || ds == null)
                {
                    MessageBox.Show("Please load the patient table first!");
                    return;
                }

              
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                adapter.Update(ds, "PatientsData");

                MessageBox.Show("Patient database successfully updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void Form_PatientRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
