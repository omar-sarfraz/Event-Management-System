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

namespace Event_Management_System.EmployeeUC
{
    public partial class DeleteEmployee : UserControl
    {
        SqlConnection conn;
        string ID;
        public DeleteEmployee()
        {
            conn = Program.Conn();
            InitializeComponent();
            populateDataGrid();
        }

        private void populateDataGrid()
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT employee_id, employee_fname +' '+ employee_lname AS Name, employee_cnic, employee_type, employee_contact1, employee_date_of_birth, employee_joining_date , employee_wage, employee_housenumber + ' ' + employee_area + ' ' + employee_city AS Address FROM Employee", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(4), reader.GetString(8), reader.GetInt32(7), reader.GetString(2), reader.GetString(3), reader.GetDateTime(5).ToString("yyyy-MM-dd"), reader.GetDateTime(6).ToString("yyyy-MM-dd"));
            }
            conn.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();

                conn.Open();
                SqlCommand selectCommand = new SqlCommand("USE event_managment; DELETE FROM EMPLOYEE WHERE employee_id = @ID", conn);
                selectCommand.Parameters.AddWithValue("@ID", ID);
                selectCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception exe)
            {
                conn.Close();
            }

            populateDataGrid();

        }
    }
}
