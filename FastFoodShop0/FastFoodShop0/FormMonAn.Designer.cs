﻿namespace FastFoodShop0
{
    partial class FormMonAn
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
            this.btntk = new System.Windows.Forms.Button();
            this.btn_img = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_tenmon = new System.Windows.Forms.TextBox();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(833, 331);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 42);
            this.btntk.TabIndex = 56;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btn_img
            // 
            this.btn_img.Location = new System.Drawing.Point(397, 334);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(83, 30);
            this.btn_img.TabIndex = 55;
            this.btn_img.Text = "Chọn Ảnh";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(833, 274);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 38);
            this.btnthoat.TabIndex = 54;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(833, 210);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 43);
            this.btnxoa.TabIndex = 53;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(833, 146);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 40);
            this.btnsua.TabIndex = 52;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(833, 78);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 44);
            this.btnthem.TabIndex = 51;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamon,
            this.tenmon,
            this.gia});
            this.dataGridView1.Location = new System.Drawing.Point(111, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 189);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mamon
            // 
            this.mamon.DataPropertyName = "mamon";
            this.mamon.HeaderText = "Mã Món";
            this.mamon.MinimumWidth = 6;
            this.mamon.Name = "mamon";
            this.mamon.Width = 250;
            // 
            // tenmon
            // 
            this.tenmon.DataPropertyName = "tenmon";
            this.tenmon.HeaderText = "Tên Món";
            this.tenmon.MinimumWidth = 6;
            this.tenmon.Name = "tenmon";
            this.tenmon.Width = 250;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 250;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(600, 334);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(201, 22);
            this.txt_gia.TabIndex = 49;
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.Location = new System.Drawing.Point(600, 210);
            this.txt_tenmon.Name = "txt_tenmon";
            this.txt_tenmon.Size = new System.Drawing.Size(201, 22);
            this.txt_tenmon.TabIndex = 48;
            // 
            // txt_mamon
            // 
            this.txt_mamon.Location = new System.Drawing.Point(600, 92);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(201, 22);
            this.txt_mamon.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ảnh Minh Họa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên Món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã Món:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FormMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 606);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btn_img);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_tenmon);
            this.Controls.Add(this.txt_mamon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMonAn";
            this.Text = "FormMonAn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_tenmon;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}