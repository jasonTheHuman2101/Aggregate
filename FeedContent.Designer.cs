
namespace Aggregate
{
    partial class FeedContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedContent));
            this.storyImage = new System.Windows.Forms.PictureBox();
            this.storyTitleLabel = new System.Windows.Forms.Label();
            this.storySourceAndTags = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // storyImage
            // 
            this.storyImage.Image = ((System.Drawing.Image)(resources.GetObject("storyImage.Image")));
            this.storyImage.Location = new System.Drawing.Point(0, 0);
            this.storyImage.Name = "storyImage";
            this.storyImage.Size = new System.Drawing.Size(80, 80);
            this.storyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.storyImage.TabIndex = 0;
            this.storyImage.TabStop = false;
            // 
            // storyTitleLabel
            // 
            this.storyTitleLabel.AutoSize = true;
            this.storyTitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.storyTitleLabel.Location = new System.Drawing.Point(79, 0);
            this.storyTitleLabel.Name = "storyTitleLabel";
            this.storyTitleLabel.Size = new System.Drawing.Size(545, 55);
            this.storyTitleLabel.TabIndex = 1;
            this.storyTitleLabel.Text = "Title hasn\'t been set. OOPS!";
            // 
            // storySourceAndTags
            // 
            this.storySourceAndTags.AutoSize = true;
            this.storySourceAndTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.storySourceAndTags.Location = new System.Drawing.Point(86, 64);
            this.storySourceAndTags.Name = "storySourceAndTags";
            this.storySourceAndTags.Size = new System.Drawing.Size(148, 13);
            this.storySourceAndTags.TabIndex = 2;
            this.storySourceAndTags.Text = "This seems to be missing. ugh";
            // 
            // FeedContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Controls.Add(this.storySourceAndTags);
            this.Controls.Add(this.storyTitleLabel);
            this.Controls.Add(this.storyImage);
            this.Name = "FeedContent";
            this.Size = new System.Drawing.Size(1115, 80);
            ((System.ComponentModel.ISupportInitialize)(this.storyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox storyImage;
        private System.Windows.Forms.Label storyTitleLabel;
        private System.Windows.Forms.Label storySourceAndTags;
    }
}
