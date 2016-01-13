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
            this.SuspendLayout();
            // 
            // ChangeReturnButton
            // 
            this.ChangeReturnButton.Location = new System.Drawing.Point(337, 38);
            this.ChangeReturnButton.Name = "ChangeReturnButton";
            this.ChangeReturnButton.Size = new System.Drawing.Size(75, 44);
            this.ChangeReturnButton.TabIndex = 1;
            this.ChangeReturnButton.Text = "Change Return";
            this.ChangeReturnButton.UseVisualStyleBackColor = true;
            // 
            // InsertPennyButton
            // 
            this.InsertPennyButton.Location = new System.Drawing.Point(13, 40);
            this.InsertPennyButton.Name = "InsertPennyButton";
            this.InsertPennyButton.Size = new System.Drawing.Size(75, 43);
            this.InsertPennyButton.TabIndex = 2;
            this.InsertPennyButton.Text = "Insert Penny";
            this.InsertPennyButton.UseVisualStyleBackColor = true;
            // 
            // InsertNickelButton
            // 
            this.InsertNickelButton.Location = new System.Drawing.Point(94, 39);
            this.InsertNickelButton.Name = "InsertNickelButton";
            this.InsertNickelButton.Size = new System.Drawing.Size(75, 43);
            this.InsertNickelButton.TabIndex = 3;
            this.InsertNickelButton.Text = "Insert Nickel";
            this.InsertNickelButton.UseVisualStyleBackColor = true;
            // 
            // InsertDimeButton
            // 
            this.InsertDimeButton.Location = new System.Drawing.Point(175, 39);
            this.InsertDimeButton.Name = "InsertDimeButton";
            this.InsertDimeButton.Size = new System.Drawing.Size(75, 43);
            this.InsertDimeButton.TabIndex = 4;
            this.InsertDimeButton.Text = "Insert Dime";
            this.InsertDimeButton.UseVisualStyleBackColor = true;
            // 
            // InsertQuarterButton
            // 
            this.InsertQuarterButton.Location = new System.Drawing.Point(256, 39);
            this.InsertQuarterButton.Name = "InsertQuarterButton";
            this.InsertQuarterButton.Size = new System.Drawing.Size(75, 43);
            this.InsertQuarterButton.TabIndex = 5;
            this.InsertQuarterButton.Text = "Insert Quarter";
            this.InsertQuarterButton.UseVisualStyleBackColor = true;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(13, 13);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(398, 22);
            this.DisplayTextBox.TabIndex = 6;
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 93);
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
    }
}