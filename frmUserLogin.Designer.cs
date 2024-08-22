namespace Toy_Shop
{
    partial class frmUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogin));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_login_heading = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.error_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_password = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_password)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(289, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 59;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_login_heading
            // 
            this.lbl_login_heading.AutoSize = true;
            this.lbl_login_heading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_heading.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_heading.ForeColor = System.Drawing.Color.Black;
            this.lbl_login_heading.Location = new System.Drawing.Point(126, 77);
            this.lbl_login_heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login_heading.Name = "lbl_login_heading";
            this.lbl_login_heading.Size = new System.Drawing.Size(316, 47);
            this.lbl_login_heading.TabIndex = 58;
            this.lbl_login_heading.Text = ":: LOGIN FORM ::";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(152, 263);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(117, 38);
            this.btn_login.TabIndex = 55;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(193, 211);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(263, 22);
            this.txt_password.TabIndex = 54;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(193, 156);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(263, 22);
            this.txt_username.TabIndex = 53;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(86, 209);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(87, 24);
            this.lbl_password.TabIndex = 57;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(90, 153);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(95, 24);
            this.lbl_username.TabIndex = 56;
            this.lbl_username.Text = "User Name";
            // 
            // error_username
            // 
            this.error_username.ContainerControl = this;
            // 
            // error_password
            // 
            this.error_password.ContainerControl = this;
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_login_heading);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "frmUserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserLogin";
            this.Load += new System.EventHandler(this.frmUserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_login_heading;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ErrorProvider error_username;
        private System.Windows.Forms.ErrorProvider error_password;
    }
}