namespace SuperMarketTHEREALONE
{
    partial class Forgor
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
            this.MailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeSender = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordRecovery = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(100, 57);
            this.MailBox.Margin = new System.Windows.Forms.Padding(4);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(435, 23);
            this.MailBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password Forgorer |  | Password Recovery";
            // 
            // CodeSender
            // 
            this.CodeSender.Location = new System.Drawing.Point(544, 53);
            this.CodeSender.Margin = new System.Windows.Forms.Padding(4);
            this.CodeSender.Name = "CodeSender";
            this.CodeSender.Size = new System.Drawing.Size(100, 28);
            this.CodeSender.TabIndex = 3;
            this.CodeSender.Text = "Send Code";
            this.CodeSender.UseVisualStyleBackColor = true;
            this.CodeSender.Click += new System.EventHandler(this.CodeSender_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(129, 121);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(132, 23);
            this.PasswordBox.TabIndex = 4;
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(100, 89);
            this.CodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(132, 23);
            this.CodeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code:";
            // 
            // PasswordRecovery
            // 
            this.PasswordRecovery.Location = new System.Drawing.Point(640, 124);
            this.PasswordRecovery.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordRecovery.Name = "PasswordRecovery";
            this.PasswordRecovery.Size = new System.Drawing.Size(100, 28);
            this.PasswordRecovery.TabIndex = 7;
            this.PasswordRecovery.Text = "Change";
            this.PasswordRecovery.UseVisualStyleBackColor = true;
            this.PasswordRecovery.Click += new System.EventHandler(this.PasswordRecovery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter code to change password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "New password:";
            // 
            // Forgor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 166);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordRecovery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.CodeSender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Forgor";
            this.Text = "Forgor";
            this.Load += new System.EventHandler(this.Forgor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CodeSender;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PasswordRecovery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}