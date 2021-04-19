namespace Kalkulator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bil1 = new System.Windows.Forms.TextBox();
            this.txt_bil2 = new System.Windows.Forms.TextBox();
            this.txt_hasil = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_kali = new System.Windows.Forms.Button();
            this.btn_bagi = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilangan 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bilangan 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // txt_bil1
            // 
            this.txt_bil1.Location = new System.Drawing.Point(110, 40);
            this.txt_bil1.Name = "txt_bil1";
            this.txt_bil1.Size = new System.Drawing.Size(167, 20);
            this.txt_bil1.TabIndex = 4;
            // 
            // txt_bil2
            // 
            this.txt_bil2.Location = new System.Drawing.Point(110, 69);
            this.txt_bil2.Name = "txt_bil2";
            this.txt_bil2.Size = new System.Drawing.Size(167, 20);
            this.txt_bil2.TabIndex = 5;
            // 
            // txt_hasil
            // 
            this.txt_hasil.Enabled = false;
            this.txt_hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasil.Location = new System.Drawing.Point(110, 99);
            this.txt_hasil.Name = "txt_hasil";
            this.txt_hasil.Size = new System.Drawing.Size(167, 20);
            this.txt_hasil.TabIndex = 6;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(42, 150);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 42);
            this.btn_tambah.TabIndex = 7;
            this.btn_tambah.Text = "+";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kurang.Location = new System.Drawing.Point(125, 150);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(75, 42);
            this.btn_kurang.TabIndex = 8;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_kali
            // 
            this.btn_kali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kali.Location = new System.Drawing.Point(42, 207);
            this.btn_kali.Name = "btn_kali";
            this.btn_kali.Size = new System.Drawing.Size(75, 42);
            this.btn_kali.TabIndex = 9;
            this.btn_kali.Text = "X";
            this.btn_kali.UseVisualStyleBackColor = true;
            this.btn_kali.Click += new System.EventHandler(this.btn_kali_Click);
            // 
            // btn_bagi
            // 
            this.btn_bagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bagi.Location = new System.Drawing.Point(125, 207);
            this.btn_bagi.Name = "btn_bagi";
            this.btn_bagi.Size = new System.Drawing.Size(75, 42);
            this.btn_bagi.TabIndex = 10;
            this.btn_bagi.Text = "/";
            this.btn_bagi.UseVisualStyleBackColor = true;
            this.btn_bagi.Click += new System.EventHandler(this.btn_bagi_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(207, 150);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 99);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 282);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_bagi);
            this.Controls.Add(this.btn_kali);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.txt_hasil);
            this.Controls.Add(this.txt_bil2);
            this.Controls.Add(this.txt_bil1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator Genju";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bil1;
        private System.Windows.Forms.TextBox txt_bil2;
        private System.Windows.Forms.TextBox txt_hasil;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_kali;
        private System.Windows.Forms.Button btn_bagi;
        private System.Windows.Forms.Button btn_clear;
    }
}

