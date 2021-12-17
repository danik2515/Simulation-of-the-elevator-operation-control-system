namespace WindowsForms {
    partial class HumanStatusForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanStatusForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HumanListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartLable = new System.Windows.Forms.Label();
            this.TargetLable = new System.Windows.Forms.Label();
            this.StatusLable = new System.Windows.Forms.Label();
            this.waitingTimeLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HumanNumLable = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elevator waiting time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target floor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start floor:";
            // 
            // HumanListBox
            // 
            this.HumanListBox.FormattingEnabled = true;
            this.HumanListBox.Location = new System.Drawing.Point(43, 153);
            this.HumanListBox.Name = "HumanListBox";
            this.HumanListBox.Size = new System.Drawing.Size(142, 108);
            this.HumanListBox.TabIndex = 3;
            this.HumanListBox.SelectedIndexChanged += new System.EventHandler(this.HumanListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current status:";
            // 
            // StartLable
            // 
            this.StartLable.AutoSize = true;
            this.StartLable.Location = new System.Drawing.Point(101, 48);
            this.StartLable.Name = "StartLable";
            this.StartLable.Size = new System.Drawing.Size(10, 13);
            this.StartLable.TabIndex = 8;
            this.StartLable.Text = " ";
            // 
            // TargetLable
            // 
            this.TargetLable.AutoSize = true;
            this.TargetLable.Location = new System.Drawing.Point(107, 75);
            this.TargetLable.Name = "TargetLable";
            this.TargetLable.Size = new System.Drawing.Size(10, 13);
            this.TargetLable.TabIndex = 9;
            this.TargetLable.Text = " ";
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.Location = new System.Drawing.Point(118, 100);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(10, 13);
            this.StatusLable.TabIndex = 10;
            this.StatusLable.Text = " ";
            // 
            // waitingTimeLable
            // 
            this.waitingTimeLable.AutoSize = true;
            this.waitingTimeLable.Location = new System.Drawing.Point(150, 124);
            this.waitingTimeLable.Name = "waitingTimeLable";
            this.waitingTimeLable.Size = new System.Drawing.Size(10, 13);
            this.waitingTimeLable.TabIndex = 11;
            this.waitingTimeLable.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Human №:";
            // 
            // HumanNumLable
            // 
            this.HumanNumLable.AutoSize = true;
            this.HumanNumLable.Location = new System.Drawing.Point(104, 20);
            this.HumanNumLable.Name = "HumanNumLable";
            this.HumanNumLable.Size = new System.Drawing.Size(10, 13);
            this.HumanNumLable.TabIndex = 13;
            this.HumanNumLable.Text = " ";
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // HumanStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(227, 289);
            this.Controls.Add(this.HumanNumLable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.waitingTimeLable);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.TargetLable);
            this.Controls.Add(this.StartLable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HumanListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HumanStatusForm";
            this.Text = "HumanStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox HumanListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StartLable;
        private System.Windows.Forms.Label TargetLable;
        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.Label waitingTimeLable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HumanNumLable;
        private System.Windows.Forms.Timer timerStatus;
    }
}