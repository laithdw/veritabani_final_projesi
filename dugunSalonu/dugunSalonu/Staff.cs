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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");
        private void populate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");

            con.Open();

            String query = "select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            con.Close();



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int staffkey = 0;
        private void clear()
        {
            StaffNameTb.Text = "";
            StaffPassTb.Text = "";
            staffkey = 0;
            StaffPhoneTb.Text = "";
            StaffGenderCb.SelectedIndex = -1;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");


            if (StaffNameTb.Text == "" || StaffPassTb.Text == "" || StaffPhoneTb.Text == "" || StaffGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");

            }
            else
            {
                try
                {
                    con.Open();

                    string query = "insert into StaffTbl values ('" + StaffNameTb.Text + "' , '" + StaffPassTb.Text + "','" + StaffGenderCb.SelectedItem.ToString() + "','" + StaffPhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Added");

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

        private void Staff_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");

            if (StaffDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = StaffDGV.SelectedRows[0];

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

                        StaffDGV.Rows.RemoveAt(selectedRow.Index);

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

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < StaffDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = StaffDGV.Rows[e.RowIndex];

                // Assuming the column indexes are 0, 1, 2, 3, and 4 for CustID, Name, Phone, Gender, and Password respectively
                StaffNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                StaffPhoneTb.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty; // Assuming Phone is at index 4
                StaffGenderCb.SelectedItem = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                StaffPassTb.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty; // Assuming Password is at index 2
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V0LNSTEH\SQLEXPRESS;Initial Catalog=Marriage;Integrated Security=True;");


            if (StaffNameTb.Text == "" || StaffPassTb.Text == "" || StaffPhoneTb.Text == "" || StaffGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");

            }
            else
            {
                try
                {
                    con.Open();

                    string query = "Update StaffTbl set StaffName = '" + StaffNameTb.Text + "' ,StaffPhone = '" + StaffPhoneTb.Text + "',StaffGender= '" + StaffGenderCb.Text + "', StaffPassword=  '" + StaffPassTb.Text + "'where StaffId =" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Updated");

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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
