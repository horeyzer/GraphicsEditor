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
            this.None = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // None
            // 
            this.None.Location = new System.Drawing.Point(12, 12);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(75, 23);
            this.None.TabIndex = 0;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            this.None.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 397);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(93, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 2;
            this.btnLine.Tag = "btn_Line_Click";
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(174, 12);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Tag = "btnCircle";
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(255, 12);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(75, 23);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Tag = "btnEllipse";
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

