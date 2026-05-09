namespace LibraryApp
{
    partial class Login
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
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.forgotbtn = new System.Windows.Forms.Button();
            this.btnGuestRegister = new System.Windows.Forms.Button();
            this.btnGuestSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username / Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(277, 74);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(165, 22);
            this.usertxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(277, 126);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(165, 22);
            this.passtxt.TabIndex = 3;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(216, 202);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 34);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(216, 257);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(75, 34);
            this.signupbtn.TabIndex = 5;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // forgotbtn
            // 
            this.forgotbtn.Location = new System.Drawing.Point(146, 360);
            this.forgotbtn.Name = "forgotbtn";
            this.forgotbtn.Size = new System.Drawing.Size(231, 34);
            this.forgotbtn.TabIndex = 6;
            this.forgotbtn.Text = "Forgot/Change password";
            this.forgotbtn.UseVisualStyleBackColor = true;
            this.forgotbtn.Click += new System.EventHandler(this.forgotbtn_Click);
            // 
            // btnGuestRegister
            // 
            this.btnGuestRegister.Location = new System.Drawing.Point(193, 311);
            this.btnGuestRegister.Name = "btnGuestRegister";
            this.btnGuestRegister.Size = new System.Drawing.Size(122, 34);
            this.btnGuestRegister.TabIndex = 7;
            this.btnGuestRegister.Text = "Guest Register";
            this.btnGuestRegister.UseVisualStyleBackColor = true;
            this.btnGuestRegister.Click += new System.EventHandler(this.btnGuestRegister_Click);
            // 
            // btnGuestSearch
            // 
            this.btnGuestSearch.Location = new System.Drawing.Point(183, 418);
            this.btnGuestSearch.Name = "btnGuestSearch";
            this.btnGuestSearch.Size = new System.Drawing.Size(144, 28);
            this.btnGuestSearch.TabIndex = 8;
            this.btnGuestSearch.Text = "continue as guest";
            this.btnGuestSearch.UseVisualStyleBackColor = true;
            this.btnGuestSearch.Click += new System.EventHandler(this.btnGuestSearch_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 484);
            this.Controls.Add(this.btnGuestSearch);
            this.Controls.Add(this.btnGuestRegister);
            this.Controls.Add(this.forgotbtn);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button forgotbtn;
        private System.Windows.Forms.Button btnGuestRegister;
        private System.Windows.Forms.Button btnGuestSearch;
    }
}