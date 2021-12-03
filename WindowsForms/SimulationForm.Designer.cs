﻿namespace WindowsForms {
    partial class SimulationForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hnwnhnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accelerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlHumalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHumansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(962, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulation";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hnwnhnToolStripMenuItem,
            this.controlHumalToolStripMenuItem,
            this.fireAlarmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hnwnhnToolStripMenuItem
            // 
            this.hnwnhnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accelerateToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.showInformationToolStripMenuItem});
            this.hnwnhnToolStripMenuItem.Name = "hnwnhnToolStripMenuItem";
            this.hnwnhnToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.hnwnhnToolStripMenuItem.Text = "Control process";
            // 
            // accelerateToolStripMenuItem
            // 
            this.accelerateToolStripMenuItem.Name = "accelerateToolStripMenuItem";
            this.accelerateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.accelerateToolStripMenuItem.Text = "Acceleration";
            this.accelerateToolStripMenuItem.Click += new System.EventHandler(this.accelerateToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // showInformationToolStripMenuItem
            // 
            this.showInformationToolStripMenuItem.Name = "showInformationToolStripMenuItem";
            this.showInformationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showInformationToolStripMenuItem.Text = "Show information";
            this.showInformationToolStripMenuItem.Click += new System.EventHandler(this.showInformationToolStripMenuItem_Click);
            // 
            // controlHumalToolStripMenuItem
            // 
            this.controlHumalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.addHumansToolStripMenuItem});
            this.controlHumalToolStripMenuItem.Name = "controlHumalToolStripMenuItem";
            this.controlHumalToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.controlHumalToolStripMenuItem.Text = " Control human system";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.statusToolStripMenuItem.Text = "Show Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // addHumansToolStripMenuItem
            // 
            this.addHumansToolStripMenuItem.Name = "addHumansToolStripMenuItem";
            this.addHumansToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addHumansToolStripMenuItem.Text = "Add humans";
            this.addHumansToolStripMenuItem.Click += new System.EventHandler(this.addHumansToolStripMenuItem_Click);
            // 
            // fireAlarmToolStripMenuItem
            // 
            this.fireAlarmToolStripMenuItem.Name = "fireAlarmToolStripMenuItem";
            this.fireAlarmToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.fireAlarmToolStripMenuItem.Text = "Fire alarm";
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Location = new System.Drawing.Point(980, 428);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(75, 23);
            this.ShutdownButton.TabIndex = 5;
            this.ShutdownButton.Text = "Shutdown";
            this.ShutdownButton.UseVisualStyleBackColor = true;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1067, 463);
            this.Controls.Add(this.ShutdownButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulationForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hnwnhnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accelerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlHumalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHumansToolStripMenuItem;
        private System.Windows.Forms.Button ShutdownButton;
    }
}