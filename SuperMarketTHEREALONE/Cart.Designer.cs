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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartTxt
            // 
            this.CartTxt.Location = new System.Drawing.Point(41, 26);
            this.CartTxt.Name = "CartTxt";
            this.CartTxt.Size = new System.Drawing.Size(621, 592);
            this.CartTxt.TabIndex = 0;
            this.CartTxt.TabStop = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("SPGrigolia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuy.Location = new System.Drawing.Point(93, 258);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(232, 40);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy/Send Receipt";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(161, 175);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(164, 22);
            this.Surnametxt.TabIndex = 2;
            this.Surnametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(161, 127);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(164, 22);
            this.Nametxt.TabIndex = 3;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(161, 221);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(164, 22);
            this.Emailtxt.TabIndex = 4;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LbName.Location = new System.Drawing.Point(90, 130);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(57, 20);
            this.LbName.TabIndex = 5;
            this.LbName.Text = "Name";
            // 
            // LbSurname
            // 
            this.LbSurname.AutoSize = true;
            this.LbSurname.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LbSurname.Location = new System.Drawing.Point(62, 177);
            this.LbSurname.Name = "LbSurname";
            this.LbSurname.Size = new System.Drawing.Size(93, 20);
            this.LbSurname.TabIndex = 6;
            this.LbSurname.Text = "Surname";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LbEmail.Location = new System.Drawing.Point(86, 221);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(69, 20);
            this.LbEmail.TabIndex = 7;
            this.LbEmail.Text = "Email";
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
            this.groupBox2.Location = new System.Drawing.Point(709, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 321);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Yu Gothic Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(703, 30);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(201, 36);
            this.LbTotal.TabIndex = 11;
            this.LbTotal.Text = "TOTAL PRICE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(910, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "1000$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "YOUR CART :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(704, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "THANK YOU FOR THE PURCHASE <3";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 696);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CartTxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cart";
            this.Text = "Cart";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}