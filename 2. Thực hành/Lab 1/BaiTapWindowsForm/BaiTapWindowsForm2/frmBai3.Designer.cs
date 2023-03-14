namespace BaiTapWindowsForm2
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhGiaiThuaCuaN = new System.Windows.Forms.RadioButton();
            this.rdXemHoTen = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số nguyên dương n:";
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(170, 38);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(154, 20);
            this.tbHo.TabIndex = 3;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(170, 81);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(154, 20);
            this.tbTen.TabIndex = 4;
            // 
            // tbSoN
            // 
            this.tbSoN.Location = new System.Drawing.Point(170, 120);
            this.tbSoN.Name = "tbSoN";
            this.tbSoN.Size = new System.Drawing.Size(154, 20);
            this.tbSoN.TabIndex = 5;
            this.tbSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdXemHoTen);
            this.groupBox1.Controls.Add(this.rdTinhGiaiThuaCuaN);
            this.groupBox1.Location = new System.Drawing.Point(70, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn xử lý";
            // 
            // rdTinhGiaiThuaCuaN
            // 
            this.rdTinhGiaiThuaCuaN.AutoSize = true;
            this.rdTinhGiaiThuaCuaN.Location = new System.Drawing.Point(6, 63);
            this.rdTinhGiaiThuaCuaN.Name = "rdTinhGiaiThuaCuaN";
            this.rdTinhGiaiThuaCuaN.Size = new System.Drawing.Size(121, 17);
            this.rdTinhGiaiThuaCuaN.TabIndex = 1;
            this.rdTinhGiaiThuaCuaN.TabStop = true;
            this.rdTinhGiaiThuaCuaN.Text = "Tính giai thừa của n";
            this.rdTinhGiaiThuaCuaN.UseVisualStyleBackColor = true;
            // 
            // rdXemHoTen
            // 
            this.rdXemHoTen.AutoSize = true;
            this.rdXemHoTen.Checked = true;
            this.rdXemHoTen.Location = new System.Drawing.Point(6, 29);
            this.rdXemHoTen.Name = "rdXemHoTen";
            this.rdXemHoTen.Size = new System.Drawing.Size(94, 17);
            this.rdXemHoTen.TabIndex = 2;
            this.rdXemHoTen.TabStop = true;
            this.rdXemHoTen.Text = "Xem họ và tên";
            this.rdXemHoTen.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(76, 308);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(248, 23);
            this.btnXemKetQua.TabIndex = 7;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả là:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(160, 360);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(21, 20);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = "...";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSoN);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbHo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhGiaiThuaCuaN;
        private System.Windows.Forms.RadioButton rdXemHoTen;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}