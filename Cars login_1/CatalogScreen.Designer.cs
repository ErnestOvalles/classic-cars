namespace Classic_Cars
{
    partial class CatalogScreen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.goToCartBTN = new System.Windows.Forms.Button();
            this.viewPurchasesBTN = new System.Windows.Forms.Button();
            this.signOutBTN = new System.Windows.Forms.Button();
            this.loggedInInput = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loggedInAs = new System.Windows.Forms.Label();
            this.categoryClassic = new System.Windows.Forms.Button();
            this.categorySUV = new System.Windows.Forms.Button();
            this.categorySedan = new System.Windows.Forms.Button();
            this.categoryAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.categoryAll);
            this.panel2.Controls.Add(this.categorySedan);
            this.panel2.Controls.Add(this.categorySUV);
            this.panel2.Controls.Add(this.categoryClassic);
            this.panel2.Controls.Add(this.goToCartBTN);
            this.panel2.Controls.Add(this.viewPurchasesBTN);
            this.panel2.Controls.Add(this.signOutBTN);
            this.panel2.Controls.Add(this.loggedInInput);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.loggedInAs);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 200);
            this.panel2.TabIndex = 1;
            // 
            // goToCartBTN
            // 
            this.goToCartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToCartBTN.Location = new System.Drawing.Point(854, 41);
            this.goToCartBTN.Name = "goToCartBTN";
            this.goToCartBTN.Size = new System.Drawing.Size(143, 32);
            this.goToCartBTN.TabIndex = 6;
            this.goToCartBTN.Text = "Go to Cart";
            this.goToCartBTN.UseVisualStyleBackColor = true;
            // 
            // viewPurchasesBTN
            // 
            this.viewPurchasesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPurchasesBTN.Location = new System.Drawing.Point(125, 48);
            this.viewPurchasesBTN.Name = "viewPurchasesBTN";
            this.viewPurchasesBTN.Size = new System.Drawing.Size(183, 32);
            this.viewPurchasesBTN.TabIndex = 5;
            this.viewPurchasesBTN.Text = "View Purchases";
            this.viewPurchasesBTN.UseVisualStyleBackColor = true;
            this.viewPurchasesBTN.Click += new System.EventHandler(this.ViewPurchasesBTN_Click);
            // 
            // signOutBTN
            // 
            this.signOutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutBTN.Location = new System.Drawing.Point(896, 3);
            this.signOutBTN.Name = "signOutBTN";
            this.signOutBTN.Size = new System.Drawing.Size(101, 32);
            this.signOutBTN.TabIndex = 4;
            this.signOutBTN.Text = "Sign Out";
            this.signOutBTN.UseVisualStyleBackColor = true;
            this.signOutBTN.Click += new System.EventHandler(this.SignOutBTN_Click);
            // 
            // loggedInInput
            // 
            this.loggedInInput.AutoSize = true;
            this.loggedInInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInInput.Location = new System.Drawing.Point(302, 14);
            this.loggedInInput.Name = "loggedInInput";
            this.loggedInInput.Size = new System.Drawing.Size(78, 29);
            this.loggedInInput.TabIndex = 3;
            this.loggedInInput.Text = "NULL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Classic_Cars.Properties.Resources.IMG_01711;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Classic_Cars.Properties.Resources.IMG_01711;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 100);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // loggedInAs
            // 
            this.loggedInAs.AutoSize = true;
            this.loggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInAs.Location = new System.Drawing.Point(125, 14);
            this.loggedInAs.Name = "loggedInAs";
            this.loggedInAs.Size = new System.Drawing.Size(171, 29);
            this.loggedInAs.TabIndex = 0;
            this.loggedInAs.Text = "Logged in as:";
            // 
            // categoryClassic
            // 
            this.categoryClassic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryClassic.Location = new System.Drawing.Point(451, 146);
            this.categoryClassic.Name = "categoryClassic";
            this.categoryClassic.Size = new System.Drawing.Size(178, 51);
            this.categoryClassic.TabIndex = 7;
            this.categoryClassic.Text = "Classics";
            this.categoryClassic.UseVisualStyleBackColor = true;
            this.categoryClassic.Click += new System.EventHandler(this.CategorySelectBTN_Click);
            // 
            // categorySUV
            // 
            this.categorySUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySUV.Location = new System.Drawing.Point(635, 146);
            this.categorySUV.Name = "categorySUV";
            this.categorySUV.Size = new System.Drawing.Size(178, 51);
            this.categorySUV.TabIndex = 8;
            this.categorySUV.Text = "SUV";
            this.categorySUV.UseVisualStyleBackColor = true;
            this.categorySUV.Click += new System.EventHandler(this.CategorySelectBTN_Click);
            // 
            // categorySedan
            // 
            this.categorySedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySedan.Location = new System.Drawing.Point(819, 146);
            this.categorySedan.Name = "categorySedan";
            this.categorySedan.Size = new System.Drawing.Size(178, 51);
            this.categorySedan.TabIndex = 9;
            this.categorySedan.Text = "Sedans";
            this.categorySedan.UseVisualStyleBackColor = true;
            this.categorySedan.Click += new System.EventHandler(this.CategorySelectBTN_Click);
            // 
            // categoryAll
            // 
            this.categoryAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryAll.Location = new System.Drawing.Point(267, 146);
            this.categoryAll.Name = "categoryAll";
            this.categoryAll.Size = new System.Drawing.Size(178, 51);
            this.categoryAll.TabIndex = 10;
            this.categoryAll.Text = "All";
            this.categoryAll.UseVisualStyleBackColor = true;
            this.categoryAll.Click += new System.EventHandler(this.CategorySelectBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Car Type:";
            // 
            // CatalogScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Classic_Cars.Properties.Resources.IMG_0166;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "CatalogScreen";
            this.Text = "CatalogScreen";
            this.Load += new System.EventHandler(this.CatalogScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signOutBTN;
        private System.Windows.Forms.Label loggedInInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loggedInAs;
        private System.Windows.Forms.Button viewPurchasesBTN;
        private System.Windows.Forms.Button goToCartBTN;
        private System.Windows.Forms.Button categorySedan;
        private System.Windows.Forms.Button categorySUV;
        private System.Windows.Forms.Button categoryClassic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categoryAll;
    }
}