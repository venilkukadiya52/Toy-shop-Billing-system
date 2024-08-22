namespace Toy_Shop
{
    partial class frmSeleProductAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleProductAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.custname = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Productname = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.totalamount = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.heading);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.custname);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Productname);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Qty);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.totalamount);
            this.panel1.Location = new System.Drawing.Point(609, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 326);
            this.panel1.TabIndex = 84;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(63, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "Customer Name";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(139, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 35);
            this.button5.TabIndex = 46;
            this.button5.Text = "Generate Bill";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(134, 11);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(136, 29);
            this.heading.TabIndex = 47;
            this.heading.Text = "SALE BILL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Pay Able Amount";
            // 
            // custname
            // 
            this.custname.AutoSize = true;
            this.custname.Location = new System.Drawing.Point(231, 69);
            this.custname.Name = "custname";
            this.custname.Size = new System.Drawing.Size(0, 17);
            this.custname.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Price";
            // 
            // Productname
            // 
            this.Productname.AutoSize = true;
            this.Productname.Location = new System.Drawing.Point(231, 108);
            this.Productname.Name = "Productname";
            this.Productname.Size = new System.Drawing.Size(0, 17);
            this.Productname.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Qty";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(231, 159);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(0, 17);
            this.Qty.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Product Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(231, 195);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 17);
            this.price.TabIndex = 51;
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.Location = new System.Drawing.Point(231, 228);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(0, 17);
            this.totalamount.TabIndex = 52;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(423, 313);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 29);
            this.button6.TabIndex = 83;
            this.button6.Text = "View";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 82;
            this.label9.Text = "Date";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(161, 320);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(223, 22);
            this.txtdate.TabIndex = 81;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 275);
            this.dataGridView1.TabIndex = 79;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(423, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 29);
            this.button3.TabIndex = 68;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(161, 235);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(223, 69);
            this.txtaddress.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 78;
            this.label8.Text = "Address";
            // 
            // txtcontactno
            // 
            this.txtcontactno.Location = new System.Drawing.Point(161, 195);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(223, 22);
            this.txtcontactno.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 77;
            this.label7.Text = "Contact No";
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(161, 156);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(223, 22);
            this.txtcustname.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(161, 348);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(223, 22);
            this.txtstock.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Price";
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(161, 120);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.Size = new System.Drawing.Size(223, 22);
            this.txttotalprice.TabIndex = 72;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(161, 92);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(223, 22);
            this.txtprice.TabIndex = 71;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(423, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 70;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 67;
            this.button1.Text = "Sale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // cmbproduct
            // 
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(161, 18);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(223, 24);
            this.cmbproduct.TabIndex = 60;
            this.cmbproduct.Leave += new System.EventHandler(this.cmbproduct_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Total Price";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(161, 60);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(223, 22);
            this.txtqty.TabIndex = 63;
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "Product";
            // 
            // frmSeleProductAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbproduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSeleProductAdmin";
            this.Text = "frmSeleProductAdmin";
            this.Load += new System.EventHandler(this.frmSeleProductAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label custname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Productname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label totalamount;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}