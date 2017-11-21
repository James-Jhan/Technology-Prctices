namespace Technology_Practices
{
    partial class MainDialog
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
            this.Chapter1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chapter1
            // 
            this.Chapter1.Location = new System.Drawing.Point(69, 48);
            this.Chapter1.Name = "Chapter1";
            this.Chapter1.Size = new System.Drawing.Size(94, 47);
            this.Chapter1.TabIndex = 0;
            this.Chapter1.Text = "Chapter 1";
            this.Chapter1.UseVisualStyleBackColor = true;
            this.Chapter1.Click += new System.EventHandler(this.Chapter1_Click);
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.Chapter1);
            this.Name = "MainDialog";
            this.Text = "MainDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Chapter1;
    }
}