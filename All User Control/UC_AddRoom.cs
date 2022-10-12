using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_02.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtBed.Text != String.Empty && txtPrice.Text != String.Empty && txtRoomNo.Text != String.Empty && txtType.Text != String.Empty)
            {
                string roomno = txtRoomNo.Text;
                string type = txtType.Text;
                string bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (noRooom, roomType, bed, price) values('" + roomno + "','" + type + "','" + bed + "','" + price + "')";
                fn.setData(query, "Room Added.");

                UC_AddRoom_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            txtPrice.Clear();
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
