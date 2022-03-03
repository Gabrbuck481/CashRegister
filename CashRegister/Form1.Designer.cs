namespace CashRegister
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.sliceLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.garlicLabel = new System.Windows.Forms.Label();
            this.wingsLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.flagImageBox = new System.Windows.Forms.PictureBox();
            this.slicesInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.garlicInput = new System.Windows.Forms.TextBox();
            this.wingsInput = new System.Windows.Forms.TextBox();
            this.familyInput = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.confirmOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flagImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(91, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(442, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "FREDRICK FAZBEARINGTON\'S";
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.Location = new System.Drawing.Point(148, 75);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(311, 31);
            this.titleLabel2.TabIndex = 1;
            this.titleLabel2.Text = "FINE ITALIAN DINING";
            // 
            // sliceLabel
            // 
            this.sliceLabel.AutoSize = true;
            this.sliceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliceLabel.Location = new System.Drawing.Point(30, 196);
            this.sliceLabel.Name = "sliceLabel";
            this.sliceLabel.Size = new System.Drawing.Size(120, 16);
            this.sliceLabel.TabIndex = 6;
            this.sliceLabel.Text = "Slice of Pizza $1.50";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(30, 228);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(149, 16);
            this.drinkLabel.TabIndex = 7;
            this.drinkLabel.Text = "Medium Soft Drink $1.75";
            // 
            // garlicLabel
            // 
            this.garlicLabel.AutoSize = true;
            this.garlicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garlicLabel.Location = new System.Drawing.Point(30, 262);
            this.garlicLabel.Name = "garlicLabel";
            this.garlicLabel.Size = new System.Drawing.Size(165, 16);
            this.garlicLabel.TabIndex = 8;
            this.garlicLabel.Text = "Garlic Cheesy Bread $2.00";
            // 
            // wingsLabel
            // 
            this.wingsLabel.AutoSize = true;
            this.wingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wingsLabel.Location = new System.Drawing.Point(30, 296);
            this.wingsLabel.Name = "wingsLabel";
            this.wingsLabel.Size = new System.Drawing.Size(128, 16);
            this.wingsLabel.TabIndex = 9;
            this.wingsLabel.Text = "1LBS of Wings $3.00\r\n";
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyLabel.Location = new System.Drawing.Point(30, 329);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(135, 16);
            this.familyLabel.TabIndex = 10;
            this.familyLabel.Text = "Family Combo $13.75";
            // 
            // flagImageBox
            // 
            this.flagImageBox.Image = global::CashRegister.Properties.Resources.flag;
            this.flagImageBox.Location = new System.Drawing.Point(1, -3);
            this.flagImageBox.Name = "flagImageBox";
            this.flagImageBox.Size = new System.Drawing.Size(606, 146);
            this.flagImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flagImageBox.TabIndex = 11;
            this.flagImageBox.TabStop = false;
            // 
            // slicesInput
            // 
            this.slicesInput.Location = new System.Drawing.Point(215, 192);
            this.slicesInput.Name = "slicesInput";
            this.slicesInput.Size = new System.Drawing.Size(75, 20);
            this.slicesInput.TabIndex = 12;
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(215, 224);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(75, 20);
            this.drinkInput.TabIndex = 13;
            // 
            // garlicInput
            // 
            this.garlicInput.Location = new System.Drawing.Point(215, 261);
            this.garlicInput.Name = "garlicInput";
            this.garlicInput.Size = new System.Drawing.Size(75, 20);
            this.garlicInput.TabIndex = 14;
            // 
            // wingsInput
            // 
            this.wingsInput.Location = new System.Drawing.Point(215, 292);
            this.wingsInput.Name = "wingsInput";
            this.wingsInput.Size = new System.Drawing.Size(75, 20);
            this.wingsInput.TabIndex = 15;
            // 
            // familyInput
            // 
            this.familyInput.Location = new System.Drawing.Point(215, 325);
            this.familyInput.Name = "familyInput";
            this.familyInput.Size = new System.Drawing.Size(75, 20);
            this.familyInput.TabIndex = 16;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(215, 351);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 17;
            this.orderButton.Text = "Place Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(30, 358);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(62, 16);
            this.subTotalLabel.TabIndex = 18;
            this.subTotalLabel.Text = "Subtotal :";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(30, 385);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(36, 16);
            this.taxLabel.TabIndex = 19;
            this.taxLabel.Text = "Tax :";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(30, 412);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 16);
            this.totalLabel.TabIndex = 20;
            this.totalLabel.Text = "Total :";
            // 
            // subTotalOutputLabel
            // 
            this.subTotalOutputLabel.BackColor = System.Drawing.Color.White;
            this.subTotalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutputLabel.Location = new System.Drawing.Point(121, 358);
            this.subTotalOutputLabel.Name = "subTotalOutputLabel";
            this.subTotalOutputLabel.Size = new System.Drawing.Size(58, 16);
            this.subTotalOutputLabel.TabIndex = 23;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BackColor = System.Drawing.Color.White;
            this.totalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.Location = new System.Drawing.Point(121, 412);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(58, 16);
            this.totalOutputLabel.TabIndex = 24;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(121, 385);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(58, 16);
            this.taxOutput.TabIndex = 25;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receiptLabel.Location = new System.Drawing.Point(358, 192);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(205, 236);
            this.receiptLabel.TabIndex = 26;
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrderButton.Location = new System.Drawing.Point(215, 405);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(75, 23);
            this.confirmOrderButton.TabIndex = 27;
            this.confirmOrderButton.Text = "Confirm Order";
            this.confirmOrderButton.UseVisualStyleBackColor = true;
            this.confirmOrderButton.Click += new System.EventHandler(this.confirmOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.confirmOrderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.subTotalOutputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.familyInput);
            this.Controls.Add(this.wingsInput);
            this.Controls.Add(this.garlicInput);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.slicesInput);
            this.Controls.Add(this.familyLabel);
            this.Controls.Add(this.wingsLabel);
            this.Controls.Add(this.garlicLabel);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.sliceLabel);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.flagImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flagImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label sliceLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label garlicLabel;
        private System.Windows.Forms.Label wingsLabel;
        private System.Windows.Forms.Label familyLabel;
        private System.Windows.Forms.PictureBox flagImageBox;
        private System.Windows.Forms.TextBox slicesInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.TextBox garlicInput;
        private System.Windows.Forms.TextBox wingsInput;
        private System.Windows.Forms.TextBox familyInput;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button confirmOrderButton;
    }
}

