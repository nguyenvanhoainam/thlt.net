namespace ttltnet
{
    partial class Thongkedoanhthu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhThuBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThang,
            this.doanhThuBan,
            this.chiPhiNhap,
            this.loiNhuan});
            this.dataGridView1.Location = new System.Drawing.Point(292, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(534, 162);
            this.dataGridView1.TabIndex = 20;
            // 
            // maThang
            // 
            this.maThang.DataPropertyName = "maThang";
            this.maThang.HeaderText = "Tháng";
            this.maThang.Name = "maThang";
            // 
            // doanhThuBan
            // 
            this.doanhThuBan.DataPropertyName = "doanhThuBan";
            this.doanhThuBan.HeaderText = "Doanh thu bán";
            this.doanhThuBan.Name = "doanhThuBan";
            // 
            // chiPhiNhap
            // 
            this.chiPhiNhap.DataPropertyName = "chiPhiNhap";
            this.chiPhiNhap.HeaderText = "Chi phí nhập";
            this.chiPhiNhap.Name = "chiPhiNhap";
            // 
            // loiNhuan
            // 
            this.loiNhuan.DataPropertyName = "loiNhuan";
            this.loiNhuan.HeaderText = "Lợi nhuận";
            this.loiNhuan.Name = "loiNhuan";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(484, 195);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(138, 43);
            this.btntinh.TabIndex = 19;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Từ tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "DOANH THU";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(253, 123);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 21;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(674, 123);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "đến tháng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Thongkedoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Thongkedoanhthu";
            this.Text = "Thongke";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhThuBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn loiNhuan;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}