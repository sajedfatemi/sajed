using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SupershopManagementSystem
{
    public partial class CashierMenuForm : Form
    {
        public CashierMenuForm()
        {
            InitializeComponent();
        }

        private void CashierMenuForm_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "Signed in as " + CurrentUser.FullName + " (Cashier)";
        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            PosForm form = new PosForm();
            form.ShowDialog();
        }

        private void buttonStockCheck_Click(object sender, EventArgs e)
        {
            StockCheckForm form = new StockCheckForm();
            form.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to log out?",
                "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                CurrentUser.LogOut();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }
    }
}
