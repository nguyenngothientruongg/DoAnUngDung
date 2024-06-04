namespace DoAn_QLBONGDAEURO
{
    partial class TraCuu
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
            this.tbTuKhoa = new System.Windows.Forms.TextBox();
            this.cbbChon = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTuKhoa
            // 
            this.tbTuKhoa.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuKhoa.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbTuKhoa.Location = new System.Drawing.Point(36, 22);
            this.tbTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.tbTuKhoa.Name = "tbTuKhoa";
            this.tbTuKhoa.Size = new System.Drawing.Size(313, 41);
            this.tbTuKhoa.TabIndex = 1;
            this.tbTuKhoa.Text = "Từ Khoá";
            this.tbTuKhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbChon
            // 
            this.cbbChon.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbbChon.FormattingEnabled = true;
            this.cbbChon.Items.AddRange(new object[] {
            "Đội bóng",
            "Cầu Thủ",
            "Trọng tài",
            "Sân",
            "Kết quả trận đấu",
            "Lịch thi đấu"});
            this.cbbChon.Location = new System.Drawing.Point(415, 22);
            this.cbbChon.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChon.Name = "cbbChon";
            this.cbbChon.Size = new System.Drawing.Size(180, 42);
            this.cbbChon.TabIndex = 2;
            this.cbbChon.Text = "       Chọn";
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.DarkRed;
            this.btTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btTim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.Color.White;
            this.btTim.Location = new System.Drawing.Point(638, 22);
            this.btTim.Margin = new System.Windows.Forms.Padding(4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(181, 48);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(998, 518);
            this.dataGridView1.TabIndex = 4;
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 766);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.cbbChon);
            this.Controls.Add(this.tbTuKhoa);
            this.Name = "TraCuu";
            this.Text = "TraCuu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTuKhoa;
        private System.Windows.Forms.ComboBox cbbChon;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}