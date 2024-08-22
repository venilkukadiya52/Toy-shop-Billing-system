namespace Toy_Shop
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpassword.Location = new System.Drawing.Point(271, 162);
            this.txtoldpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.PasswordChar = '*';
            this.txtoldpassword.Size = new System.Drawing.Size(205, 30);
            this.txtoldpassword.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Change Password";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassword.Location = new System.Drawing.Point(271, 209);
            this.txtnewpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.PasswordChar = '*';
            this.txtnewpassword.Size = new System.Drawing.Size(205, 30);
            this.txtnewpassword.TabIndex = 19;
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(271, 261);
            this.txtconfirmpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.PasswordChar = '*';
            this.txtconfirmpassword.Size = new System.Drawing.Size(205, 30);
            this.txtconfirmpassword.TabIndex = 18;
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.Location = new System.Drawing.Point(81, 267);
            this.lblconfirmpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(182, 22);
            this.lblconfirmpassword.TabIndex = 17;
            this.lblconfirmpassword.Text = "Confirm Password";
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblnewpassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassword.Location = new System.Drawing.Point(101, 215);
            this.lblnewpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(147, 22);
            this.lblnewpassword.TabIndex = 16;
            this.lblnewpassword.Text = "New Password";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(211, 324);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(138, 36);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Change";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 474);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.btnsave);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Button btnsave;
    }
}