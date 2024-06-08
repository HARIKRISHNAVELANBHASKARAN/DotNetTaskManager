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
    public partial class DEL : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=taskmanager;Integrated Security=True");

        public DEL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int NO = int.Parse(TASKNUMBER.Text);
                con.Open();
                SqlCommand sq = new SqlCommand("DELETE FROM TASK WHERE NO=@NO", con);
                sq.Parameters.AddWithValue("@NO", NO);
                sq.ExecuteNonQuery();
                MessageBox.Show("TASK DELETED.");
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
    }
}
