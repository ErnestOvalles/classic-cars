namespace Classic_Cars
{
    partial class SignUp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Classic_Cars.Properties.Resources.IMG_01711;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(579, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username ";
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usernameTB.Location = new System.Drawing.Point(643, 173);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(584, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordTB.Location = new System.Drawing.Point(643, 217);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 7;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(605, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emailTB.Location = new System.Drawing.Point(643, 257);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(506, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 316);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_signup.Location = new System.Drawing.Point(668, 283);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 12;
            this.btn_signup.Text = "Signup";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Location = new System.Drawing.Point(668, 312);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Go Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Classic_Cars.Properties.Resources.IMG_0162;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "SignUp";
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_back;
    }
}