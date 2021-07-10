
namespace Aggregate
{
    partial class EditSources
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
            this.sourcesPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newSourceURL = new System.Windows.Forms.TextBox();
            this.addSrcBttn = new System.Windows.Forms.Button();
            this.sourceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sourceImage = new System.Windows.Forms.TextBox();
            this.sourceImagePreview = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcesPanel
            // 
            this.sourcesPanel.AutoScroll = true;
            this.sourcesPanel.Location = new System.Drawing.Point(0, 0);
            this.sourcesPanel.Name = "sourcesPanel";
            this.sourcesPanel.Size = new System.Drawing.Size(275, 282);
            this.sourcesPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.sourceImagePreview);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sourceImage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sourceUrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sourceName);
            this.groupBox1.Controls.Add(this.updateSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(281, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Source";
            // 
            // updateSource
            // 
            this.updateSource.Location = new System.Drawing.Point(9, 111);
            this.updateSource.Name = "updateSource";
            this.updateSource.Size = new System.Drawing.Size(219, 80);
            this.updateSource.TabIndex = 1;
            this.updateSource.Text = "Update";
            this.updateSource.UseVisualStyleBackColor = true;
            this.updateSource.Click += new System.EventHandler(this.updateSource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press a source to select it";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.addSrcBttn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.newSourceURL);
            this.groupBox2.Location = new System.Drawing.Point(281, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source URL";
            // 
            // newSourceURL
            // 
            this.newSourceURL.Location = new System.Drawing.Point(78, 19);
            this.newSourceURL.Name = "newSourceURL";
            this.newSourceURL.Size = new System.Drawing.Size(233, 20);
            this.newSourceURL.TabIndex = 0;
            // 
            // addSrcBttn
            // 
            this.addSrcBttn.Location = new System.Drawing.Point(9, 45);
            this.addSrcBttn.Name = "addSrcBttn";
            this.addSrcBttn.Size = new System.Drawing.Size(302, 32);
            this.addSrcBttn.TabIndex = 2;
            this.addSrcBttn.Text = "View Source";
            this.addSrcBttn.UseVisualStyleBackColor = true;
            this.addSrcBttn.Click += new System.EventHandler(this.addSrcBttn_Click);
            // 
            // sourceName
            // 
            this.sourceName.Location = new System.Drawing.Point(53, 33);
            this.sourceName.Name = "sourceName";
            this.sourceName.Size = new System.Drawing.Size(258, 20);
            this.sourceName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source";
            // 
            // sourceUrl
            // 
            this.sourceUrl.Location = new System.Drawing.Point(53, 59);
            this.sourceUrl.Name = "sourceUrl";
            this.sourceUrl.Size = new System.Drawing.Size(258, 20);
            this.sourceUrl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image URL";
            // 
            // sourceImage
            // 
            this.sourceImage.Location = new System.Drawing.Point(73, 85);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(238, 20);
            this.sourceImage.TabIndex = 6;
            // 
            // sourceImagePreview
            // 
            this.sourceImagePreview.Location = new System.Drawing.Point(231, 111);
            this.sourceImagePreview.Name = "sourceImagePreview";
            this.sourceImagePreview.Size = new System.Drawing.Size(80, 80);
            this.sourceImagePreview.TabIndex = 8;
            this.sourceImagePreview.TabStop = false;
            // 
            // EditSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sourcesPanel);
            this.Name = "EditSources";
            this.Text = "Edit Sources";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImagePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sourcesPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newSourceURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourceUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sourceName;
        private System.Windows.Forms.Button addSrcBttn;
        private System.Windows.Forms.PictureBox sourceImagePreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sourceImage;
    }
}