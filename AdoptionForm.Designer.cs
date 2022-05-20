namespace dogShelter
{
    partial class AdoptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoptionForm));
            this.dogsListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.FRadioButton = new System.Windows.Forms.RadioButton();
            this.MRdioButton = new System.Windows.Forms.RadioButton();
            this.adopterNameTextBox = new System.Windows.Forms.TextBox();
            this.adopterAddressTextBox = new System.Windows.Forms.TextBox();
            this.adopterNumberTextBox = new System.Windows.Forms.TextBox();
            this.adoptButton = new System.Windows.Forms.Button();
            this.searchBarLabel = new System.Windows.Forms.Label();
            this.adopterNameLabel = new System.Windows.Forms.Label();
            this.adopterAddresslabel = new System.Windows.Forms.Label();
            this.adopterNumberlabel = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dogsListBox
            // 
            this.dogsListBox.DisplayMember = "Dog.Name";
            this.dogsListBox.FormattingEnabled = true;
            this.dogsListBox.ItemHeight = 16;
            this.dogsListBox.Location = new System.Drawing.Point(61, 126);
            this.dogsListBox.Name = "dogsListBox";
            this.dogsListBox.Size = new System.Drawing.Size(400, 276);
            this.dogsListBox.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(61, 49);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(400, 24);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // FRadioButton
            // 
            this.FRadioButton.AutoSize = true;
            this.FRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRadioButton.Location = new System.Drawing.Point(70, 89);
            this.FRadioButton.Name = "FRadioButton";
            this.FRadioButton.Size = new System.Drawing.Size(79, 22);
            this.FRadioButton.TabIndex = 3;
            this.FRadioButton.TabStop = true;
            this.FRadioButton.Text = "female";
            this.FRadioButton.UseVisualStyleBackColor = true;
            this.FRadioButton.CheckedChanged += new System.EventHandler(this.FRadioButton_CheckedChanged);
            // 
            // MRdioButton
            // 
            this.MRdioButton.AutoSize = true;
            this.MRdioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRdioButton.Location = new System.Drawing.Point(179, 89);
            this.MRdioButton.Name = "MRdioButton";
            this.MRdioButton.Size = new System.Drawing.Size(65, 22);
            this.MRdioButton.TabIndex = 4;
            this.MRdioButton.TabStop = true;
            this.MRdioButton.Text = "male";
            this.MRdioButton.UseVisualStyleBackColor = true;
            this.MRdioButton.CheckedChanged += new System.EventHandler(this.MRdioButton_CheckedChanged);
            // 
            // adopterNameTextBox
            // 
            this.adopterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterNameTextBox.Location = new System.Drawing.Point(61, 491);
            this.adopterNameTextBox.Name = "adopterNameTextBox";
            this.adopterNameTextBox.Size = new System.Drawing.Size(351, 24);
            this.adopterNameTextBox.TabIndex = 5;
            // 
            // adopterAddressTextBox
            // 
            this.adopterAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterAddressTextBox.Location = new System.Drawing.Point(61, 554);
            this.adopterAddressTextBox.Name = "adopterAddressTextBox";
            this.adopterAddressTextBox.Size = new System.Drawing.Size(218, 24);
            this.adopterAddressTextBox.TabIndex = 6;
            // 
            // adopterNumberTextBox
            // 
            this.adopterNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterNumberTextBox.Location = new System.Drawing.Point(61, 619);
            this.adopterNumberTextBox.Name = "adopterNumberTextBox";
            this.adopterNumberTextBox.Size = new System.Drawing.Size(218, 24);
            this.adopterNumberTextBox.TabIndex = 7;
            // 
            // adoptButton
            // 
            this.adoptButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adoptButton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adoptButton.Location = new System.Drawing.Point(378, 648);
            this.adoptButton.Name = "adoptButton";
            this.adoptButton.Size = new System.Drawing.Size(121, 35);
            this.adoptButton.TabIndex = 8;
            this.adoptButton.Text = "Adopt";
            this.adoptButton.UseVisualStyleBackColor = false;
            this.adoptButton.Click += new System.EventHandler(this.adoptButton_Click);
            // 
            // searchBarLabel
            // 
            this.searchBarLabel.AutoSize = true;
            this.searchBarLabel.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarLabel.Location = new System.Drawing.Point(65, 21);
            this.searchBarLabel.Name = "searchBarLabel";
            this.searchBarLabel.Size = new System.Drawing.Size(199, 25);
            this.searchBarLabel.TabIndex = 9;
            this.searchBarLabel.Text = "Breed preference?";
            // 
            // adopterNameLabel
            // 
            this.adopterNameLabel.AutoSize = true;
            this.adopterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterNameLabel.Location = new System.Drawing.Point(67, 468);
            this.adopterNameLabel.Name = "adopterNameLabel";
            this.adopterNameLabel.Size = new System.Drawing.Size(140, 20);
            this.adopterNameLabel.TabIndex = 10;
            this.adopterNameLabel.Text = "Adopter\'s name";
            // 
            // adopterAddresslabel
            // 
            this.adopterAddresslabel.AutoSize = true;
            this.adopterAddresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterAddresslabel.Location = new System.Drawing.Point(67, 531);
            this.adopterAddresslabel.Name = "adopterAddresslabel";
            this.adopterAddresslabel.Size = new System.Drawing.Size(78, 20);
            this.adopterAddresslabel.TabIndex = 11;
            this.adopterAddresslabel.Text = "Address";
            // 
            // adopterNumberlabel
            // 
            this.adopterNumberlabel.AutoSize = true;
            this.adopterNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterNumberlabel.Location = new System.Drawing.Point(66, 596);
            this.adopterNumberlabel.Name = "adopterNumberlabel";
            this.adopterNumberlabel.Size = new System.Drawing.Size(129, 20);
            this.adopterNumberlabel.TabIndex = 12;
            this.adopterNumberlabel.Text = "Phone number";
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.Location = new System.Drawing.Point(-2, 424);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(530, 25);
            this.lineLabel.TabIndex = 13;
            this.lineLabel.Text = "--------------------------------------------------------------------------";
            // 
            // AdoptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 705);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.adopterNumberlabel);
            this.Controls.Add(this.adopterAddresslabel);
            this.Controls.Add(this.adopterNameLabel);
            this.Controls.Add(this.searchBarLabel);
            this.Controls.Add(this.adoptButton);
            this.Controls.Add(this.adopterNumberTextBox);
            this.Controls.Add(this.adopterAddressTextBox);
            this.Controls.Add(this.adopterNameTextBox);
            this.Controls.Add(this.MRdioButton);
            this.Controls.Add(this.FRadioButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dogsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdoptionForm";
            this.Text = "AdoptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dogsListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton FRadioButton;
        private System.Windows.Forms.RadioButton MRdioButton;
        private System.Windows.Forms.TextBox adopterNameTextBox;
        private System.Windows.Forms.TextBox adopterAddressTextBox;
        private System.Windows.Forms.TextBox adopterNumberTextBox;
        private System.Windows.Forms.Button adoptButton;
        private System.Windows.Forms.Label searchBarLabel;
        private System.Windows.Forms.Label adopterNameLabel;
        private System.Windows.Forms.Label adopterAddresslabel;
        private System.Windows.Forms.Label adopterNumberlabel;
        private System.Windows.Forms.Label lineLabel;
    }
}