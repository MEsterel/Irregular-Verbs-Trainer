namespace IVT.Forms
{
    partial class HistoryForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            " Against the clock",
            "27/01/2018 16:28:23",
            "MyList.ivt",
            "Objective reached",
            "00:02:45"}, "clock16.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.lstView = new System.Windows.Forms.ListView();
            this.modeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.verbsLstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewImgLst = new System.Windows.Forms.ImageList(this.components);
            this.okBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.lstViewCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstViewCtx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modeCol,
            this.dateCol,
            this.verbsLstNameCol,
            this.resultCol,
            this.durationCol});
            this.lstView.FullRowSelect = true;
            this.lstView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstView.Location = new System.Drawing.Point(12, 29);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(659, 235);
            this.lstView.SmallImageList = this.lstViewImgLst;
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.DoubleClick += new System.EventHandler(this.LstView_DoubleClick);
            this.lstView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_KeyDown);
            this.lstView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstView_MouseClick);
            // 
            // modeCol
            // 
            this.modeCol.Text = "Mode";
            this.modeCol.Width = 140;
            // 
            // dateCol
            // 
            this.dateCol.Text = "Date";
            this.dateCol.Width = 130;
            // 
            // verbsLstNameCol
            // 
            this.verbsLstNameCol.Text = "Verbs List Name";
            this.verbsLstNameCol.Width = 150;
            // 
            // resultCol
            // 
            this.resultCol.Text = "Result";
            this.resultCol.Width = 120;
            // 
            // durationCol
            // 
            this.durationCol.Text = "Duration";
            this.durationCol.Width = 90;
            // 
            // lstViewImgLst
            // 
            this.lstViewImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstViewImgLst.ImageStream")));
            this.lstViewImgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.lstViewImgLst.Images.SetKeyName(0, "flame16.png");
            this.lstViewImgLst.Images.SetKeyName(1, "clock16.png");
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(622, 270);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(49, 32);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "History of your last trainings:";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(12, 270);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(103, 32);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear history";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // lstViewCtx
            // 
            this.lstViewCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.lstViewCtx.Name = "contextMenuStrip1";
            this.lstViewCtx.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::IVT.Properties.Resources.bin16;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 314);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.lstView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Training history";
            this.lstViewCtx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList lstViewImgLst;
        private System.Windows.Forms.ColumnHeader modeCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.ColumnHeader verbsLstNameCol;
        private System.Windows.Forms.ColumnHeader resultCol;
        private System.Windows.Forms.ColumnHeader durationCol;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ContextMenuStrip lstViewCtx;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}