using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TASK_MANAGER
{
    public partial class SIGNUP : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=taskmanager;Integrated Security=True");

        public SIGNUP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EMAIL = email.Text;
            string PASSWORD = password.Text;
            try
            {
                con.Open();

                SqlCommand deleteCmd = new SqlCommand("DELETE FROM LOGIN", con);
                deleteCmd.ExecuteNonQuery();

                SqlCommand insertCmd = new SqlCommand("INSERT INTO LOGIN (EMAIL, PASSWORD) VALUES (@EMAIL, @PASSWORD)", con);
                insertCmd.Parameters.AddWithValue("@EMAIL", EMAIL);
                insertCmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);
                insertCmd.ExecuteNonQuery();
                MessageBox.Show(" Updated successfully.");

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();


        }
    }
}
