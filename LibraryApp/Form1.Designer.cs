namespace LibraryApp
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
            this.btnCountUsers = new System.Windows.Forms.Button();
            this.btnOpenBookSearch = new System.Windows.Forms.Button();
            this.btnMyHistory = new System.Windows.Forms.Button();
            this.btnMyReservations = new System.Windows.Forms.Button();
            this.btnMyFines = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCountUsers
            // 
            this.btnCountUsers.Location = new System.Drawing.Point(252, 12);
            this.btnCountUsers.Name = "btnCountUsers";
            this.btnCountUsers.Size = new System.Drawing.Size(145, 73);
            this.btnCountUsers.TabIndex = 0;
            this.btnCountUsers.Text = "count users";
            this.btnCountUsers.UseVisualStyleBackColor = true;
            this.btnCountUsers.Click += new System.EventHandler(this.btnCountUsers_Click);
            // 
            // btnOpenBookSearch
            // 
            this.btnOpenBookSearch.Location = new System.Drawing.Point(252, 112);
            this.btnOpenBookSearch.Name = "btnOpenBookSearch";
            this.btnOpenBookSearch.Size = new System.Drawing.Size(145, 69);
            this.btnOpenBookSearch.TabIndex = 1;
            this.btnOpenBookSearch.Text = "search books";
            this.btnOpenBookSearch.UseVisualStyleBackColor = true;
            this.btnOpenBookSearch.Click += new System.EventHandler(this.btnOpenBookSearch_Click);
            // 
            // btnMyHistory
            // 
            this.btnMyHistory.Location = new System.Drawing.Point(252, 209);
            this.btnMyHistory.Name = "btnMyHistory";
            this.btnMyHistory.Size = new System.Drawing.Size(145, 64);
            this.btnMyHistory.TabIndex = 2;
            this.btnMyHistory.Text = "my borrowing history";
            this.btnMyHistory.UseVisualStyleBackColor = true;
            this.btnMyHistory.Click += new System.EventHandler(this.btnMyHistory_Click);
            // 
            // btnMyReservations
            // 
            this.btnMyReservations.Location = new System.Drawing.Point(47, 211);
            this.btnMyReservations.Name = "btnMyReservations";
            this.btnMyReservations.Size = new System.Drawing.Size(145, 62);
            this.btnMyReservations.TabIndex = 3;
            this.btnMyReservations.Text = "my reservations";
            this.btnMyReservations.UseVisualStyleBackColor = true;
            this.btnMyReservations.Click += new System.EventHandler(this.btnMyReservations_Click);
            // 
            // btnMyFines
            // 
            this.btnMyFines.Location = new System.Drawing.Point(448, 209);
            this.btnMyFines.Name = "btnMyFines";
            this.btnMyFines.Size = new System.Drawing.Size(136, 64);
            this.btnMyFines.TabIndex = 4;
            this.btnMyFines.Text = "my fines";
            this.btnMyFines.UseVisualStyleBackColor = true;
            this.btnMyFines.Click += new System.EventHandler(this.btnMyFines_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(252, 319);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(145, 64);
            this.btnNotifications.TabIndex = 5;
            this.btnNotifications.Text = "notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnMyFines);
            this.Controls.Add(this.btnMyReservations);
            this.Controls.Add(this.btnMyHistory);
            this.Controls.Add(this.btnOpenBookSearch);
            this.Controls.Add(this.btnCountUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCountUsers;
        private System.Windows.Forms.Button btnOpenBookSearch;
        private System.Windows.Forms.Button btnMyHistory;
        private System.Windows.Forms.Button btnMyReservations;
        private System.Windows.Forms.Button btnMyFines;
        private System.Windows.Forms.Button btnNotifications;
    }
}

