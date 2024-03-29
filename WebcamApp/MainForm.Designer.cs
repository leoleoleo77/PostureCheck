﻿namespace WebcamApp
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.mainCamera = new System.Windows.Forms.PictureBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.MomentsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.folderLabel = new System.Windows.Forms.LinkLabel();
            this.cameraText = new System.Windows.Forms.RichTextBox();
            this.assistPicBox = new System.Windows.Forms.PictureBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCaptureFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noMomentsText = new System.Windows.Forms.RichTextBox();
            this.searchCameraTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.stopwatchTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistPicBox)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnStart.Location = new System.Drawing.Point(20, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Capturing";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // captureTimer
            // 
            this.captureTimer.Interval = 3000;
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // mainCamera
            // 
            this.mainCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.mainCamera.Location = new System.Drawing.Point(25, 92);
            this.mainCamera.Name = "mainCamera";
            this.mainCamera.Size = new System.Drawing.Size(900, 508);
            this.mainCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainCamera.TabIndex = 2;
            this.mainCamera.TabStop = false;
            this.mainCamera.Click += new System.EventHandler(this.mainCamera_Click);
            // 
            // MomentsPanel
            // 
            this.MomentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MomentsPanel.ColumnCount = 1;
            this.MomentsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MomentsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MomentsPanel.Location = new System.Drawing.Point(944, 45);
            this.MomentsPanel.Name = "MomentsPanel";
            this.MomentsPanel.RowCount = 1;
            this.MomentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MomentsPanel.Size = new System.Drawing.Size(250, 585);
            this.MomentsPanel.TabIndex = 11;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(941, 633);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(74, 13);
            this.folderLabel.TabIndex = 12;
            this.folderLabel.TabStop = true;
            this.folderLabel.Text = "Show in folder";
            this.folderLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.folderLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.folderLabel_LinkClicked);
            // 
            // cameraText
            // 
            this.cameraText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cameraText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cameraText.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cameraText.Location = new System.Drawing.Point(157, 270);
            this.cameraText.Name = "cameraText";
            this.cameraText.ReadOnly = true;
            this.cameraText.Size = new System.Drawing.Size(900, 13);
            this.cameraText.TabIndex = 13;
            this.cameraText.Text = "Press the \"Start Capturing\" button to begin capturing";
            this.cameraText.TextChanged += new System.EventHandler(this.cameraText_TextChanged);
            // 
            // assistPicBox
            // 
            this.assistPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.assistPicBox.Location = new System.Drawing.Point(25, 91);
            this.assistPicBox.Name = "assistPicBox";
            this.assistPicBox.Size = new System.Drawing.Size(900, 508);
            this.assistPicBox.TabIndex = 16;
            this.assistPicBox.TabStop = false;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnPause);
            this.btnPanel.Controls.Add(this.btnStart);
            this.btnPanel.Location = new System.Drawing.Point(326, 606);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(301, 29);
            this.btnPanel.TabIndex = 17;
            this.btnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPanel_Paint);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnPause.Location = new System.Drawing.Point(152, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(126, 23);
            this.btnPause.TabIndex = 15;
            this.btnPause.Text = "Pause Video";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.showCaptureFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // showCaptureFolderToolStripMenuItem
            // 
            this.showCaptureFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.showCaptureFolderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.showCaptureFolderToolStripMenuItem.Name = "showCaptureFolderToolStripMenuItem";
            this.showCaptureFolderToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showCaptureFolderToolStripMenuItem.Text = "Show Capture Folder";
            this.showCaptureFolderToolStripMenuItem.Click += new System.EventHandler(this.showCaptureFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // noMomentsText
            // 
            this.noMomentsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.noMomentsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noMomentsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.noMomentsText.Location = new System.Drawing.Point(857, 27);
            this.noMomentsText.Name = "noMomentsText";
            this.noMomentsText.ReadOnly = true;
            this.noMomentsText.Size = new System.Drawing.Size(68, 45);
            this.noMomentsText.TabIndex = 20;
            this.noMomentsText.Text = "No moments captured yet";
            // 
            // searchCameraTimer
            // 
            this.searchCameraTimer.Interval = 500;
            this.searchCameraTimer.Tick += new System.EventHandler(this.searchCameraTimer_Tick);
            // 
            // bottomMenu
            // 
            this.bottomMenu.AutoSize = true;
            this.bottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.bottomMenu.Location = new System.Drawing.Point(0, 682);
            this.bottomMenu.MaximumSize = new System.Drawing.Size(0, 24);
            this.bottomMenu.Name = "bottomMenu";
            this.bottomMenu.Size = new System.Drawing.Size(1084, 0);
            this.bottomMenu.TabIndex = 21;
            // 
            // stopwatchTimer
            // 
            this.stopwatchTimer.Interval = 1000;
            this.stopwatchTimer.Tick += new System.EventHandler(this.stopwatchTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1084, 682);
            this.Controls.Add(this.bottomMenu);
            this.Controls.Add(this.noMomentsText);
            this.Controls.Add(this.cameraText);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.MomentsPanel);
            this.Controls.Add(this.mainCamera);
            this.Controls.Add(this.assistPicBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(796, 588);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostureCheck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.mainCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistPicBox)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Timer captureTimer;
        public System.Windows.Forms.PictureBox mainCamera;
        private System.ServiceProcess.ServiceController serviceController1;
        public System.Windows.Forms.TableLayoutPanel MomentsPanel;
        private System.Windows.Forms.LinkLabel folderLabel;
        public System.Windows.Forms.RichTextBox cameraText;
        private System.Windows.Forms.PictureBox assistPicBox;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCaptureFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox noMomentsText;
        private System.Windows.Forms.Timer searchCameraTimer;
        private System.Windows.Forms.FlowLayoutPanel bottomMenu;
        private System.Windows.Forms.Timer stopwatchTimer;
    }
}

