using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System.EventUC
{
    public partial class Event : UserControl
    {
        public Event()
        {
            InitializeComponent();
            AddEvent uc = new AddEvent();
            addUserControls(uc);
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            AddEvent uc = new AddEvent();
            addUserControls(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ViewEvents uc = new ViewEvents();
            addUserControls(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateEvent uc = new UpdateEvent();
            addUserControls(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DeleteEvent uc = new DeleteEvent();
            addUserControls(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
