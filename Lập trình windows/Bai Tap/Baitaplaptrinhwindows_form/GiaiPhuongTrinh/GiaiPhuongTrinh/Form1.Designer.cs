namespace GiaiPhuongTrinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radb1 = new System.Windows.Forms.RadioButton();
            this.radb2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txba = new System.Windows.Forms.TextBox();
            this.txbb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbkq = new System.Windows.Forms.TextBox();
            this.btngiai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radb2);
            this.groupBox1.Controls.Add(this.radb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // radb1
            // 
            this.radb1.AutoSize = true;
            this.radb1.Location = new System.Drawing.Point(63, 25);
            this.radb1.Name = "radb1";
            this.radb1.Size = new System.Drawing.Size(193, 24);
            this.radb1.TabIndex = 0;
            this.radb1.TabStop = true;
            this.radb1.Text = "Giải phương trình Bậc 1";
            this.radb1.UseVisualStyleBackColor = true;
            this.radb1.CheckedChanged += new System.EventHandler(this.radb1_CheckedChanged);
            // 
            // radb2
            // 
            this.radb2.AutoSize = true;
            this.radb2.Location = new System.Drawing.Point(63, 55);
            this.radb2.Name = "radb2";
            this.radb2.Size = new System.Drawing.Size(193, 24);
            this.radb2.TabIndex = 1;
            this.radb2.TabStop = true;
            this.radb2.Text = "Giải phương trình Bậc 2";
            this.radb2.UseVisualStyleBackColor = true;
            this.radb2.CheckedChanged += new System.EventHandler(this.radb2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a:";
            // 
            // txba
            // 
            this.txba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txba.Location = new System.Drawing.Point(111, 256);
            this.txba.Name = "txba";
            this.txba.Size = new System.Drawing.Size(105, 23);
            this.txba.TabIndex = 3;
            // 
            // txbb
            // 
            this.txbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbb.Location = new System.Drawing.Point(111, 299);
            this.txbb.Name = "txbb";
            this.txbb.Size = new System.Drawing.Size(105, 23);
            this.txbb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập b:";
            // 
            // txbc
            // 
            this.txbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbc.Location = new System.Drawing.Point(111, 346);
            this.txbc.Name = "txbc";
            this.txbc.Size = new System.Drawing.Size(105, 23);
            this.txbc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kết quả:";
            // 
            // txbkq
            // 
            this.txbkq.Enabled = false;
            this.txbkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbkq.Location = new System.Drawing.Point(111, 395);
            this.txbkq.Name = "txbkq";
            this.txbkq.Size = new System.Drawing.Size(303, 23);
            this.txbkq.TabIndex = 9;
            // 
            // btngiai
            // 
            this.btngiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiai.Location = new System.Drawing.Point(327, 233);
            this.btngiai.Name = "btngiai";
            this.btngiai.Size = new System.Drawing.Size(87, 69);
            this.btngiai.TabIndex = 10;
            this.btngiai.Text = "Giải";
            this.btngiai.UseVisualStyleBackColor = true;
            this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(327, 330);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 36);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(480, 462);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btngiai);
            this.Controls.Add(this.txbkq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radb2;
        private System.Windows.Forms.RadioButton radb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txba;
        private System.Windows.Forms.TextBox txbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbkq;
        private System.Windows.Forms.Button btngiai;
        private System.Windows.Forms.Button btnthoat;
    }
}

