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
    public partial class UC_CustomerCheckout : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerCheckout()
        {
            InitializeComponent();
        }

        private void UC_CustomerCheckout_Load(object sender, EventArgs e)
        {
            query = "SELECT C.cid, C.cname, C.mobile, C.nationality, C.gender, C.dob, C.idproof, C.adress, C.checkin, R.noRooom, R.roomType, R.bed, R.price FROM customer AS C INNER JOIN rooms AS R ON C.room_id = R.idRoom WHERE chekout LIKE 'NO'";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT C.cid, C.cname, C.mobile, C.nationality, C.gender, C.dob, C.idproof, C.adress, C.checkin, R.noRooom, R.roomType, R.bed, R.price FROM customer AS C INNER JOIN rooms AS R ON C.room_id = R.idRoom WHERE cname LIKE '"+txtName.Text+"%' AND chekout = 'NO'";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNo.Text = DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Are You Sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string cdate = txtDateCheckOut.Text;
                    query = "UPDATE customer SET chekout = 'YES', checkout = '"+cdate+"' WHERE cid = '"+id+"' UPDATE rooms SET booked = 'NO' WHERE noRooom = '"+txtRoomNo.Text+"'";
                    fn.setData(query,"Check Out Successfully!");
                    UC_CustomerCheckout_Load(this, null);
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected.","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
            txtDateCheckOut.ResetText();
        }

        private void UC_CustomerCheckout_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
