using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_02
{
    public partial class FRM_Splash : Form
    {
        public FRM_Splash()
        {
            InitializeComponent();
        }

        private void FRM_Splash_Load(object sender, EventArgs e)
        {
            panel2.Width = 0;
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                panel2.Width += 6;
                Thread.Sleep(20);
            }
            Timer1.Stop();
            Login lg = new Login();
            lg.ShowDialog();
            this.Hide();
        }
    }
}
