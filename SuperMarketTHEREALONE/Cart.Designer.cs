namespace SuperMarketTHEREALONE
{
    partial class Cart
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
            this.CartTxt = new System.Windows.Forms.GroupBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.LbName = new System.Windows.Forms.Label();
            this.LbSurname = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CartTxt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartTxt
            // 
            this.CartTxt.Controls.Add(this.label1);
            this.CartTxt.Location = new System.Drawing.Point(31, 21);
            this.CartTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CartTxt.Name = "CartTxt";
            this.CartTxt.Padding = new System.Windows.Forms.Padding(2);
            this.CartTxt.Size = new System.Drawing.Size(466, 481);
            this.CartTxt.TabIndex = 0;
            this.CartTxt.TabStop = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuy.Location = new System.Drawing.Point(70, 210);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(174, 32);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy/Send Receipt";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(121, 142);
            this.Surnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(124, 20);
            this.Surnametxt.TabIndex = 2;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(121, 103);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(2);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(124, 20);
            this.Nametxt.TabIndex = 3;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(128, 182);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(124, 20);
            this.Emailtxt.TabIndex = 4;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LbName.Location = new System.Drawing.Point(68, 106);
            this.LbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(55, 20);
            this.LbName.TabIndex = 5;
            this.LbName.Text = "Name:";
            // 
            // LbSurname
            // 
            this.LbSurname.AutoSize = true;
            this.LbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LbSurname.Location = new System.Drawing.Point(46, 144);
            this.LbSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSurname.Name = "LbSurname";
            this.LbSurname.Size = new System.Drawing.Size(78, 20);
            this.LbSurname.TabIndex = 6;
            this.LbSurname.Text = "Surname:";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LbEmail.Location = new System.Drawing.Point(4, 180);
            this.LbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(123, 20);
            this.LbEmail.TabIndex = 7;
            this.LbEmail.Text = "Recipiant Email:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nametxt);
            this.groupBox2.Controls.Add(this.LbEmail);
            this.groupBox2.Controls.Add(this.btnBuy);
            this.groupBox2.Controls.Add(this.LbSurname);
            this.groupBox2.Controls.Add(this.Surnametxt);
            this.groupBox2.Controls.Add(this.LbName);
            this.groupBox2.Controls.Add(this.Emailtxt);
            this.groupBox2.Location = new System.Drawing.Point(532, 241);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(278, 261);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Yu Gothic Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(527, 24);
            this.LbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(155, 29);
            this.LbTotal.TabIndex = 11;
            this.LbTotal.Text = "TOTAL PRICE :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Yu Gothic Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(682, 24);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 29);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "00$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 451);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "YOUR CART :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(528, 514);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 13;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CartTxt);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.CartTxt.ResumeLayout(false);
            this.CartTxt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CartTxt;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbSurname;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}