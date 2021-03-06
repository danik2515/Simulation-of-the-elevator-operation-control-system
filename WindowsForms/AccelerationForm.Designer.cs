namespace WindowsForms {
    partial class AccelerationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccelerationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.AccelerationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter coefficient of amplification";
            // 
            // SetButton
            // 
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetButton.Location = new System.Drawing.Point(100, 94);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // AccelerationTextBox
            // 
            this.AccelerationTextBox.AllowPromptAsInput = false;
            this.AccelerationTextBox.AsciiOnly = true;
            this.AccelerationTextBox.Location = new System.Drawing.Point(125, 54);
            this.AccelerationTextBox.Name = "AccelerationTextBox";
            this.AccelerationTextBox.PromptChar = ' ';
            this.AccelerationTextBox.Size = new System.Drawing.Size(24, 20);
            this.AccelerationTextBox.TabIndex = 3;
            // 
            // AccelerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(265, 143);
            this.Controls.Add(this.AccelerationTextBox);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.label1);
            this.Name = "AccelerationForm";
            this.Text = "AccelerationForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.MaskedTextBox AccelerationTextBox;
    }
}