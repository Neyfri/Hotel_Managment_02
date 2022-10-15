namespace Hotel_Management_02
{
    partial class FRM_Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse1
            // 
            this.Elipse1.BorderRadius = 200;
            this.Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(98, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 46);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 40);
            this.panel2.TabIndex = 2;
            // 
            // Elipse2
            // 
            this.Elipse2.BorderRadius = 50;
            this.Elipse2.TargetControl = this.panel1;
            // 
            // Elipse3
            // 
            this.Elipse3.BorderRadius = 50;
            this.Elipse3.TargetControl = this.panel2;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 67);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thank You";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 67);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome";
            // 
            // FRM_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(762, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FRM_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Splash";
            this.Load += new System.EventHandler(this.FRM_Splash_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse Elipse3;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}