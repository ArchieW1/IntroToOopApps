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
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthComboBox = new System.Windows.Forms.ComboBox();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.ColourComboBox = new System.Windows.Forms.ComboBox();
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.ShapeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.CanvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPictureBox
            // 
            this.CanvasPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.CanvasPictureBox.Location = new System.Drawing.Point(89, 12);
            this.CanvasPictureBox.Name = "CanvasPictureBox";
            this.CanvasPictureBox.Size = new System.Drawing.Size(927, 632);
            this.CanvasPictureBox.TabIndex = 0;
            this.CanvasPictureBox.TabStop = false;
            this.CanvasPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPictureBox_Paint);
            this.CanvasPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPictureBox_MouseDown);
            this.CanvasPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPictureBox_MouseMove);
            this.CanvasPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasPictureBox_MouseUp);
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(12, 9);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(36, 20);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width";
            // 
            // WidthComboBox
            // 
            this.WidthComboBox.DisplayMember = "(none)";
            this.WidthComboBox.FormattingEnabled = true;
            this.WidthComboBox.Items.AddRange(new object[] {"Thin", "Medium", "Thick"});
            this.WidthComboBox.Location = new System.Drawing.Point(12, 32);
            this.WidthComboBox.Name = "WidthComboBox";
            this.WidthComboBox.Size = new System.Drawing.Size(71, 21);
            this.WidthComboBox.TabIndex = 2;
            this.WidthComboBox.SelectedIndexChanged += new System.EventHandler(this.WidthComboBox_SelectedIndexChanged);
            // 
            // ColourLabel
            // 
            this.ColourLabel.Location = new System.Drawing.Point(12, 56);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(39, 17);
            this.ColourLabel.TabIndex = 3;
            this.ColourLabel.Text = "Colour";
            // 
            // ColourComboBox
            // 
            this.ColourComboBox.FormattingEnabled = true;
            this.ColourComboBox.Items.AddRange(new object[] {"Black", "Red", "Blue", "Green"});
            this.ColourComboBox.Location = new System.Drawing.Point(12, 76);
            this.ColourComboBox.Name = "ColourComboBox";
            this.ColourComboBox.Size = new System.Drawing.Size(71, 21);
            this.ColourComboBox.TabIndex = 4;
            this.ColourComboBox.SelectedIndexChanged += new System.EventHandler(this.ColourComboBox_SelectedIndexChanged);
            // 
            // ShapeComboBox
            // 
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Items.AddRange(new object[] {"Line", "Rectangle"});
            this.ShapeComboBox.Location = new System.Drawing.Point(12, 123);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(71, 21);
            this.ShapeComboBox.TabIndex = 5;
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.Location = new System.Drawing.Point(12, 100);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(53, 20);
            this.ShapeLabel.TabIndex = 6;
            this.ShapeLabel.Text = "Shape";
            // 
            // OopDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 656);
            this.Controls.Add(this.ShapeLabel);
            this.Controls.Add(this.ShapeComboBox);
            this.Controls.Add(this.ColourComboBox);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.WidthComboBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.CanvasPictureBox);
            this.Name = "OopDrawForm";
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize) (this.CanvasPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ShapeLabel;

        private System.Windows.Forms.ComboBox ShapeComboBox;

        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.ComboBox ColourComboBox;

        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.ComboBox WidthComboBox;

        private System.Windows.Forms.PictureBox CanvasPictureBox;

        #endregion
    }
}