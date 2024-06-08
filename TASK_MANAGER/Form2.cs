using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_MANAGER
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TASK uc = new TASK();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
             panelContainer.Controls.Clear();
             panelContainer.Controls.Add(userControl);
             userControl.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDDELL uc = new ADDDELL();
            addUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TASK uc = new TASK();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABOUT uc = new ABOUT();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LOGOUT uc = new LOGOUT();
            addUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DEL uc = new DEL();
            addUserControl(uc);
        }
    }
}
