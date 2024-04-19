namespace GraphicsEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.None = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // None
            // 
            this.None.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("None.BackgroundImage")));
            this.None.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.None.Location = new System.Drawing.Point(12, 14);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(50, 50);
            this.None.TabIndex = 0;
            this.None.UseVisualStyleBackColor = true;
            this.None.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 410);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLine.Location = new System.Drawing.Point(68, 14);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(50, 50);
            this.btnLine.TabIndex = 2;
            this.btnLine.Tag = "btn_Line_Click";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircle.BackgroundImage")));
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCircle.Location = new System.Drawing.Point(124, 14);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(50, 50);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Tag = "btnCircle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.BackgroundImage")));
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEllipse.Location = new System.Drawing.Point(180, 14);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(50, 50);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Tag = "btnEllipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFill.BackgroundImage")));
            this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFill.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.Location = new System.Drawing.Point(236, 13);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(50, 50);
            this.btnFill.TabIndex = 5;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseColor.BackgroundImage")));
            this.btnChooseColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChooseColor.Location = new System.Drawing.Point(757, 14);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(75, 49);
            this.btnChooseColor.TabIndex = 6;
            this.btnChooseColor.UseVisualStyleBackColor = true;
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEraser.BackgroundImage")));
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEraser.Location = new System.Drawing.Point(701, 14);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(50, 50);
            this.btnEraser.TabIndex = 7;
            this.btnEraser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 489);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.None);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button None;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnEraser;
    }
}

