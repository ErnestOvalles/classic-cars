namespace Classic_Cars
{
    partial class ShowCatalog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loggedInInput = new System.Windows.Forms.Label();
            this.queryTypeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.queryTypeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 681);
            this.panel1.TabIndex = 0;
            // 
            // loggedInInput
            // 
            this.loggedInInput.AutoSize = true;
            this.loggedInInput.Location = new System.Drawing.Point(13, 13);
            this.loggedInInput.Name = "loggedInInput";
            this.loggedInInput.Size = new System.Drawing.Size(35, 13);
            this.loggedInInput.TabIndex = 1;
            this.loggedInInput.Text = "label1";
            this.loggedInInput.Visible = false;
            // 
            // queryTypeLabel
            // 
            this.queryTypeLabel.AutoSize = true;
            this.queryTypeLabel.Location = new System.Drawing.Point(55, 13);
            this.queryTypeLabel.Name = "queryTypeLabel";
            this.queryTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.queryTypeLabel.TabIndex = 0;
            this.queryTypeLabel.Text = "label1";
            this.queryTypeLabel.Visible = false;
            // 
            // ShowCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.loggedInInput);
            this.Controls.Add(this.panel1);
            this.Name = "ShowCatalog";
            this.Text = "ShowCatalog";
            this.Load += new System.EventHandler(this.ShowCatalog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loggedInInput;
        private System.Windows.Forms.Label queryTypeLabel;
    }
}