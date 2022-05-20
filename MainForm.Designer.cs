namespace dogShelter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.adoptButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.timesheetButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adoptButton
            // 
            this.adoptButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adoptButton.Font = new System.Drawing.Font("Lucida Fax", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adoptButton.Location = new System.Drawing.Point(242, 326);
            this.adoptButton.Name = "adoptButton";
            this.adoptButton.Size = new System.Drawing.Size(216, 51);
            this.adoptButton.TabIndex = 0;
            this.adoptButton.Text = "Adopt";
            this.adoptButton.UseVisualStyleBackColor = false;
            this.adoptButton.Click += new System.EventHandler(this.adoptButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerButton.Font = new System.Drawing.Font("Lucida Fax", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButton.Location = new System.Drawing.Point(521, 327);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(216, 50);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // timesheetButton
            // 
            this.timesheetButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timesheetButton.Font = new System.Drawing.Font("Lucida Fax", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesheetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timesheetButton.Location = new System.Drawing.Point(800, 327);
            this.timesheetButton.Name = "timesheetButton";
            this.timesheetButton.Size = new System.Drawing.Size(216, 50);
            this.timesheetButton.TabIndex = 2;
            this.timesheetButton.Text = "Timesheet";
            this.timesheetButton.UseVisualStyleBackColor = false;
            this.timesheetButton.Click += new System.EventHandler(this.timesheetButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Lucida Fax", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(381, 135);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(526, 92);
            this.label.TabIndex = 3;
            this.label.Text = "Dog Shelter";
            this.label.Click += new System.EventHandler(this.label_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 558);
            this.Controls.Add(this.label);
            this.Controls.Add(this.timesheetButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.adoptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adoptButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button timesheetButton;
        private System.Windows.Forms.Label label;
    }
}

