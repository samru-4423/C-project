﻿namespace HOMEPAGE
{
    partial class TRANSACTION
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1125, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1085, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "card Number";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox10.Location = new System.Drawing.Point(292, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(164, 22);
            this.textBox10.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bkash",
            "Nagod",
            "Upay",
            "Card"});
            this.comboBox1.Location = new System.Drawing.Point(7, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 24);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.Text = "PAYMENT";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1215, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 25);
            this.button3.TabIndex = 49;
            this.button3.Text = "Trans His";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 25);
            this.button2.TabIndex = 48;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 47;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slno,
            this.product,
            this.price,
            this.quantity,
            this.amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1325, 228);
            this.dataGridView1.TabIndex = 46;
            // 
            // slno
            // 
            this.slno.HeaderText = "SLNO";
            this.slno.MinimumWidth = 6;
            this.slno.Name = "slno";
            // 
            // product
            // 
            this.product.HeaderText = "PRODUCT";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // amount
            // 
            this.amount.HeaderText = "AMOUNT";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(730, 209);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(99, 22);
            this.textBox8.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Quantity";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(564, 209);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(89, 22);
            this.textBox7.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Price";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(354, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 22);
            this.textBox6.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Bill No";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 22);
            this.textBox5.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Product  Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Customer Contact";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(441, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 22);
            this.textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Customer Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Employee Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Employee Name";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(896, 520);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(69, 22);
            this.textBox11.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(801, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Total Quantity";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(1090, 523);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(69, 22);
            this.textBox12.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1012, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "Total Price";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(1228, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 32);
            this.button5.TabIndex = 60;
            this.button5.Text = "NEXT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(7, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 32);
            this.button6.TabIndex = 61;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 100);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 59);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(12, 561);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1325, 91);
            this.panel3.TabIndex = 64;
            // 
            // TRANSACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1349, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TRANSACTION";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn slno;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

