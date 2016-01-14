namespace Vending_Machine_Kata
{
    partial class SimpleForm
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
            this.ChangeReturnButton = new System.Windows.Forms.Button();
            this.InsertPennyButton = new System.Windows.Forms.Button();
            this.InsertNickelButton = new System.Windows.Forms.Button();
            this.InsertDimeButton = new System.Windows.Forms.Button();
            this.InsertQuarterButton = new System.Windows.Forms.Button();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.VendingDisplayLabel = new System.Windows.Forms.Label();
            this.CoinReturnLabel = new System.Windows.Forms.Label();
            this.ClearCoinReturnButton = new System.Windows.Forms.Button();
            this.CoinReturnDisplayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeReturnButton
            // 
            this.ChangeReturnButton.Location = new System.Drawing.Point(12, 205);
            this.ChangeReturnButton.Name = "ChangeReturnButton";
            this.ChangeReturnButton.Size = new System.Drawing.Size(75, 44);
            this.ChangeReturnButton.TabIndex = 1;
            this.ChangeReturnButton.Text = "Change Return";
            this.ChangeReturnButton.UseVisualStyleBackColor = true;
            // 
            // InsertPennyButton
            // 
            this.InsertPennyButton.Location = new System.Drawing.Point(12, 57);
            this.InsertPennyButton.Name = "InsertPennyButton";
            this.InsertPennyButton.Size = new System.Drawing.Size(75, 43);
            this.InsertPennyButton.TabIndex = 2;
            this.InsertPennyButton.Text = "Insert Penny";
            this.InsertPennyButton.UseVisualStyleBackColor = true;
            // 
            // InsertNickelButton
            // 
            this.InsertNickelButton.Location = new System.Drawing.Point(12, 106);
            this.InsertNickelButton.Name = "InsertNickelButton";
            this.InsertNickelButton.Size = new System.Drawing.Size(75, 43);
            this.InsertNickelButton.TabIndex = 3;
            this.InsertNickelButton.Text = "Insert Nickel";
            this.InsertNickelButton.UseVisualStyleBackColor = true;
            // 
            // InsertDimeButton
            // 
            this.InsertDimeButton.Location = new System.Drawing.Point(96, 57);
            this.InsertDimeButton.Name = "InsertDimeButton";
            this.InsertDimeButton.Size = new System.Drawing.Size(75, 43);
            this.InsertDimeButton.TabIndex = 4;
            this.InsertDimeButton.Text = "Insert Dime";
            this.InsertDimeButton.UseVisualStyleBackColor = true;
            // 
            // InsertQuarterButton
            // 
            this.InsertQuarterButton.Location = new System.Drawing.Point(96, 106);
            this.InsertQuarterButton.Name = "InsertQuarterButton";
            this.InsertQuarterButton.Size = new System.Drawing.Size(75, 43);
            this.InsertQuarterButton.TabIndex = 5;
            this.InsertQuarterButton.Text = "Insert Quarter";
            this.InsertQuarterButton.UseVisualStyleBackColor = true;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(15, 29);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(156, 22);
            this.DisplayTextBox.TabIndex = 6;
            // 
            // VendingDisplayLabel
            // 
            this.VendingDisplayLabel.AutoSize = true;
            this.VendingDisplayLabel.Location = new System.Drawing.Point(9, 9);
            this.VendingDisplayLabel.Name = "VendingDisplayLabel";
            this.VendingDisplayLabel.Size = new System.Drawing.Size(114, 17);
            this.VendingDisplayLabel.TabIndex = 7;
            this.VendingDisplayLabel.Text = "Vending Display:";
            // 
            // CoinReturnLabel
            // 
            this.CoinReturnLabel.AutoSize = true;
            this.CoinReturnLabel.Location = new System.Drawing.Point(12, 157);
            this.CoinReturnLabel.Name = "CoinReturnLabel";
            this.CoinReturnLabel.Size = new System.Drawing.Size(87, 17);
            this.CoinReturnLabel.TabIndex = 8;
            this.CoinReturnLabel.Text = "Coin Return:";
            // 
            // ClearCoinReturnButton
            // 
            this.ClearCoinReturnButton.Location = new System.Drawing.Point(93, 205);
            this.ClearCoinReturnButton.Name = "ClearCoinReturnButton";
            this.ClearCoinReturnButton.Size = new System.Drawing.Size(75, 44);
            this.ClearCoinReturnButton.TabIndex = 10;
            this.ClearCoinReturnButton.Text = "Clear";
            this.ClearCoinReturnButton.UseVisualStyleBackColor = true;
            // 
            // CoinReturnDisplayTextBox
            // 
            this.CoinReturnDisplayTextBox.Location = new System.Drawing.Point(12, 177);
            this.CoinReturnDisplayTextBox.Name = "CoinReturnDisplayTextBox";
            this.CoinReturnDisplayTextBox.Size = new System.Drawing.Size(156, 22);
            this.CoinReturnDisplayTextBox.TabIndex = 11;
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 264);
            this.Controls.Add(this.CoinReturnDisplayTextBox);
            this.Controls.Add(this.ClearCoinReturnButton);
            this.Controls.Add(this.CoinReturnLabel);
            this.Controls.Add(this.VendingDisplayLabel);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.InsertQuarterButton);
            this.Controls.Add(this.InsertDimeButton);
            this.Controls.Add(this.InsertNickelButton);
            this.Controls.Add(this.InsertPennyButton);
            this.Controls.Add(this.ChangeReturnButton);
            this.Name = "SimpleForm";
            this.Text = "Vending Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeReturnButton;
        private System.Windows.Forms.Button InsertPennyButton;
        private System.Windows.Forms.Button InsertNickelButton;
        private System.Windows.Forms.Button InsertDimeButton;
        private System.Windows.Forms.Button InsertQuarterButton;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Label VendingDisplayLabel;
        private System.Windows.Forms.Label CoinReturnLabel;
        private System.Windows.Forms.Button ClearCoinReturnButton;
        private System.Windows.Forms.TextBox CoinReturnDisplayTextBox;
    }
}