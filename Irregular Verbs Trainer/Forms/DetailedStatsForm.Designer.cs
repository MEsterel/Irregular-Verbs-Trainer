namespace IVT.Forms
{
    partial class DetailedStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedStatsForm));
            this.titleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.copyToClipboardBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titleLbl.Location = new System.Drawing.Point(50, 10);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(327, 30);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Training of 25/12/2018 at 16:53:26";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IVT.Properties.Resources.stats32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.BackColor = System.Drawing.Color.White;
            this.rtb.Location = new System.Drawing.Point(12, 50);
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            this.rtb.Size = new System.Drawing.Size(508, 270);
            this.rtb.TabIndex = 8;
            this.rtb.Text = "";
            // 
            // copyToClipboardBtn
            // 
            this.copyToClipboardBtn.Location = new System.Drawing.Point(12, 326);
            this.copyToClipboardBtn.Name = "copyToClipboardBtn";
            this.copyToClipboardBtn.Size = new System.Drawing.Size(134, 32);
            this.copyToClipboardBtn.TabIndex = 9;
            this.copyToClipboardBtn.Text = "Copy to Clipboard";
            this.copyToClipboardBtn.UseVisualStyleBackColor = true;
            this.copyToClipboardBtn.Click += new System.EventHandler(this.CopyToClipboardBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(471, 326);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(49, 32);
            this.okBtn.TabIndex = 17;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // DetailedStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 370);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.copyToClipboardBtn);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "DetailedStatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Training of 25/12/2018 at 16:53:26";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button copyToClipboardBtn;
        private System.Windows.Forms.Button okBtn;
    }
}