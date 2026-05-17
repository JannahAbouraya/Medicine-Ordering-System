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
    public partial class Form_DriverManagement : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleDataAdapter adapter;
        DataSet ds;
        public Form_DriverManagement()
        {
            InitializeComponent();
        }

        private void Form_DriverManagement_Load(object sender, EventArgs e)
        {



        }

        private void btn_LoadDrivers_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "SELECT * FROM DELIVERY_DRIVER WHERE currentLoc = :loc";
                adapter = new OracleDataAdapter(query, ordb);
                adapter.SelectCommand.Parameters.Add("loc", txt_SearchLocation.Text);
                ds = new DataSet();
                adapter.Fill(ds, "DriversData");

                // Bind the offline data to the visual grid on the screen
                dataGridView1.DataSource = ds.Tables["DriversData"];

                if (ds.Tables["DriversData"].Rows.Count == 0)
                {
                    MessageBox.Show("No drivers found in this location.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (adapter == null || ds == null)
                {
                    MessageBox.Show("Please load the drivers first!");
                    return;
                }
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                adapter.Update(ds, "DriversData");

                MessageBox.Show("All changes saved to the database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }




}
