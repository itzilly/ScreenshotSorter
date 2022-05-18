
namespace ScreenshotSorter
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.process1 = new System.Diagnostics.Process();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowImages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cbSearchSubdirectories = new System.Windows.Forms.CheckBox();
            this.lblTotalImages = new System.Windows.Forms.Label();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.lblLastSaved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 360);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowImages
            // 
            this.btnShowImages.FlatAppearance.BorderSize = 0;
            this.btnShowImages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(19)))), ((int)(((byte)(173)))));
            this.btnShowImages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(171)))), ((int)(((byte)(166)))));
            this.btnShowImages.Location = new System.Drawing.Point(28, 34);
            this.btnShowImages.Name = "btnShowImages";
            this.btnShowImages.Size = new System.Drawing.Size(120, 28);
            this.btnShowImages.TabIndex = 3;
            this.btnShowImages.Text = "Show Images";
            this.btnShowImages.UseVisualStyleBackColor = true;
            this.btnShowImages.Click += new System.EventHandler(this.btnShowImages_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(31)))), ((int)(((byte)(65)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblTotalImages);
            this.groupBox1.Controls.Add(this.cbSearchSubdirectories);
            this.groupBox1.Controls.Add(this.lblFolder);
            this.groupBox1.Location = new System.Drawing.Point(272, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.ForeColor = System.Drawing.Color.White;
            this.lblFolder.Location = new System.Drawing.Point(166, 24);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(98, 13);
            this.lblFolder.TabIndex = 1;
            this.lblFolder.Text = "No Selected Folder";
            // 
            // cbSearchSubdirectories
            // 
            this.cbSearchSubdirectories.AutoSize = true;
            this.cbSearchSubdirectories.ForeColor = System.Drawing.Color.White;
            this.cbSearchSubdirectories.Location = new System.Drawing.Point(16, 48);
            this.cbSearchSubdirectories.Name = "cbSearchSubdirectories";
            this.cbSearchSubdirectories.Size = new System.Drawing.Size(130, 17);
            this.cbSearchSubdirectories.TabIndex = 4;
            this.cbSearchSubdirectories.Text = "Search Subdirectories";
            this.cbSearchSubdirectories.UseVisualStyleBackColor = true;
            // 
            // lblTotalImages
            // 
            this.lblTotalImages.AutoSize = true;
            this.lblTotalImages.ForeColor = System.Drawing.Color.White;
            this.lblTotalImages.Location = new System.Drawing.Point(166, 49);
            this.lblTotalImages.Name = "lblTotalImages";
            this.lblTotalImages.Size = new System.Drawing.Size(74, 13);
            this.lblTotalImages.TabIndex = 6;
            this.lblTotalImages.Text = "Total Images: ";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(165, 34);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(120, 28);
            this.btnNextImage.TabIndex = 5;
            this.btnNextImage.Text = "Next Image";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(31)))), ((int)(((byte)(65)))));
            this.groupBox2.Controls.Add(this.lblLastSaved);
            this.groupBox2.Controls.Add(this.btnSaveImage);
            this.groupBox2.Controls.Add(this.btnNextImage);
            this.groupBox2.Controls.Add(this.btnShowImages);
            this.groupBox2.Location = new System.Drawing.Point(602, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(28, 79);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(120, 28);
            this.btnSaveImage.TabIndex = 9;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // lblLastSaved
            // 
            this.lblLastSaved.AutoSize = true;
            this.lblLastSaved.Location = new System.Drawing.Point(38, 123);
            this.lblLastSaved.Name = "lblLastSaved";
            this.lblLastSaved.Size = new System.Drawing.Size(0, 13);
            this.lblLastSaved.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot Sorter vPre-1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Label lblTotalImages;
        private System.Windows.Forms.CheckBox cbSearchSubdirectories;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label lblLastSaved;
    }
}

