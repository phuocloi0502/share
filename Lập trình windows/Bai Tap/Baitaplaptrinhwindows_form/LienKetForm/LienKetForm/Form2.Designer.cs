namespace LienKetForm
{
    partial class Form2
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
            this.txbhotendanhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbtk = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btnvt = new System.Windows.Forms.Button();
            this.txbvt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbhotendanhap
            // 
            this.txbhotendanhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbhotendanhap.Location = new System.Drawing.Point(39, 69);
            this.txbhotendanhap.Name = "txbhotendanhap";
            this.txbhotendanhap.Size = new System.Drawing.Size(238, 26);
            this.txbhotendanhap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên bạn vừa nhâp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập kí tự cần tìm:";
            // 
            // txbtk
            // 
            this.txbtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtk.Location = new System.Drawing.Point(39, 173);
            this.txbtk.Name = "txbtk";
            this.txbtk.Size = new System.Drawing.Size(125, 26);
            this.txbtk.TabIndex = 6;
            this.txbtk.TextChanged += new System.EventHandler(this.txbtk_TextChanged);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(202, 173);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 7;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnvt
            // 
            this.btnvt.Location = new System.Drawing.Point(297, 173);
            this.btnvt.Name = "btnvt";
            this.btnvt.Size = new System.Drawing.Size(75, 23);
            this.btnvt.TabIndex = 8;
            this.btnvt.Text = "Vị trí";
            this.btnvt.UseVisualStyleBackColor = true;
            // 
            // txbvt
            // 
            this.txbvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbvt.Location = new System.Drawing.Point(39, 220);
            this.txbvt.Name = "txbvt";
            this.txbvt.Size = new System.Drawing.Size(238, 26);
            this.txbvt.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(460, 301);
            this.Controls.Add(this.txbvt);
            this.Controls.Add(this.btnvt);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txbtk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbhotendanhap);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbhotendanhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbtk;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnvt;
        private System.Windows.Forms.TextBox txbvt;
    }
}