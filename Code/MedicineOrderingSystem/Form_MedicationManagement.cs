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
    public partial class Form_MedicationManagement : Form
    {
        string constr = "User Id=scott;Password=tiger;Data Source=orcl";
        OracleConnection conn;
        public Form_MedicationManagement()
        {
            InitializeComponent();
        }

        private void Form_MedicationManagement_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT medname FROM medication";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_SearchMed.Items.Add(dr[0].ToString());
            }

            dr.Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_medicationSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT price, stockqty FROM medication WHERE medname = :name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", cmb_SearchMed.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Price.Text = dr[0].ToString();
                txt_Stock.Text = dr[1].ToString();
            }
            dr.Close();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int newMedID = 1;

                OracleCommand cmdID = new OracleCommand();
                cmdID.Connection = conn;
                cmdID.CommandText = "SELECT NVL(MAX(MedID), 0) + 1 FROM MEDICATION";
                cmdID.CommandType = CommandType.Text;

                OracleDataReader dr = cmdID.ExecuteReader();
                if (dr.Read())
                {
                    newMedID = Convert.ToInt32(dr[0]);
                }
                dr.Close();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO MEDICATION (MedID, MedName, Price, RequiresPrescription, StockQty) VALUES (:id, :name, :price, :req_pres, :stock)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("id", newMedID);
                cmd.Parameters.Add("name", txt_NewMedName.Text);
                cmd.Parameters.Add("price", txt_NewPrice.Text);
                cmd.Parameters.Add("req_pres", txt_NewReqPres.Text);
                cmd.Parameters.Add("stock", txt_NewStock.Text);

                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("New Medication added successfully!\nAssigned ID: " + newMedID);

                    txt_NewMedName.Clear();
                    txt_NewPrice.Clear();
                    txt_NewReqPres.Clear();
                    txt_NewStock.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void Form_MedicationManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();


        }



    }
}
