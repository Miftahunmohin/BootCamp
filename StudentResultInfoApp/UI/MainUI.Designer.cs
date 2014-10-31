namespace StudentResultInfoApp
{
    partial class MainUI
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
            this.enrollButton = new System.Windows.Forms.Button();
            this.enrollResultButton = new System.Windows.Forms.Button();
            this.showResultSheetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(184, 35);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(132, 46);
            this.enrollButton.TabIndex = 0;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // enrollResultButton
            // 
            this.enrollResultButton.Location = new System.Drawing.Point(184, 98);
            this.enrollResultButton.Name = "enrollResultButton";
            this.enrollResultButton.Size = new System.Drawing.Size(132, 46);
            this.enrollResultButton.TabIndex = 0;
            this.enrollResultButton.Text = "Enroll Result";
            this.enrollResultButton.UseVisualStyleBackColor = true;
            this.enrollResultButton.Click += new System.EventHandler(this.enrollResultButton_Click);
            // 
            // showResultSheetButton
            // 
            this.showResultSheetButton.Location = new System.Drawing.Point(184, 162);
            this.showResultSheetButton.Name = "showResultSheetButton";
            this.showResultSheetButton.Size = new System.Drawing.Size(132, 42);
            this.showResultSheetButton.TabIndex = 0;
            this.showResultSheetButton.Text = "Show Result Sheet";
            this.showResultSheetButton.UseVisualStyleBackColor = true;
            this.showResultSheetButton.Click += new System.EventHandler(this.showResultSheetButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 289);
            this.Controls.Add(this.showResultSheetButton);
            this.Controls.Add(this.enrollResultButton);
            this.Controls.Add(this.enrollButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button enrollResultButton;
        private System.Windows.Forms.Button showResultSheetButton;
    }
}

