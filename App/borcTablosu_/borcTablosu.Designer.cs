﻿
namespace App
{
    partial class borcTablosu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borcDefteriDataSet3 = new App.borcDefteriDataSet3();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.borckategorisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borcDefteriDataSet2 = new App.borcDefteriDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.borcDefteriDataSet = new App.borcDefteriDataSet();
            this.borcDefteriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borc_kategorisiTableAdapter = new App.borcDefteriDataSet2TableAdapters.borc_kategorisiTableAdapter();
            this.kullanicilarTableAdapter = new App.borcDefteriDataSet3TableAdapters.kullanicilarTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borckategorisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(605, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 129);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 36);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Açıklama";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(10, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.borcDefteriDataSet3;
            // 
            // borcDefteriDataSet3
            // 
            this.borcDefteriDataSet3.DataSetName = "borcDefteriDataSet3";
            this.borcDefteriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(10, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Hatırlat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.borckategorisiBindingSource;
            this.comboBox1.DisplayMember = "kategori";
            this.comboBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 92);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 27);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "ID";
            // 
            // borckategorisiBindingSource
            // 
            this.borckategorisiBindingSource.DataMember = "borc_kategorisi";
            this.borckategorisiBindingSource.DataSource = this.borcDefteriDataSet2;
            // 
            // borcDefteriDataSet2
            // 
            this.borcDefteriDataSet2.DataSetName = "borcDefteriDataSet2";
            this.borcDefteriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(647, 1088);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "En fazla borç alan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(647, 1151);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "ödeme tarihi en yakın olan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 1218);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "ödeme tarihi en yakın olan";
            // 
            // borcDefteriDataSet
            // 
            this.borcDefteriDataSet.DataSetName = "borcDefteriDataSet";
            this.borcDefteriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borcDefteriDataSetBindingSource
            // 
            this.borcDefteriDataSetBindingSource.DataSource = this.borcDefteriDataSet;
            this.borcDefteriDataSetBindingSource.Position = 0;
            // 
            // borc_kategorisiTableAdapter
            // 
            this.borc_kategorisiTableAdapter.ClearBeforeFill = true;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(193, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutar";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.kullanicilarBindingSource;
            this.listBox1.DisplayMember = "isim";
            this.listBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(193, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 23);
            this.listBox1.TabIndex = 15;
            this.listBox1.ValueMember = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 518);
            this.panel1.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.Location = new System.Drawing.Point(10, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 38);
            this.button4.TabIndex = 22;
            this.button4.Text = "Aldığı Tüm Borçlar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Detayları Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Borç Alan Kişi";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(704, 562);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(187, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(704, 591);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(187, 23);
            this.progressBar2.TabIndex = 24;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(704, 620);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(187, 23);
            this.progressBar3.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(601, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yemek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(601, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Yakıt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(601, 620);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Deterjan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(601, 652);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Diğer";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(704, 649);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(187, 23);
            this.progressBar4.TabIndex = 30;
            // 
            // borcTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 845);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "borcTablosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "borcTablosu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.borcTablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borckategorisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDefteriDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource borcDefteriDataSetBindingSource;
        private borcDefteriDataSet borcDefteriDataSet;
        private borcDefteriDataSet2 borcDefteriDataSet2;
        private System.Windows.Forms.BindingSource borckategorisiBindingSource;
        private borcDefteriDataSet2TableAdapters.borc_kategorisiTableAdapter borc_kategorisiTableAdapter;
        private borcDefteriDataSet3 borcDefteriDataSet3;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private borcDefteriDataSet3TableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button button4;
    }
}