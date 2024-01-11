using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dugunSalonu
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //   private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //  if (WineCheck.Checked == true)
        // {
        //WinePrice.Enabled = true;
        //WineQty.Enabled = true;
        //
        // else
        //{
        //WinePrice.Enabled = false;
        //WineQty.Enabled = false;

        //WinePrice.Text = "";
        //WineQty.Text = "";


        //}
        //

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked== true)
            {
                BeerPrice.Enabled = true;
                BeerQty.Enabled = true;
            }
            else
            {
                BeerPrice.Enabled = false;
                BeerQty.Enabled = false;

                BeerPrice.Text = "";
                BeerQty.Text = "";


            }



        }

        private void BeerQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void SodaCheck_CheckStateChanged(object sender, EventArgs e)
        {

            if (SodaCheck.Checked == true)
            {
                SodaPrice.Enabled = true;
                SodaQty.Enabled = true;
            }
            else
            {
                SodaPrice.Enabled = false;
                SodaQty.Enabled = false;

                SodaPrice.Text = "";
                SodaQty.Text = "";


            }



        }

        private void WaterCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (WaterCheck.Checked == true)
            {
                WaterPrice.Enabled = true;
                WaterQty.Enabled = true;
            }
            else
            {
                WaterPrice.Enabled = false;
                WaterQty.Enabled = false;

                WaterPrice.Text = "";
                WaterQty.Text = "";


            }
        }

        private void JuiceCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (JuiceCheck.Checked == true)
            {
                JuicePrice.Enabled = true;
                JuiceQty.Enabled = true;
            }
            else
            {
                JuicePrice.Enabled = false;
                JuiceQty.Enabled = false;

                JuicePrice.Text = "";
                JuiceQty.Text = "";


            }
        }

        private void MeatCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (MeatCheck.Checked == true)
            {
                MeatPrice.Enabled = true;
                MeatQty.Enabled = true;
            }
            else
            {
                MeatPrice.Enabled = false;
                MeatQty.Enabled = false;

                MeatPrice.Text = "";
                MeatQty.Text = "";


            }
        }

        private void ChickenCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (ChickenCheck.Checked == true)
            {
                ChickenPrice.Enabled = true;
                ChickenQty.Enabled = true;
            }
            else
            {
                ChickenPrice.Enabled = false;
                ChickenQty.Enabled = false;

                ChickenPrice.Text = "";
                ChickenQty.Text = "";


            }
        }

        private void FishCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (FishCheck.Checked == true)
            {
                FishPrice.Enabled = true;
                FishQty.Enabled = true;
            }
            else
            {
                FishPrice.Enabled = false;
                FishQty.Enabled = false;

                FishPrice.Text = "";
                FishQty.Text = "";


            }
        }

        private void SaucageCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (SaucageCheck.Checked == true)
            {
                SaucagePrice.Enabled = true;
                SaucageQty.Enabled = true;
            }
            else
            {
                SaucagePrice.Enabled = false;
                SaucageQty.Enabled = false;

                SaucagePrice.Text = "";
                SaucageQty.Text = "";


            }
        }

        private void SaladCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (SaladCheck.Checked == true)
            {
                SaladPrice.Enabled = true;
                SaladQty.Enabled = true;
            }
            else
            {
                SaladPrice.Enabled = false;
                SaladQty.Enabled = false;

                SaladPrice.Text = "";
                SaladQty.Text = "";


            }
        }

        private void WineCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (WineCheck.Checked == true)
            {
                WinePrice.Enabled = true;
                WineQty.Enabled = true;
            }
            else
            {
                WinePrice.Enabled = false;
                WineQty.Enabled = false;

                WinePrice.Text = "";
                WineQty.Text = "";


            }
        }

        private void BevCostlbl_Click(object sender, EventArgs e)
        {
            int beer=0, soda=0, wine=0, water=0, juice=0;
            if (checkBox3.Checked && !string.IsNullOrEmpty(BeerPrice.Text) && !string.IsNullOrEmpty(BeerQty.Text))
            {
                beer = Convert.ToInt32(BeerPrice.Text) * Convert.ToInt32(BeerQty.Text);
            }
            else
            {
                MessageBox.Show("Enter Beer Price and Quantity");
            }


            beer = 0; wine = 0; water = 0; soda = 0; juice = 0;

            if (SodaCheck.Checked && !string.IsNullOrEmpty(SodaPrice.Text) && !string.IsNullOrEmpty(SodaQty.Text))
            {
                soda = Convert.ToInt32(SodaPrice.Text) * Convert.ToInt32(SodaQty.Text);
            }
            else if (SodaCheck.Checked)
            {
                MessageBox.Show("Enter Soda Quantity");
            }

            if (WineCheck.Checked && !string.IsNullOrEmpty(WinePrice.Text) && !string.IsNullOrEmpty(WineQty.Text))
            {
                wine = Convert.ToInt32(WinePrice.Text) * Convert.ToInt32(WineQty.Text);
            }
            else if (WineCheck.Checked)
            {
                MessageBox.Show("Enter Wine Quantity");
            }

            if (WaterCheck.Checked && !string.IsNullOrEmpty(WaterPrice.Text) && !string.IsNullOrEmpty(WaterQty.Text))
            {
                water = Convert.ToInt32(WaterPrice.Text) * Convert.ToInt32(WaterQty.Text);
            }
            else if (WaterCheck.Checked)
            {
                MessageBox.Show("Enter Water Quantity");
            }

            if (JuiceCheck.Checked && !string.IsNullOrEmpty(JuicePrice.Text) && !string.IsNullOrEmpty(JuiceQty.Text))
            {
                juice = Convert.ToInt32(JuicePrice.Text) * Convert.ToInt32(JuiceQty.Text);
            }
            else if (JuiceCheck.Checked)
            {
                MessageBox.Show("Enter Juice Quantity");
            }

            int bevcost = beer + wine + water + soda + juice;
            BevCostlbl.Text = bevcost.ToString();




            
                int meat = 0, chicken = 0, fish = 0, saucage = 0, salad = 0;

                if (MeatCheck.Checked && !string.IsNullOrEmpty(MeatPrice.Text) && !string.IsNullOrEmpty(MeatQty.Text))
                {
                    meat = Convert.ToInt32(MeatPrice.Text) * Convert.ToInt32(MeatQty.Text);
                }
                else if (MeatCheck.Checked)
                {
                    MessageBox.Show("Enter Meat Quantity");
                }

                if (ChickenCheck.Checked && !string.IsNullOrEmpty(ChickenPrice.Text) && !string.IsNullOrEmpty(ChickenQty.Text))
                {
                    chicken = Convert.ToInt32(ChickenPrice.Text) * Convert.ToInt32(ChickenQty.Text);
                }
                else if (ChickenCheck.Checked)
                {
                    MessageBox.Show("Enter Chicken Quantity");
                }

                if (FishCheck.Checked && !string.IsNullOrEmpty(FishPrice.Text) && !string.IsNullOrEmpty(FishQty.Text))
                {
                    fish = Convert.ToInt32(FishPrice.Text) * Convert.ToInt32(FishQty.Text);
                }
                else if (FishCheck.Checked)
                {
                    MessageBox.Show("Enter Fish Quantity");
                }

                if (SaucageCheck.Checked && !string.IsNullOrEmpty(SaucagePrice.Text) && !string.IsNullOrEmpty(SaucageQty.Text))
                {
                    saucage = Convert.ToInt32(SaucagePrice.Text) * Convert.ToInt32(SaucageQty.Text);
                }
                else if (SaucageCheck.Checked)
                {
                    MessageBox.Show("Enter Sausage Quantity");
                }

                if (SaladCheck.Checked && !string.IsNullOrEmpty(SaladPrice.Text) && !string.IsNullOrEmpty(SaladQty.Text))
                {
                    salad = Convert.ToInt32(SaladPrice.Text) * Convert.ToInt32(SaladQty.Text);
                }
                else if (SaladCheck.Checked)
                {
                    MessageBox.Show("Enter Salad Quantity");
                }

                int foodCost = meat + chicken + fish + saucage + salad;
                FoodCostlbl.Text = foodCost.ToString();
            



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
        private void GetStaffId()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT StaffId FROM StaffTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);

            StaffIdCb.ValueMember = "StaffId";
            StaffIdCb.DisplayMember = "StaffId";
            StaffIdCb.DataSource = dt;

            con.Close();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            GetCustId();
            GetStaffId();
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
                    Custnamelbl.Text = dr["CustName"].ToString();
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
        private void fetchStaffName()
        {
            try
            {
                con.Open();
                string mysql = "SELECT * FROM StaffTbl WHERE StaffId = " + StaffIdCb.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(mysql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Custnamelbl.Text = dr["StaffName"].ToString();
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
        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchcustName();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "INSERT INTO BookingTbl (BDate, Persons, CustName) VALUES (@BDate, @Persons, @CustName)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@BDate", dateTimePicker1.Value.Date);
               // DateTime reservationTime = DateTime.Now; 
              //  cmd.Parameters.AddWithValue("@BTime", reservationTime); 
                cmd.Parameters.AddWithValue("@Persons", Convert.ToInt32(Personno.Text)); 
                cmd.Parameters.AddWithValue("@CustName", Custnamelbl.Text);
               // cmd.Parameters.AddWithValue("@Dishes",MeatQty ); 
                // cmd.Parameters.AddWithValue("@Drinks", YourDrinksValue);
                cmd.Parameters.AddWithValue("@CustId", Convert.ToInt32(CustIdCb.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervasyon başarıyla eklendi.");
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
        private void clear()
        {
            Personno.Text = "";
            resTime.Text = "";
            BeerPrice.Text = "";
            BeerQty.Text = "";
            SodaPrice.Text = "";
            SodaQty.Text = "";
            WinePrice.Text = "";
            WineQty.Text = "";
            WaterPrice.Text = "";
            WaterQty.Text = "";
            JuicePrice.Text = "";
            JuiceQty.Text = "";
            MeatPrice.Text = "";
            MeatQty.Text = "";
            ChickenPrice.Text = "";
            ChickenQty.Text = "";
            FishPrice.Text = "";
            FishQty.Text = "";
            SaucagePrice.Text = "";
            SaucageQty.Text = "";
            SaladPrice.Text = "";
            SaladQty.Text = "";






        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void StaffIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchStaffName();
        }
    }
}
