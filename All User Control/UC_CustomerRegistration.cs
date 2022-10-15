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

namespace Hotel_Management_02.All_User_Control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            query = "SELECT noRooom FROM rooms WHERE bed = '"+txtBed.Text+"' AND roomType = '"+txtRoomType.Text+"' AND booked = 'NO' ";
            setComboBox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
        }
        int rid;

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT price, idRoom from rooms WHERE noRooom LIKE '"+txtRoomNo.Text+"'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }
        public void ClearAll()
        {
            txtRoomNo.Items.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtGender.SelectedIndex = 1;
            txtAddress.Clear();
            txtDoB.ResetText();
            txtCheckin.ResetText();
            txtIdProof.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtNationality.Clear();
            txtPrice.Clear();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnAllocate_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDoB.Text != "" && txtAddress.Text != "" && txtBed.Text != "" && txtCheckin.Text != "" && txtIdProof.Text != "" && txtMobile.Text != "" && txtPrice.Text != "" && txtPrice.Text != "" && txtRoomNo.Text != "" && txtRoomType.Text != "")
            {
                string name = txtName.Text;
                string mobile = txtMobile.Text;
                string national = txtNationality.Text;
                string gender = txtGender.Text;
                string dob = txtDoB.Text;
                string idproof = txtIdProof.Text;
                string address = txtAddress.Text;
                string checking = txtCheckin.Text;

                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, adress, checkin, room_id) values('" + name + "','" + mobile + "','" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checking + "','" + rid + "') update rooms set booked ='YES' where noRooom = '" + txtRoomNo.Text + "' ";
                fn.setData(query, "Room Number " + txtRoomNo.Text + " Allocation Successful");
                ClearAll();
            }
            else
            {
                MessageBox.Show("All Fields are mandatory", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
