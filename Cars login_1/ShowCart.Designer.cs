namespace Classic_Cars
{
    partial class ShowCart
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
            this.closeBTN = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.showPurchasesBTN = new System.Windows.Forms.Button();
            this.checkOutBTN = new System.Windows.Forms.Button();
            this.TotalLabelIn = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.closeBTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.Transparent;
            this.closeBTN.Controls.Add(this.button1);
            this.closeBTN.Controls.Add(this.cartLabel);
            this.closeBTN.Controls.Add(this.showPurchasesBTN);
            this.closeBTN.Controls.Add(this.checkOutBTN);
            this.closeBTN.Controls.Add(this.TotalLabelIn);
            this.closeBTN.Controls.Add(this.TotalLabel);
            this.closeBTN.Location = new System.Drawing.Point(7, 12);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(1045, 100);
            this.closeBTN.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(917, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel.Location = new System.Drawing.Point(47, 61);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(175, 29);
            this.cartLabel.TabIndex = 4;
            this.cartLabel.Text = "CART ITEMS:";
            // 
            // showPurchasesBTN
            // 
            this.showPurchasesBTN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.showPurchasesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPurchasesBTN.Location = new System.Drawing.Point(678, 32);
            this.showPurchasesBTN.Name = "showPurchasesBTN";
            this.showPurchasesBTN.Size = new System.Drawing.Size(233, 41);
            this.showPurchasesBTN.TabIndex = 3;
            this.showPurchasesBTN.Text = "Show Purchases";
            this.showPurchasesBTN.UseVisualStyleBackColor = false;
            this.showPurchasesBTN.Click += new System.EventHandler(this.ShowPurchasesBTN_Click);
            // 
            // checkOutBTN
            // 
            this.checkOutBTN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkOutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBTN.Location = new System.Drawing.Point(439, 32);
            this.checkOutBTN.Name = "checkOutBTN";
            this.checkOutBTN.Size = new System.Drawing.Size(233, 41);
            this.checkOutBTN.TabIndex = 2;
            this.checkOutBTN.Text = "Checkout";
            this.checkOutBTN.UseVisualStyleBackColor = false;
            // 
            // TotalLabelIn
            // 
            this.TotalLabelIn.AutoSize = true;
            this.TotalLabelIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabelIn.Location = new System.Drawing.Point(157, 22);
            this.TotalLabelIn.Name = "TotalLabelIn";
            this.TotalLabelIn.Size = new System.Drawing.Size(78, 29);
            this.TotalLabelIn.TabIndex = 1;
            this.TotalLabelIn.Text = "NULL";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(47, 22);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(104, 29);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "TOTAL:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 551);
            this.dataGridView1.TabIndex = 1;
            // 
            // ShowCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Classic_Cars.Properties.Resources.IMG_0166;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeBTN);
            this.DoubleBuffered = true;
            this.Name = "ShowCart";
            this.Text = "ShowCart";
            this.closeBTN.ResumeLayout(false);
            this.closeBTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel closeBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Button showPurchasesBTN;
        private System.Windows.Forms.Button checkOutBTN;
        private System.Windows.Forms.Label TotalLabelIn;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}