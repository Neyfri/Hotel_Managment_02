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
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0 )
            {
                query = "SELECT C.cid, C.cname, C.mobile, C.nationality, C.gender, C.dob, C.idproof, C.adress, C.checkin,C.checkout, R.noRooom, R.roomType, R.bed, R.price FROM customer AS C INNER JOIN rooms AS R ON C.room_id = R.idRoom";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                query = "SELECT C.cid, C.cname, C.mobile, C.nationality, C.gender, C.dob, C.idproof, C.adress, C.checkin,C.checkout, R.noRooom, R.roomType, R.bed, R.price FROM customer AS C INNER JOIN rooms AS R ON C.room_id = R.idRoom WHERE checkout is NULL";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "SELECT C.cid, C.cname, C.mobile, C.nationality, C.gender, C.dob, C.idproof, C.adress, C.checkin,C.checkout, R.noRooom, R.roomType, R.bed, R.price FROM customer AS C INNER JOIN rooms AS R ON C.room_id = R.idRoom WHERE checkout is NOT NULL";
                getRecord(query);
            }
        }
        private void getRecord(string query)
        {
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
