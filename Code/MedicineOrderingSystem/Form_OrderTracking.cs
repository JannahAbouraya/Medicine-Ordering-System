using Oracle.DataAccess.Client;
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
    public partial class Form_OrderTracking : Form
    {
        public Form_OrderTracking()
        {
            InitializeComponent();
        }

        string constr = "User Id=scott;Password=tiger;Data Source=orcl";
        OracleConnection conn;



        private void btn_TrackOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_OrderID.Text))
            {
                MessageBox.Show("Please enter an Order ID first!");
                return;
            }

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_GetOrderTracking";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_OrderID", txt_OrderID.Text);
                cmd.Parameters.Add("p_OrderStatus", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_DriverID", OracleDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_CurrentLat", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_CurrentLng", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_OrderStatus"].Value == null || cmd.Parameters["p_OrderStatus"].Value.ToString() == "null")
                {
                    MessageBox.Show("Order ID not found. Please check the number and try again.");

                    txt_Status.Clear();
                    txt_DriverID.Clear();
                    txt_Lat.Clear();
                    txt_Lng.Clear();
                }
                else
                {
                    txt_Status.Text = cmd.Parameters["p_OrderStatus"].Value.ToString();
                    txt_DriverID.Text = cmd.Parameters["p_DriverID"].Value.ToString();
                    txt_Lat.Text = cmd.Parameters["p_CurrentLat"].Value.ToString();
                    txt_Lng.Text = cmd.Parameters["p_CurrentLng"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    

        private void Form_OrderTracking_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();
        }

      
        private void btn_DisplayOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_GetOrderDetails";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_order_id", txt_OrderID.Text);
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dr = cmd.ExecuteReader();
                txt_OrderDetails.Clear();


                while (dr.Read())
                {

                    string itemDetails = "Date: " + dr[1].ToString() + " | Status: " + dr[3].ToString() + " | Medicine Name: " + dr[6].ToString() + " | Quantity: " + dr[4].ToString();


                    txt_OrderDetails.AppendText(itemDetails + Environment.NewLine);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order: " + ex.Message);
            }
        }


    }
}
    


