namespace dogShelter
{
    partial class FoodCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodCalculator));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxBreed = new System.Windows.Forms.ComboBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.equalLabel = new System.Windows.Forms.Label();
            this.multiplyLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 19);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(265, 30);
            this.inputTextBox.TabIndex = 0;
            // 
            // comboBoxBreed
            // 
            this.comboBoxBreed.DisplayMember = "Text";
            this.comboBoxBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBreed.FormattingEnabled = true;
            this.comboBoxBreed.Items.AddRange(new object[] {
            "Hound",
            "Retriever",
            "Sheepdog",
            "Spitz",
            "Terrier"});
            this.comboBoxBreed.Location = new System.Drawing.Point(316, 16);
            this.comboBoxBreed.Name = "comboBoxBreed";
            this.comboBoxBreed.Size = new System.Drawing.Size(136, 33);
            this.comboBoxBreed.TabIndex = 19;
            this.comboBoxBreed.ValueMember = "ID";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(523, 19);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(265, 30);
            this.resultTextBox.TabIndex = 20;
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel.Location = new System.Drawing.Point(477, 22);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(25, 25);
            this.equalLabel.TabIndex = 21;
            this.equalLabel.Text = "=";
            // 
            // multiplyLabel
            // 
            this.multiplyLabel.AutoSize = true;
            this.multiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyLabel.Location = new System.Drawing.Point(289, 27);
            this.multiplyLabel.Name = "multiplyLabel";
            this.multiplyLabel.Size = new System.Drawing.Size(21, 25);
            this.multiplyLabel.TabIndex = 22;
            this.multiplyLabel.Text = "*";
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calcButton.Location = new System.Drawing.Point(821, 18);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(89, 33);
            this.calcButton.TabIndex = 23;
            this.calcButton.Text = "Go";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // FoodCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 61);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.multiplyLabel);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.comboBoxBreed);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FoodCalculator";
            this.Text = "FoodCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ComboBox comboBoxBreed;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.Label multiplyLabel;
        private System.Windows.Forms.Button calcButton;
    }
}