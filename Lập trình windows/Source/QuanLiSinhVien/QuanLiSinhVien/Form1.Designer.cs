namespace QuanLiSinhVien
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbhoten = new System.Windows.Forms.TextBox();
			this.txbmssv = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.radnam = new System.Windows.Forms.RadioButton();
			this.radnu = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.datens = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.cbqq = new System.Windows.Forms.ComboBox();
			this.btnthem = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnthoat = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.datagridvewSV = new System.Windows.Forms.DataGridView();
			this.cbcn = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.datagridvewSV)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(358, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Sinh Viên";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(125, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ tên:";
			// 
			// txbhoten
			// 
			this.txbhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbhoten.Location = new System.Drawing.Point(206, 148);
			this.txbhoten.Name = "txbhoten";
			this.txbhoten.Size = new System.Drawing.Size(169, 30);
			this.txbhoten.TabIndex = 2;
			// 
			// txbmssv
			// 
			this.txbmssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbmssv.Location = new System.Drawing.Point(206, 96);
			this.txbmssv.Name = "txbmssv";
			this.txbmssv.Size = new System.Drawing.Size(169, 30);
			this.txbmssv.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(125, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "MSSV:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(112, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Giới tính:";
			// 
			// radnam
			// 
			this.radnam.AutoSize = true;
			this.radnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radnam.Location = new System.Drawing.Point(206, 205);
			this.radnam.Name = "radnam";
			this.radnam.Size = new System.Drawing.Size(71, 29);
			this.radnam.TabIndex = 5;
			this.radnam.TabStop = true;
			this.radnam.Text = "Nam";
			this.radnam.UseVisualStyleBackColor = true;
			// 
			// radnu
			// 
			this.radnu.AutoSize = true;
			this.radnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radnu.Location = new System.Drawing.Point(304, 205);
			this.radnu.Name = "radnu";
			this.radnu.Size = new System.Drawing.Size(55, 29);
			this.radnu.TabIndex = 6;
			this.radnu.TabStop = true;
			this.radnu.Text = "Nữ";
			this.radnu.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(481, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Ngày sinh:";
			// 
			// datens
			// 
			this.datens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datens.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.datens.Location = new System.Drawing.Point(592, 96);
			this.datens.Name = "datens";
			this.datens.Size = new System.Drawing.Size(169, 30);
			this.datens.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(481, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 25);
			this.label6.TabIndex = 10;
			this.label6.Text = "Quê quán:";
			// 
			// cbqq
			// 
			this.cbqq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbqq.FormattingEnabled = true;
			this.cbqq.Location = new System.Drawing.Point(593, 148);
			this.cbqq.Name = "cbqq";
			this.cbqq.Size = new System.Drawing.Size(168, 28);
			this.cbqq.TabIndex = 4;
			// 
			// btnthem
			// 
			this.btnthem.BackColor = System.Drawing.Color.Black;
			this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthem.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnthem.Location = new System.Drawing.Point(193, 285);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(97, 34);
			this.btnthem.TabIndex = 7;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseVisualStyleBackColor = false;
			// 
			// btnxoa
			// 
			this.btnxoa.BackColor = System.Drawing.Color.Black;
			this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxoa.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnxoa.Location = new System.Drawing.Point(500, 285);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(97, 34);
			this.btnxoa.TabIndex = 9;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = false;
			// 
			// btnthoat
			// 
			this.btnthoat.BackColor = System.Drawing.Color.Black;
			this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthoat.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnthoat.Location = new System.Drawing.Point(653, 285);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(97, 34);
			this.btnthoat.TabIndex = 10;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = false;
			// 
			// btnsua
			// 
			this.btnsua.BackColor = System.Drawing.Color.Black;
			this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsua.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnsua.Location = new System.Drawing.Point(343, 285);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(97, 34);
			this.btnsua.TabIndex = 8;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = false;
			// 
			// datagridvewSV
			// 
			this.datagridvewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagridvewSV.Location = new System.Drawing.Point(0, 363);
			this.datagridvewSV.Name = "datagridvewSV";
			this.datagridvewSV.Size = new System.Drawing.Size(986, 262);
			this.datagridvewSV.TabIndex = 16;
			// 
			// cbcn
			// 
			this.cbcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbcn.FormattingEnabled = true;
			this.cbcn.Location = new System.Drawing.Point(593, 208);
			this.cbcn.Name = "cbcn";
			this.cbcn.Size = new System.Drawing.Size(168, 28);
			this.cbcn.TabIndex = 17;
			this.cbcn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(521, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 25);
			this.label7.TabIndex = 18;
			this.label7.Text = "Khoa:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(983, 626);
			this.Controls.Add(this.cbcn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.datagridvewSV);
			this.Controls.Add(this.btnsua);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btnthem);
			this.Controls.Add(this.cbqq);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.datens);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.radnu);
			this.Controls.Add(this.radnam);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txbmssv);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txbhoten);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.datagridvewSV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbhoten;
		private System.Windows.Forms.TextBox txbmssv;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radnam;
		private System.Windows.Forms.RadioButton radnu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker datens;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbqq;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btnthoat;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.DataGridView datagridvewSV;
		private System.Windows.Forms.ComboBox cbcn;
		private System.Windows.Forms.Label label7;
	}
}

