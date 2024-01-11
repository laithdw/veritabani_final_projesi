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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");


            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");

            }
            else
            {
                try
                {
                    con.Open();
                   
                    string query = "insert into CustomerTbl values ('" + CustNameTb.Text + "' , '" + CustAddTb.Text + "', '" + CustPhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");

                    con.Close();
                    populate();
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void populate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");

            con.Open();

            String query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            con.Close();


            
        }



        int custkey = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomerDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = CustomerDGV.Rows[e.RowIndex];

                // Assuming the column indexes are 0, 1, 2, and 3 for CustID, Name, Address, and Phone respectively
                CustNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                CustAddTb.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                CustPhoneTb.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;



            }
        }





        private void Customer_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void clear()
        {
            CustPhoneTb.Text = "";
            CustAddTb.Text = "";
            custkey = 0;
            CustNameTb.Text = "";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");

            if (CustomerDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = CustomerDGV.SelectedRows[0];

                // Assuming the column index for the CustID is 0 (adjust if different)
                int customerId = Convert.ToInt32(selectedRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE CustID = @CustID", con);
                        cmd.Parameters.AddWithValue("@CustID", customerId);
                        cmd.ExecuteNonQuery();

                        CustomerDGV.Rows.RemoveAt(selectedRow.Index);

                        con.Close();

                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");


            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");

            }
            else
            {
                try
                {
                    con.Open();

                    string query = "Update CustomerTbl set CustName = '" + CustNameTb.Text + "' ,CustAdd = '" + CustAddTb.Text + "',CustPhone= '" + CustPhoneTb.Text + "'where CustId ="+ custkey+ ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");

                    con.Close();
                    populate();
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }











        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
    }
