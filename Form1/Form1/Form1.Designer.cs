namespace Form1
{
    partial class Form1
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
            this.lblHovaten = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.datetime_FormHS = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.gvThongtinHS = new System.Windows.Forms.DataGridView();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblNgaythangnamsinh = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btn_F5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongtinHS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHovaten
            // 
            this.lblHovaten.AutoSize = true;
            this.lblHovaten.Location = new System.Drawing.Point(64, 125);
            this.lblHovaten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHovaten.Name = "lblHovaten";
            this.lblHovaten.Size = new System.Drawing.Size(84, 20);
            this.lblHovaten.TabIndex = 0;
            this.lblHovaten.Text = "lblHovaten";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(64, 189);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(68, 20);
            this.lblDiachi.TabIndex = 1;
            this.lblDiachi.Text = "lblDiachi";
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(236, 120);
            this.txtHovaten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(148, 26);
            this.txtHovaten.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(236, 185);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(148, 26);
            this.txtDiachi.TabIndex = 3;
            // 
            // datetime_FormHS
            // 
            this.datetime_FormHS.CustomFormat = "dd/mm/yy";
            this.datetime_FormHS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_FormHS.Location = new System.Drawing.Point(236, 322);
            this.datetime_FormHS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datetime_FormHS.Name = "datetime_FormHS";
            this.datetime_FormHS.Size = new System.Drawing.Size(298, 26);
            this.datetime_FormHS.TabIndex = 4;
            this.datetime_FormHS.Value = new System.DateTime(2024, 1, 9, 0, 0, 0, 0);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 589);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "btnThem";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // gvThongtinHS
            // 
            this.gvThongtinHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThongtinHS.Location = new System.Drawing.Point(610, 125);
            this.gvThongtinHS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvThongtinHS.Name = "gvThongtinHS";
            this.gvThongtinHS.RowHeadersWidth = 62;
            this.gvThongtinHS.Size = new System.Drawing.Size(536, 471);
            this.gvThongtinHS.TabIndex = 6;
            this.gvThongtinHS.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvThongtinHS_CellContentDoubleClick);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(236, 246);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(148, 26);
            this.txtCMND.TabIndex = 8;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(64, 251);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(71, 20);
            this.lblCMND.TabIndex = 7;
            this.lblCMND.Text = "lblCMND";
            // 
            // lblNgaythangnamsinh
            // 
            this.lblNgaythangnamsinh.AutoSize = true;
            this.lblNgaythangnamsinh.Location = new System.Drawing.Point(64, 322);
            this.lblNgaythangnamsinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaythangnamsinh.Name = "lblNgaythangnamsinh";
            this.lblNgaythangnamsinh.Size = new System.Drawing.Size(146, 20);
            this.lblNgaythangnamsinh.TabIndex = 9;
            this.lblNgaythangnamsinh.Text = "Ngaythangnamsinh";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(258, 589);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(442, 589);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "btnSua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btn_F5
            // 
            this.btn_F5.Location = new System.Drawing.Point(69, 516);
            this.btn_F5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_F5.Name = "btn_F5";
            this.btn_F5.Size = new System.Drawing.Size(112, 35);
            this.btn_F5.TabIndex = 12;
            this.btn_F5.Text = "F5";
            this.btn_F5.UseVisualStyleBackColor = true;
            this.btn_F5.Click += new System.EventHandler(this.btn_F5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_F5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblNgaythangnamsinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.gvThongtinHS);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.datetime_FormHS);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblHovaten);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThongtinHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHovaten;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.DateTimePicker datetime_FormHS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gvThongtinHS;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblNgaythangnamsinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btn_F5;
    }
}

