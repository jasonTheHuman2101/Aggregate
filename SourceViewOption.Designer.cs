
namespace Aggregate
{
    partial class SourceViewOption
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
            this.providerLogo = new System.Windows.Forms.PictureBox();
            this.providerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.providerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // providerLogo
            // 
            this.providerLogo.Location = new System.Drawing.Point(0, 0);
            this.providerLogo.Name = "providerLogo";
            this.providerLogo.Size = new System.Drawing.Size(50, 50);
            this.providerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.providerLogo.TabIndex = 0;
            this.providerLogo.TabStop = false;
            // 
            // providerName
            // 
            this.providerName.AutoSize = true;
            this.providerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.providerName.Location = new System.Drawing.Point(45, 8);
            this.providerName.Name = "providerName";
            this.providerName.Size = new System.Drawing.Size(203, 33);
            this.providerName.TabIndex = 1;
            this.providerName.Text = "This isn\'t good";
            // 
            // SourceViewOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.providerLogo);
            this.Controls.Add(this.providerName);
            this.Name = "SourceViewOption";
            this.Size = new System.Drawing.Size(250, 50);
            ((System.ComponentModel.ISupportInitialize)(this.providerLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox providerLogo;
        private System.Windows.Forms.Label providerName;
    }
}
