using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_02
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left + 20;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCustomerReg_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerReg.Left + 28;

            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCheckOut.Left + 20;

            uC_CustomerCheckout1.Visible = true;
            uC_CustomerCheckout1.BringToFront();
        }

        private void btnCustomerDet_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDet.Left + 20;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left + 20;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
        }
    }
}
