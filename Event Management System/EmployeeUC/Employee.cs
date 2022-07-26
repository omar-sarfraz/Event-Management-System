using Event_Management_System.EmployeeUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class Employee : UserControl
    {
        SqlConnection conn;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            conn = Program.Conn();
            AddEmployee uc = new AddEmployee();
            addUserControls(uc);
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            AddEmployee uc = new AddEmployee();
            addUserControls(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ViewEmployee uc = new ViewEmployee();
            addUserControls(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DeleteEmployee uc = new DeleteEmployee();
            addUserControls(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateEmployee uc = new UpdateEmployee();
            addUserControls(uc);
        }
    }
}
