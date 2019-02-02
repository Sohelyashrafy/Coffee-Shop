namespace WindowsFormsApplication1st_Assignment
{
    partial class CoffeeShopUi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SaveUi = new System.Windows.Forms.Button();
            this.PaymentInformation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(125, 67);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 6;
            // 
            // ContactNo
            // 
            this.ContactNo.Location = new System.Drawing.Point(125, 91);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(100, 20);
            this.ContactNo.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(125, 115);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 8;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(125, 174);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Reguler"});
            this.comboBox1.Location = new System.Drawing.Point(125, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // SaveUi
            // 
            this.SaveUi.Location = new System.Drawing.Point(149, 213);
            this.SaveUi.Name = "SaveUi";
            this.SaveUi.Size = new System.Drawing.Size(75, 23);
            this.SaveUi.TabIndex = 11;
            this.SaveUi.Text = "Save";
            this.SaveUi.UseVisualStyleBackColor = true;
            this.SaveUi.Click += new System.EventHandler(this.SaveUi_Click);
            // 
            // PaymentInformation
            // 
            this.PaymentInformation.Location = new System.Drawing.Point(245, 26);
            this.PaymentInformation.Name = "PaymentInformation";
            this.PaymentInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PaymentInformation.Size = new System.Drawing.Size(155, 168);
            this.PaymentInformation.TabIndex = 12;
            this.PaymentInformation.Text = " ";
            // 
            // CoffeeShopUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 248);
            this.Controls.Add(this.PaymentInformation);
            this.Controls.Add(this.SaveUi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CoffeeShopUi";
            this.Text = "Coffee Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SaveUi;
        private System.Windows.Forms.RichTextBox PaymentInformation;
    }
}

