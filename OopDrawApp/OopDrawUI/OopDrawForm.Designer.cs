namespace OopDrawUI
{
    sealed partial class OopDrawForm
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
            this.CanvasPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.CanvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPictureBox
            // 
            this.CanvasPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.CanvasPictureBox.Location = new System.Drawing.Point(144, 12);
            this.CanvasPictureBox.Name = "CanvasPictureBox";
            this.CanvasPictureBox.Size = new System.Drawing.Size(644, 426);
            this.CanvasPictureBox.TabIndex = 0;
            this.CanvasPictureBox.TabStop = false;
            this.CanvasPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPictureBox_Paint);
            this.CanvasPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPictureBox_MouseDown);
            this.CanvasPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPictureBox_MouseMove);
            this.CanvasPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasPictureBox_MouseUp);
            // 
            // OopDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CanvasPictureBox);
            this.Name = "OopDrawForm";
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize) (this.CanvasPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox CanvasPictureBox;

        #endregion
    }
}