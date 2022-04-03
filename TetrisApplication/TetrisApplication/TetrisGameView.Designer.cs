namespace TetrisApplication
{
    partial class TetrisGameView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tetrisViewMinitor1 = new TetrisApplication.TetrisViewMinitor();
            this.SuspendLayout();
            // 
            // tetrisViewMinitor1
            // 
            this.tetrisViewMinitor1.BackColor = System.Drawing.Color.White;
            this.tetrisViewMinitor1.Location = new System.Drawing.Point(16, 0);
            this.tetrisViewMinitor1.Name = "tetrisViewMinitor1";
            this.tetrisViewMinitor1.Size = new System.Drawing.Size(370, 523);
            this.tetrisViewMinitor1.TabIndex = 0;
            // 
            // TetrisGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tetrisViewMinitor1);
            this.Name = "TetrisGameView";
            this.Size = new System.Drawing.Size(403, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private TetrisViewMinitor tetrisViewMinitor1;
    }
}
