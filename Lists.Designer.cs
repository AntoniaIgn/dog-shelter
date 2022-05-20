namespace dogShelter
{
    partial class Lists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lists));
            this.dogsListBox = new System.Windows.Forms.ListBox();
            this.adoptedDogsListBox = new System.Windows.Forms.ListBox();
            this.dogsLabel = new System.Windows.Forms.Label();
            this.adoptedDogsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dogsListBox
            // 
            this.dogsListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dogsListBox.DisplayMember = "Dog.Name";
            this.dogsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogsListBox.FormattingEnabled = true;
            this.dogsListBox.ItemHeight = 20;
            this.dogsListBox.Location = new System.Drawing.Point(41, 77);
            this.dogsListBox.Name = "dogsListBox";
            this.dogsListBox.Size = new System.Drawing.Size(169, 224);
            this.dogsListBox.TabIndex = 0;
            // 
            // adoptedDogsListBox
            // 
            this.adoptedDogsListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.adoptedDogsListBox.DisplayMember = "Dog.Name";
            this.adoptedDogsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptedDogsListBox.ForeColor = System.Drawing.Color.Black;
            this.adoptedDogsListBox.FormattingEnabled = true;
            this.adoptedDogsListBox.ItemHeight = 20;
            this.adoptedDogsListBox.Location = new System.Drawing.Point(226, 77);
            this.adoptedDogsListBox.Name = "adoptedDogsListBox";
            this.adoptedDogsListBox.Size = new System.Drawing.Size(169, 224);
            this.adoptedDogsListBox.TabIndex = 1;
            // 
            // dogsLabel
            // 
            this.dogsLabel.AutoSize = true;
            this.dogsLabel.Font = new System.Drawing.Font("Lucida Fax", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogsLabel.Location = new System.Drawing.Point(38, 48);
            this.dogsLabel.Name = "dogsLabel";
            this.dogsLabel.Size = new System.Drawing.Size(73, 27);
            this.dogsLabel.TabIndex = 2;
            this.dogsLabel.Text = "Dogs";
            // 
            // adoptedDogsLabel
            // 
            this.adoptedDogsLabel.AutoSize = true;
            this.adoptedDogsLabel.Font = new System.Drawing.Font("Lucida Fax", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptedDogsLabel.Location = new System.Drawing.Point(223, 48);
            this.adoptedDogsLabel.Name = "adoptedDogsLabel";
            this.adoptedDogsLabel.Size = new System.Drawing.Size(176, 27);
            this.adoptedDogsLabel.TabIndex = 3;
            this.adoptedDogsLabel.Text = "Adopted dogs";
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 363);
            this.Controls.Add(this.adoptedDogsLabel);
            this.Controls.Add(this.dogsLabel);
            this.Controls.Add(this.adoptedDogsListBox);
            this.Controls.Add(this.dogsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lists";
            this.Text = "Lists";
            this.Load += new System.EventHandler(this.Lists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dogsListBox;
        private System.Windows.Forms.ListBox adoptedDogsListBox;
        private System.Windows.Forms.Label dogsLabel;
        private System.Windows.Forms.Label adoptedDogsLabel;
    }
}