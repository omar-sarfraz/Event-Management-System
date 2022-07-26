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
    public partial class WorkDetails : UserControl
    {
        SqlConnection conn;
        public WorkDetails()
        {
            InitializeComponent();
            conn = Program.Conn();

            dateTimePicker2.CustomFormat = "HH-mm-ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.ShowUpDown = true;

            dateTimePicker3.CustomFormat = "HH-mm-ss";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.ShowUpDown = true;

            populateDataGrid();
        }

        private void populateDataGrid()
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();

            conn.Open();            
            SqlCommand selectCommand = new SqlCommand("USE event_managment;SELECT work_details.event_id,event_name,work_details.employee_id,EMPLOYEE.employee_fname + ' ' + EMPLOYEE.employee_lname AS employee_name,assigned_work,work_date,employee_arrived,employee_left,employee_remarks,damage_by_employee FROM work_details JOIN EVENTT ON WORK_DETAILS.event_id = EVENTT.event_id JOIN Employee ON WORK_DETAILS.employee_id = Employee.employee_id;", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) , reader.GetDateTime(5).ToString("yyyy-MM-dd"), reader.GetTimeSpan(6), reader.GetTimeSpan(7), reader.GetString(8), reader.GetString(9));
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox7.Text == "" || textBox12.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("All fields other than assigned work, remarks and damage are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO work_details (event_id,employee_id,assigned_work,work_date,employee_arrived,employee_left,employee_remarks,damage_by_employee) VALUES (@event_id,@employee_id,@assigned_work,@work_date,@employee_arrived,@employee_left,@remarks,@damage)", conn);
                    insertCommand.Parameters.AddWithValue("@event_id", textBox7.Text);
                    insertCommand.Parameters.AddWithValue("@employee_id", textBox12.Text);
                    insertCommand.Parameters.AddWithValue("@assigned_work", textBox13.Text);
                    insertCommand.Parameters.AddWithValue("@work_date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("@employee_arrived", dateTimePicker2.Value.ToString("HH:mm:ss"));
                    insertCommand.Parameters.AddWithValue("@employee_left", dateTimePicker3.Value.ToString("HH:mm:ss"));
                    insertCommand.Parameters.AddWithValue("@remarks", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@damage", textBox1.Text);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox7.Text = String.Empty;
                    textBox12.Text = String.Empty;
                    textBox13.Text = String.Empty;
                    textBox2.Text = String.Empty;
                    textBox1.Text = String.Empty;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            conn.Close();

            populateDataGrid();
        }
    }
}
