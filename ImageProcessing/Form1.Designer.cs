namespace ImageProcessing
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Same = new System.Windows.Forms.Button();
            this.Greyscale = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Inversion = new System.Windows.Forms.Button();
            this.Sepia = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(866, 102);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(152, 44);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open FIle";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(866, 171);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(152, 44);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // Same
            // 
            this.Same.Location = new System.Drawing.Point(866, 245);
            this.Same.Margin = new System.Windows.Forms.Padding(4);
            this.Same.Name = "Same";
            this.Same.Size = new System.Drawing.Size(152, 44);
            this.Same.TabIndex = 2;
            this.Same.Text = "Copy";
            this.Same.UseVisualStyleBackColor = true;
            this.Same.Click += new System.EventHandler(this.button3_Click);
            // 
            // Greyscale
            // 
            this.Greyscale.Location = new System.Drawing.Point(866, 320);
            this.Greyscale.Margin = new System.Windows.Forms.Padding(4);
            this.Greyscale.Name = "Greyscale";
            this.Greyscale.Size = new System.Drawing.Size(152, 44);
            this.Greyscale.TabIndex = 3;
            this.Greyscale.Text = "Greyscale";
            this.Greyscale.UseVisualStyleBackColor = true;
            this.Greyscale.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1248, 79);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(727, 551);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Inversion
            // 
            this.Inversion.Location = new System.Drawing.Point(866, 398);
            this.Inversion.Margin = new System.Windows.Forms.Padding(4);
            this.Inversion.Name = "Inversion";
            this.Inversion.Size = new System.Drawing.Size(152, 44);
            this.Inversion.TabIndex = 6;
            this.Inversion.Text = "Inversion";
            this.Inversion.UseVisualStyleBackColor = true;
            this.Inversion.Click += new System.EventHandler(this.Inversion_Click);
            // 
            // Sepia
            // 
            this.Sepia.Location = new System.Drawing.Point(866, 472);
            this.Sepia.Margin = new System.Windows.Forms.Padding(4);
            this.Sepia.Name = "Sepia";
            this.Sepia.Size = new System.Drawing.Size(152, 44);
            this.Sepia.TabIndex = 7;
            this.Sepia.Text = "Sepia";
            this.Sepia.UseVisualStyleBackColor = true;
            this.Sepia.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Histogram";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1036, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1036, 171);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Load Background";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1988, 763);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sepia);
            this.Controls.Add(this.Inversion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Greyscale);
            this.Controls.Add(this.Same);
            this.Controls.Add(this.save);
            this.Controls.Add(this.OpenFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Same;
        private System.Windows.Forms.Button Greyscale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Inversion;
        private System.Windows.Forms.Button Sepia;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}

