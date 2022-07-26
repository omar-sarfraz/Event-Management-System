using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System.EventUC
{
    public partial class ViewEvents : UserControl
    {
        SqlConnection conn;
        public ViewEvents()
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

        private void Event_Load(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
