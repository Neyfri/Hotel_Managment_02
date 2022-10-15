using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Management_02.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSearchID.Text != "")
            {
                if (MessageBox.Show("Are You Sure","Confirmation..!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "DELETE FROM employee WHERE eid LIKE '"+txtSearchID.Text+"'";
                    fn.setData(query,"Employee Deleted");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text != "" && txtMobile.Text !="" && txtGender.Text != "" && txtEmail.Text != "")
            {
                string name = txtName.Text;
                string password = txtPassword.Text;
                string username = txtUsername.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;

                query = "INSERT INTO employee(ename, mobile, gender, emailid, username, pass) VALUES('"+name+"','"+mobile+"','"+gender+"','"+email+"','"+username+"','"+password+"')";
                fn.setData(query,"Employee Registered.");
                ClearAll();
                UC_Employee_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill all Fields.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                getEmployee(DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                getEmployee(DataGridView2);
                UC_Employee_Load(this, null);
            }
        }
        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tabEmployee_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void getMaxID()
        {
            query = "SELECT MAX(eid) FROM employee";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lblID.Text = (num + 1).ToString();
            }
        }
        private void ClearAll()
        {
            txtEmail.Clear();
            txtGender.SelectedIndex = -1;
            txtMobile.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }
        public void getEmployee(DataGridView dgv)
        {
            query = "SELECT * FROM employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView2.Rows[e.RowIndex].Cells[0].Value != null)
            txtSearchID.Text = DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
