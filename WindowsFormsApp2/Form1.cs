using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data source=DESKTOP-FUHREN7\\SQLEXPRESS;Initial Catalog=BCA5th; Integrated security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (IsPhoneNumberValid(userphone.Text))
                {
                    using (var con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            var cmd = new SqlCommand("INSERT INTO student (name, address, Contact) VALUES (@name, @address, @Contact)", con);
                            cmd.Parameters.AddWithValue("@name", std_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", address.Text.Trim());
                            cmd.Parameters.AddWithValue("@Contact", userphone.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully");
                            ClearInputs();
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (IsPhoneNumberValid(userphone.Text))
                {
                    using (var con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            var cmd = new SqlCommand("UPDATE student SET name=@name, address=@address, Contact=@Contact WHERE id=@id", con);
                            cmd.Parameters.AddWithValue("@id", userid.Text.Trim());
                            cmd.Parameters.AddWithValue("@name", std_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", address.Text.Trim());
                            cmd.Parameters.AddWithValue("@Contact", userphone.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data updated successfully");
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userid.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var cmd = new SqlCommand("DELETE FROM student WHERE id=@id", con);
                    cmd.Parameters.AddWithValue("@id", userid.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data deleted successfully");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var da = new SqlDataAdapter("SELECT * FROM student", con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearInputs()
        {
            std_name.Text = "";
            address.Text = "";
            userphone.Text = "";
            userid.Text = "";
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(std_name.Text) && !string.IsNullOrWhiteSpace(address.Text) && !string.IsNullOrWhiteSpace(userphone.Text);
        }

        private bool IsPhoneNumberValid(string phone)
        {
            return !string.IsNullOrWhiteSpace(phone) && phone.Length >= 10 && phone.All(char.IsDigit);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userid.Text = row.Cells["id"].Value.ToString();
                std_name.Text = row.Cells["name"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
                userphone.Text = row.Cells["Contact"].Value.ToString();
            }
        }
    }
}
