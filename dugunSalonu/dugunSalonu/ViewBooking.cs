using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dugunSalonu
{
    public partial class ViewBooking : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");

        public ViewBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < BookingDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = BookingDGV.Rows[e.RowIndex];
                Booking b=new Booking();
                // Assuming the column indexes are 0, 1, 2, and 3 for CustID, Name, Address, and Phone respectively
                b.dateTimePicker1.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                b.resTime.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                b.Personno.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                //b.Personno.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                //b.Personno.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                //b.Personno.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                //b.Personno.Text = selectedRow.Cells[71].Value?.ToString() ?? string.Empty;

                //b.Personno.Text = selectedRow.Cells[8].Value?.ToString() ?? string.Empty;

                //b.Personno.Text = selectedRow.Cells[9].Value?.ToString() ?? string.Empty;

                //b.Personno.Text = selectedRow.Cells[10].Value?.ToString() ?? string.Empty;

                //b.Personno.Text = selectedRow.Cells[11].Value?.ToString() ?? string.Empty;

                //b.Personno.Text = selectedRow.Cells[12].Value?.ToString() ?? string.Empty;





            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void fetchcustName()
        {
            try
            {
                con.Open();
                string mysql = "SELECT * FROM CustomerTbl WHERE CustId = " + CustIdCb.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(mysql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    CustNamelbl.Text = dr["CustName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void CustIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchcustName();
        }
        private void GetCustId()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CustId FROM CustomerTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);

            CustIdCb.ValueMember = "CustId";
            CustIdCb.DisplayMember = "CustId";
            CustIdCb.DataSource = dt;

            con.Close();
        }
        private string GetCustomerName(int custId)
        {
            string custName = "";

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT CustName FROM CustomerTbl WHERE CustId = @CustId", con);
                cmd.Parameters.AddWithValue("@CustId", custId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    custName = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return custName;
        }

      

       
        private void ViewBooking_Load(object sender, EventArgs e)
        {
            GetCustId();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
        //private void fetchbooking() { }
        //private void fetchbookingate()
        //{
        //    try
        //    {
        //        con.Open();
               

        //        SqlCommand cmd = new SqlCommand(mysql, con);
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        sda.Fill(dt);

        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            CustNamelbl.Text = dr["CustName"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Hata: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        private void BDateCb_ValueChanged(object sender, EventArgs e)
        {

        }
    } 
    }

