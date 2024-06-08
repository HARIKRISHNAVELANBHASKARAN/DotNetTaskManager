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
    public partial class ADDDELL : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=taskmanager;Integrated Security=True");

        public ADDDELL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DESCRIPTION = description.Text;
            string DUEDATE = Duedate.Value.ToShortDateString();
            string PRIORITY = priority.SelectedItem.ToString();
            try
            {
                con.Open();
                SqlCommand sq = new SqlCommand("INSERT INTO TASK (DESCRIPTION, DUEDATE, PRIORITY) VALUES (@DESCRIPTION, @DUEDATE, @PRIORITY)", con);
                sq.Parameters.AddWithValue("@DESCRIPTION", DESCRIPTION);
                sq.Parameters.AddWithValue("@DUEDATE", DUEDATE);
                sq.Parameters.AddWithValue("@PRIORITY", PRIORITY);
                sq.ExecuteNonQuery();
                MessageBox.Show(" TASK ADDED.");
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
