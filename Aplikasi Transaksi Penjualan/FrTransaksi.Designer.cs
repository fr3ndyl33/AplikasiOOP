﻿namespace Aplikasi_Transaksi_Penjualan
{
    partial class FrTransaksi
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
            this.lbltanggal = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.waktu = new System.Windows.Forms.Label();
            this.lblwaktu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidkasir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buka = new System.Windows.Forms.Button();
            this.selectmenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltanggal
            // 
            this.lbltanggal.AutoSize = true;
            this.lbltanggal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltanggal.Location = new System.Drawing.Point(13, 13);
            this.lbltanggal.Name = "lbltanggal";
            this.lbltanggal.Size = new System.Drawing.Size(56, 20);
            this.lbltanggal.TabIndex = 0;
            this.lbltanggal.Text = "Tanggal";
            this.lbltanggal.Click += new System.EventHandler(this.label1_Click);
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(70, 13);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(0, 20);
            this.tanggal.TabIndex = 1;
            // 
            // waktu
            // 
            this.waktu.AutoSize = true;
            this.waktu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waktu.Location = new System.Drawing.Point(639, 13);
            this.waktu.Name = "waktu";
            this.waktu.Size = new System.Drawing.Size(0, 20);
            this.waktu.TabIndex = 3;
            this.waktu.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblwaktu
            // 
            this.lblwaktu.AutoSize = true;
            this.lblwaktu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaktu.Location = new System.Drawing.Point(590, 13);
            this.lblwaktu.Name = "lblwaktu";
            this.lblwaktu.Size = new System.Drawing.Size(43, 20);
            this.lblwaktu.TabIndex = 2;
            this.lblwaktu.Text = "Waktu";
            this.lblwaktu.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kasir :";
            // 
            // lblidkasir
            // 
            this.lblidkasir.AutoSize = true;
            this.lblidkasir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidkasir.Location = new System.Drawing.Point(70, 50);
            this.lblidkasir.Name = "lblidkasir";
            this.lblidkasir.Size = new System.Drawing.Size(0, 20);
            this.lblidkasir.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Member ID";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(594, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 358);
            this.dataGridView1.TabIndex = 8;
            // 
            // buka
            // 
            this.buka.Location = new System.Drawing.Point(444, 91);
            this.buka.Name = "buka";
            this.buka.Size = new System.Drawing.Size(273, 32);
            this.buka.TabIndex = 9;
            this.buka.Text = "Tambah";
            this.buka.UseVisualStyleBackColor = true;
            this.buka.Click += new System.EventHandler(this.buka_Click);
            // 
            // selectmenu
            // 
            this.selectmenu.FormattingEnabled = true;
            this.selectmenu.Location = new System.Drawing.Point(138, 96);
            this.selectmenu.Name = "selectmenu";
            this.selectmenu.Size = new System.Drawing.Size(121, 21);
            this.selectmenu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pilih Menu";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(358, 96);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // FrTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectmenu);
            this.Controls.Add(this.buka);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblidkasir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waktu);
            this.Controls.Add(this.lblwaktu);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.lbltanggal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrTransaksi";
            this.Load += new System.EventHandler(this.FrTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltanggal;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label waktu;
        private System.Windows.Forms.Label lblwaktu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidkasir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buka;
        private System.Windows.Forms.ComboBox selectmenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}