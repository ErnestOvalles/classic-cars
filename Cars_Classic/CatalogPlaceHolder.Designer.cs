namespace Classic_Cars
{
    partial class CatalogPlaceHolder
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1134, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cart Placeholder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CatalogPlaceHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Classic_Cars.Properties.Resources.IMG_0166;
            this.ClientSize = new System.Drawing.Size(1518, 793);
            this.Controls.Add(this.button1);
            this.Name = "CatalogPlaceHolder";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}