namespace IVT.Forms
{
    partial class EndScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreenForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.layoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.wonOutOfTotalLbl = new System.Windows.Forms.Label();
            this.winPercentageLbl = new System.Windows.Forms.Label();
            this.totalTimeLbl = new System.Windows.Forms.Label();
            this.averageSpeedLbl = new System.Windows.Forms.Label();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.statsTitleLbl = new System.Windows.Forms.Label();
            this.moreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IVT.Properties.Resources.end32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titleLbl.Location = new System.Drawing.Point(44, 8);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(123, 37);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Finished!";
            // 
            // layoutPnl
            // 
            this.layoutPnl.ColumnCount = 1;
            this.layoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPnl.Controls.Add(this.wonOutOfTotalLbl, 0, 2);
            this.layoutPnl.Controls.Add(this.winPercentageLbl, 0, 1);
            this.layoutPnl.Controls.Add(this.totalTimeLbl, 0, 4);
            this.layoutPnl.Controls.Add(this.averageSpeedLbl, 0, 3);
            this.layoutPnl.Controls.Add(this.scoreBtn, 0, 0);
            this.layoutPnl.Location = new System.Drawing.Point(12, 51);
            this.layoutPnl.Name = "layoutPnl";
            this.layoutPnl.RowCount = 5;
            this.layoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.layoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.layoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.layoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.layoutPnl.Size = new System.Drawing.Size(305, 174);
            this.layoutPnl.TabIndex = 4;
            // 
            // wonOutOfTotalLbl
            // 
            this.wonOutOfTotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wonOutOfTotalLbl.AutoSize = true;
            this.wonOutOfTotalLbl.Location = new System.Drawing.Point(3, 90);
            this.wonOutOfTotalLbl.Name = "wonOutOfTotalLbl";
            this.wonOutOfTotalLbl.Size = new System.Drawing.Size(299, 29);
            this.wonOutOfTotalLbl.TabIndex = 2;
            this.wonOutOfTotalLbl.Text = "0 verbs won out of 0";
            this.wonOutOfTotalLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winPercentageLbl
            // 
            this.winPercentageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winPercentageLbl.AutoSize = true;
            this.winPercentageLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPercentageLbl.Location = new System.Drawing.Point(3, 71);
            this.winPercentageLbl.Name = "winPercentageLbl";
            this.winPercentageLbl.Size = new System.Drawing.Size(299, 19);
            this.winPercentageLbl.TabIndex = 1;
            this.winPercentageLbl.Text = "Win Percentage: 0%";
            this.winPercentageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTimeLbl
            // 
            this.totalTimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTimeLbl.AutoSize = true;
            this.totalTimeLbl.Location = new System.Drawing.Point(3, 140);
            this.totalTimeLbl.Name = "totalTimeLbl";
            this.totalTimeLbl.Size = new System.Drawing.Size(299, 34);
            this.totalTimeLbl.TabIndex = 3;
            this.totalTimeLbl.Text = "Total time: 00:00:00";
            this.totalTimeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // averageSpeedLbl
            // 
            this.averageSpeedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.averageSpeedLbl.AutoSize = true;
            this.averageSpeedLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageSpeedLbl.Location = new System.Drawing.Point(3, 119);
            this.averageSpeedLbl.Name = "averageSpeedLbl";
            this.averageSpeedLbl.Size = new System.Drawing.Size(299, 21);
            this.averageSpeedLbl.TabIndex = 21;
            this.averageSpeedLbl.Text = "Average Speed: 0 verbs/min";
            this.averageSpeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreBtn
            // 
            this.scoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBtn.AutoSize = true;
            this.scoreBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.scoreBtn.FlatAppearance.BorderSize = 0;
            this.scoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.scoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBtn.Image = global::IVT.Properties.Resources.flame16;
            this.scoreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreBtn.Location = new System.Drawing.Point(3, 3);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(299, 65);
            this.scoreBtn.TabIndex = 0;
            this.scoreBtn.Text = "Final score: 0\r\n";
            this.scoreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scoreBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.scoreBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(268, 243);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(49, 32);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // statsTitleLbl
            // 
            this.statsTitleLbl.AutoSize = true;
            this.statsTitleLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statsTitleLbl.Location = new System.Drawing.Point(155, 8);
            this.statsTitleLbl.Name = "statsTitleLbl";
            this.statsTitleLbl.Size = new System.Drawing.Size(73, 37);
            this.statsTitleLbl.TabIndex = 21;
            this.statsTitleLbl.Text = "Stats";
            // 
            // moreBtn
            // 
            this.moreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moreBtn.Location = new System.Drawing.Point(190, 243);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(72, 32);
            this.moreBtn.TabIndex = 22;
            this.moreBtn.Text = "Details";
            this.moreBtn.UseVisualStyleBackColor = true;
            this.moreBtn.Click += new System.EventHandler(this.MoreBtn_Click);
            // 
            // EndScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 287);
            this.Controls.Add(this.moreBtn);
            this.Controls.Add(this.statsTitleLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.layoutPnl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndScreenForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Training finished";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layoutPnl.ResumeLayout(false);
            this.layoutPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TableLayoutPanel layoutPnl;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.Label wonOutOfTotalLbl;
        private System.Windows.Forms.Label winPercentageLbl;
        private System.Windows.Forms.Label totalTimeLbl;
        private System.Windows.Forms.Label averageSpeedLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label statsTitleLbl;
        private System.Windows.Forms.Button moreBtn;
    }
}