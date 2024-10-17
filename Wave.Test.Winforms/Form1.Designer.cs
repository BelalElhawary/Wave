namespace Wave.Test.Winforms
{
    partial class Form1
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
            skControl1 = new SkiaSharp.Views.Desktop.SKControl();
            SuspendLayout();
            // 
            // skControl1
            // 
            skControl1.Dock = DockStyle.Fill;
            skControl1.Location = new Point(0, 0);
            skControl1.Margin = new Padding(41, 19, 41, 19);
            skControl1.Name = "skControl1";
            skControl1.Size = new Size(1924, 1061);
            skControl1.TabIndex = 0;
            skControl1.Text = "skControl1";
            skControl1.PaintSurface += skControl1_PaintSurface;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1924, 1061);
            Controls.Add(skControl1);
            Margin = new Padding(41, 19, 41, 19);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private SkiaSharp.Views.Desktop.SKControl skControl1;
    }
}
