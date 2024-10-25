using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MEET\source\repos\login\login\Database1.mdf;Integrated Security=True");
        private Form Form2;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize any components or settings if necessary
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string user_password = txt_password.Text;

            try
            {
                string query = "SELECT * FROM Login_new WHERE username = @username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", user_password);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable Dtable = new DataTable();
                    sda.Fill(Dtable);

                    if (Dtable.Rows.Count > 0)
                    {
                        Form2 = new Form(); // Replace with your actual form
                        Form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string user_password = txt_password.Text;

            try
            {
                string insertQuery = "INSERT INTO Login_new (username, password) VALUES (@username, @password)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", user_password);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
