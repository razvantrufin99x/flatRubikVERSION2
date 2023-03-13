namespace flatRubik
{
    partial class ball
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Name = "ball";
            this.Size = new System.Drawing.Size(18, 19);
            this.Load += new System.EventHandler(this.ball_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ball_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ball_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ball_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
