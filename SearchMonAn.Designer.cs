namespace ttltnet
{
    partial class SearchMonAn
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
            this.mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamon,
            this.tenmon,
            this.gia});
            this.dataGridView1.Location = new System.Drawing.Point(49, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 149);
            this.dataGridView1.TabIndex = 25;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Controls.Add(this.rd2);
            this.groupBox1.Controls.Add(this.rd1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(88, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 191);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM MÓN ĂN";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(519, 132);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(83, 38);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(293, 132);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(83, 38);
            this.btntim.TabIndex = 9;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(293, 87);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(309, 22);
            this.txt_timkiem.TabIndex = 8;
            this.txt_timkiem.UseWaitCursor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(531, 41);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(77, 20);
            this.rd3.TabIndex = 7;
            this.rd3.TabStop = true;
            this.rd3.Text = "Mức Giá";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(387, 41);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(81, 20);
            this.rd2.TabIndex = 6;
            this.rd2.TabStop = true;
            this.rd2.Text = "Tên Món";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(245, 41);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(76, 20);
            this.rd1.TabIndex = 5;
            this.rd1.TabStop = true;
            this.rd1.Text = "Mã Món";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nội dung tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm theo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(354, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "TÌM KIẾM MÓN ĂN";
            // 
            // SearchMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SearchMonAn";
            this.Text = "SearchMonAn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}