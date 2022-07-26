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

namespace Event_Management_System.EventUC
{
    public partial class DeleteEvent : UserControl
    {
        SqlConnection conn;
        string ID;
        public DeleteEvent()
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
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT * FROM EVENTT", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetDateTime(7).ToString("yyyy-MM-dd"), reader.GetTimeSpan(8), reader.GetTimeSpan(9), reader.GetString(10), reader.GetString(11), reader.GetString(1));
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
                SqlCommand selectCommand = new SqlCommand("USE event_managment; DELETE FROM EVENTT WHERE event_id = @ID", conn);
                selectCommand.Parameters.AddWithValue("@ID", ID);
                selectCommand.ExecuteNonQuery();

                conn.Close();
            } catch (Exception exe)
            {
                conn.Close();
            }

            populateDataGrid();
        }
    }
}
