using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classic_Cars
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(12, (128) + 25);
            panel.Name = "panel0";
            panel.Size = new System.Drawing.Size(1040, 200);
            panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel.TabIndex = 0;

            Button button = new Button();
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Location = new System.Drawing.Point(894, 3);
            button.Name = "button0";
            button.Size = new System.Drawing.Size(143, 100);
            button.TabIndex = 3;
            button.Text = "Add to Cart";
            button.UseVisualStyleBackColor = true;

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            richTextBox.Location = new System.Drawing.Point(233, 3);
            richTextBox.Name = "richTextBox0";
            richTextBox.Size = new System.Drawing.Size(655, 194);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";

            PictureBox picture = new PictureBox();
            picture.Location = new System.Drawing.Point(3, 3);
            picture.Name = "pictureBox0";
            picture.Size = new System.Drawing.Size(224, 194);
            picture.TabIndex = 0;
            picture.TabStop = false;

            panel.Controls.Add(button);
            panel.Controls.Add(richTextBox);
            panel.Controls.Add(picture);

            this.Controls.Add(panel);
        }
    }
}
