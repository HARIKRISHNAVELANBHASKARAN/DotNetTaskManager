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

namespace TASK_MANAGER
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=taskmanager;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            if (!panel1.Controls.Contains(userControl))
            {
                panel1.Controls.Add(userControl);
            }
            userControl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string EMAIL = email.Text;
            string PASSWORD = pass.Text;
            try
            {
                con.Open();
                SqlCommand sq = new SqlCommand("SELECT COUNT(*) FROM LOGIN WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD", con);
                sq.Parameters.AddWithValue("@EMAIL", EMAIL);
                sq.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                int count = (int)sq.ExecuteScalar();
                if (count > 0)
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect email or password.");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            SIGNUP uc = new SIGNUP();
            addUserControl(uc);
        }

    }
}
