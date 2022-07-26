using Event_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Dashboard uc = new Dashboard();
            addUserControls(uc);
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            Credits uc = new Credits();
            addUserControls(uc);
        }

        private void Exit_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoardButton_Click_1(object sender, EventArgs e)
        {
            Dashboard uc = new Dashboard();
            addUserControls(uc);
        }

        private void EventsButton_Click_1(object sender, EventArgs e)
        {
            EventsButton.Enabled = true;
            EventUC.Event uc = new EventUC.Event();
            addUserControls(uc);
        }

        private void ItemsUsed_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            ItemUsed uc = new ItemUsed();
            addUserControls(uc);
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            Customers uc = new Customers();
            addUserControls(uc);
        }

        private void StockItems_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            StockItem uc = new StockItem();
            addUserControls(uc);
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            Employee uc = new Employee();
            addUserControls(uc);
        }

        private void WorkDetails_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            WorkDetails uc = new WorkDetails();
            addUserControls(uc);
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            Supplier uc = new Supplier();
            addUserControls(uc);
        }

        private void SuppliedItems_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            SuppliedItemsReceipt uc = new SuppliedItemsReceipt();
            addUserControls(uc);
        }

        private void ItemsAvailible_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            AvailibleItemsList uc = new AvailibleItemsList();
            addUserControls(uc);
        }
    }
}
