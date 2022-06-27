﻿namespace SnakeGame
{
    partial class FormMain
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
            this.playingField = new SnakeGame.RendererPlayingField();
            this.SuspendLayout();
            // 
            // playingField
            // 
            this.playingField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playingField.Location = new System.Drawing.Point(0, 0);
            this.playingField.Name = "playingField";
            this.playingField.Size = new System.Drawing.Size(784, 761);
            this.playingField.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.playingField);
            this.Name = "FormMain";
            this.Text = "Змейка";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private RendererPlayingField playingField;
    }
}