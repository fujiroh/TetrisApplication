using System.Windows.Forms;

namespace TetrisApplication
{
    partial class TetrisMainApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tetrisField1 = new TetrisApplication.TetrisField();
            this.SuspendLayout();
            // 
            // tetrisField1
            // 
            this.tetrisField1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tetrisField1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tetrisField1.Location = new System.Drawing.Point(0, 0);
            this.tetrisField1.Name = "tetrisField1";
            this.tetrisField1.Size = new System.Drawing.Size(287, 576);
            this.tetrisField1.TabIndex = 0;
            // 
            // TetrisMainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 576);
            this.Controls.Add(this.tetrisField1);
            this.DoubleBuffered = true;
            this.Name = "TetrisMainApplication";
            this.Text = "Tetris";
            this.ResumeLayout(false);

        }

        #endregion

        private TetrisField tetrisField1;
    }
}