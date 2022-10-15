namespace Hotel_Management_02.All_User_Control
{
    partial class UC_CustomerCheckout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CustomerCheckout));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDateCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Check Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by Name";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(510, 117);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(267, 38);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDateCheckOut
            // 
            this.txtDateCheckOut.CheckedState.Parent = this.txtDateCheckOut;
            this.txtDateCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateCheckOut.HoverState.Parent = this.txtDateCheckOut;
            this.txtDateCheckOut.Location = new System.Drawing.Point(713, 530);
            this.txtDateCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDateCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDateCheckOut.Name = "txtDateCheckOut";
            this.txtDateCheckOut.ShadowDecoration.Parent = this.txtDateCheckOut;
            this.txtDateCheckOut.Size = new System.Drawing.Size(200, 36);
            this.txtDateCheckOut.TabIndex = 5;
            this.txtDateCheckOut.Value = new System.DateTime(2022, 10, 13, 15, 23, 43, 907);
            // 
            // txtCName
            // 
            this.txtCName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCName.DefaultText = "";
            this.txtCName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCName.DisabledState.Parent = this.txtCName;
            this.txtCName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCName.FocusedState.Parent = this.txtCName;
            this.txtCName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.ForeColor = System.Drawing.Color.Black;
            this.txtCName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCName.HoverState.Parent = this.txtCName;
            this.txtCName.Location = new System.Drawing.Point(49, 530);
            this.txtCName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCName.Name = "txtCName";
            this.txtCName.PasswordChar = '\0';
            this.txtCName.PlaceholderText = "";
            this.txtCName.ReadOnly = true;
            this.txtCName.SelectedText = "";
            this.txtCName.ShadowDecoration.Parent = this.txtCName;
            this.txtCName.Size = new System.Drawing.Size(267, 36);
            this.txtCName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.DefaultText = "";
            this.txtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.DisabledState.Parent = this.txtRoomNo;
            this.txtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.FocusedState.Parent = this.txtRoomNo;
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.HoverState.Parent = this.txtRoomNo;
            this.txtRoomNo.Location = new System.Drawing.Point(334, 530);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.PlaceholderText = "";
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.ShadowDecoration.Parent = this.txtRoomNo;
            this.txtRoomNo.Size = new System.Drawing.Size(267, 36);
            this.txtRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomNo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Room No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(709, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Check Out";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AllowToggling = false;
            this.btnCheckOut.AnimationSpeed = 200;
            this.btnCheckOut.AutoGenerateColors = false;
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BackColor1 = System.Drawing.Color.White;
            this.btnCheckOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.BackgroundImage")));
            this.btnCheckOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnCheckOut.ButtonText = "Check Out";
            this.btnCheckOut.ButtonTextMarginLeft = 0;
            this.btnCheckOut.ColorContrastOnClick = 45;
            this.btnCheckOut.ColorContrastOnHover = 45;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCheckOut.CustomizableEdges = borderEdges1;
            this.btnCheckOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCheckOut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheckOut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCheckOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.IconMarginLeft = 11;
            this.btnCheckOut.IconPadding = 10;
            this.btnCheckOut.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.IdleBorderColor = System.Drawing.Color.Black;
            this.btnCheckOut.IdleBorderRadius = 44;
            this.btnCheckOut.IdleBorderThickness = 1;
            this.btnCheckOut.IdleFillColor = System.Drawing.Color.White;
            this.btnCheckOut.IdleIconLeftImage = null;
            this.btnCheckOut.IdleIconRightImage = null;
            this.btnCheckOut.IndicateFocus = false;
            this.btnCheckOut.Location = new System.Drawing.Point(1212, 521);
            this.btnCheckOut.Name = "btnCheckOut";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 44;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnCheckOut.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 44;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnCheckOut.OnPressedState = stateProperties2;
            this.btnCheckOut.Size = new System.Drawing.Size(167, 45);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckOut.TextMarginLeft = 0;
            this.btnCheckOut.UseDefaultRadiusAndThickness = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 40;
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.Name = null;
            this.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(47, 190);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 40;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1332, 292);
            this.DataGridView1.TabIndex = 16;
            this.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // UC_CustomerCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateCheckOut);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_CustomerCheckout";
            this.Size = new System.Drawing.Size(1439, 646);
            this.Load += new System.EventHandler(this.UC_CustomerCheckout_Load);
            this.Leave += new System.EventHandler(this.UC_CustomerCheckout_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDateCheckOut;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCheckOut;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridView1;
    }
}
