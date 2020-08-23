namespace GUI_QuanLy
{
    partial class MHThanhToan
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.paymentMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cardNumberTB = new System.Windows.Forms.TextBox();
            this.cardholderTB = new System.Windows.Forms.TextBox();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.cvcTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.paymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.continueShoppingButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentMethodGroupBox.SuspendLayout();
            this.paymentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Image = global::GUI_QuanLy.Properties.Resources.payment_mastercard;
            this.radioButton1.Location = new System.Drawing.Point(125, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 46);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Image = global::GUI_QuanLy.Properties.Resources.payment_visa;
            this.radioButton2.Location = new System.Drawing.Point(238, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 46);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Image = global::GUI_QuanLy.Properties.Resources.payment_paypal;
            this.radioButton3.Location = new System.Drawing.Point(349, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 46);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // paymentMethodGroupBox
            // 
            this.paymentMethodGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paymentMethodGroupBox.Controls.Add(this.radioButton4);
            this.paymentMethodGroupBox.Controls.Add(this.radioButton1);
            this.paymentMethodGroupBox.Controls.Add(this.radioButton3);
            this.paymentMethodGroupBox.Controls.Add(this.radioButton2);
            this.paymentMethodGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodGroupBox.Location = new System.Drawing.Point(61, 59);
            this.paymentMethodGroupBox.Name = "paymentMethodGroupBox";
            this.paymentMethodGroupBox.Size = new System.Drawing.Size(678, 97);
            this.paymentMethodGroupBox.TabIndex = 3;
            this.paymentMethodGroupBox.TabStop = false;
            this.paymentMethodGroupBox.Text = "Chọn phương thức thanh toán";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(460, 47);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(82, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Tiền mặt";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // cardNumberTB
            // 
            this.cardNumberTB.Location = new System.Drawing.Point(68, 41);
            this.cardNumberTB.Name = "cardNumberTB";
            this.cardNumberTB.Size = new System.Drawing.Size(238, 22);
            this.cardNumberTB.TabIndex = 4;
            this.cardNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardholderTB
            // 
            this.cardholderTB.Location = new System.Drawing.Point(417, 41);
            this.cardholderTB.Name = "cardholderTB";
            this.cardholderTB.Size = new System.Drawing.Size(217, 22);
            this.cardholderTB.TabIndex = 5;
            this.cardholderTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthCB
            // 
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Location = new System.Drawing.Point(107, 104);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(86, 24);
            this.monthCB.TabIndex = 6;
            // 
            // yearCB
            // 
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Location = new System.Drawing.Point(221, 104);
            this.yearCB.Name = "yearCB";
            this.yearCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearCB.Size = new System.Drawing.Size(85, 24);
            this.yearCB.TabIndex = 7;
            this.yearCB.SelectedIndexChanged += new System.EventHandler(this.yearCB_SelectedIndexChanged);
            // 
            // cvcTB
            // 
            this.cvcTB.Location = new System.Drawing.Point(417, 105);
            this.cvcTB.Name = "cvcTB";
            this.cvcTB.Size = new System.Drawing.Size(71, 22);
            this.cvcTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Thẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chủ thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày hết hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "CVC";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkOutButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.Location = new System.Drawing.Point(431, 394);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(150, 35);
            this.checkOutButton.TabIndex = 16;
            this.checkOutButton.Text = "THANH TOÁN";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // paymentInfoGroupBox
            // 
            this.paymentInfoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paymentInfoGroupBox.Controls.Add(this.label1);
            this.paymentInfoGroupBox.Controls.Add(this.cardNumberTB);
            this.paymentInfoGroupBox.Controls.Add(this.cardholderTB);
            this.paymentInfoGroupBox.Controls.Add(this.monthCB);
            this.paymentInfoGroupBox.Controls.Add(this.yearCB);
            this.paymentInfoGroupBox.Controls.Add(this.label4);
            this.paymentInfoGroupBox.Controls.Add(this.cvcTB);
            this.paymentInfoGroupBox.Controls.Add(this.label3);
            this.paymentInfoGroupBox.Controls.Add(this.label2);
            this.paymentInfoGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentInfoGroupBox.Location = new System.Drawing.Point(61, 162);
            this.paymentInfoGroupBox.Name = "paymentInfoGroupBox";
            this.paymentInfoGroupBox.Size = new System.Drawing.Size(678, 174);
            this.paymentInfoGroupBox.TabIndex = 17;
            this.paymentInfoGroupBox.TabStop = false;
            this.paymentInfoGroupBox.Text = "Nhập thông tin thẻ";
            // 
            // continueShoppingButton
            // 
            this.continueShoppingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.continueShoppingButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueShoppingButton.Location = new System.Drawing.Point(217, 394);
            this.continueShoppingButton.Name = "continueShoppingButton";
            this.continueShoppingButton.Size = new System.Drawing.Size(150, 35);
            this.continueShoppingButton.TabIndex = 15;
            this.continueShoppingButton.Text = "TIẾP TỤC MUA HÀNG";
            this.continueShoppingButton.UseVisualStyleBackColor = true;
            this.continueShoppingButton.Click += new System.EventHandler(this.continueShoppingButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "1.000.000 đ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tổng cộng";
            // 
            // MHThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paymentInfoGroupBox);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.continueShoppingButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paymentMethodGroupBox);
            this.Name = "MHThanhToan";
            this.Text = "MHThanhToan";
            this.paymentMethodGroupBox.ResumeLayout(false);
            this.paymentMethodGroupBox.PerformLayout();
            this.paymentInfoGroupBox.ResumeLayout(false);
            this.paymentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox paymentMethodGroupBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox cardNumberTB;
        private System.Windows.Forms.TextBox cardholderTB;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.TextBox cvcTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.GroupBox paymentInfoGroupBox;
        private System.Windows.Forms.Button continueShoppingButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}