namespace IVT.Forms
{
    partial class EditVerbsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVerbsForm));
            this.dataGrdVw = new System.Windows.Forms.DataGridView();
            this.infinitiveCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preteritCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.openFileBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.dataGrdVwCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdVw)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.dataGrdVwCtx.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrdVw
            // 
            this.dataGrdVw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrdVw.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infinitiveCol,
            this.preteritCol,
            this.ppCol,
            this.translationCol});
            this.dataGrdVw.Location = new System.Drawing.Point(12, 58);
            this.dataGrdVw.Name = "dataGrdVw";
            this.dataGrdVw.Size = new System.Drawing.Size(626, 269);
            this.dataGrdVw.TabIndex = 1;
            this.dataGrdVw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrdVw_CellEndEdit);
            this.dataGrdVw.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrdVw_CellMouseDown);
            this.dataGrdVw.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGrdVw_CellValidating);
            this.dataGrdVw.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrdVw_CellValueChanged);
            // 
            // infinitiveCol
            // 
            this.infinitiveCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infinitiveCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.infinitiveCol.HeaderText = "Infinitive";
            this.infinitiveCol.Name = "infinitiveCol";
            this.infinitiveCol.Width = 80;
            // 
            // preteritCol
            // 
            this.preteritCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.preteritCol.HeaderText = "Preterit";
            this.preteritCol.Name = "preteritCol";
            this.preteritCol.Width = 75;
            // 
            // ppCol
            // 
            this.ppCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ppCol.HeaderText = "Present Perfect";
            this.ppCol.Name = "ppCol";
            this.ppCol.Width = 120;
            // 
            // translationCol
            // 
            this.translationCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.translationCol.HeaderText = "Translation";
            this.translationCol.Name = "translationCol";
            this.translationCol.Width = 96;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openFileBtn,
            this.saveBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(650, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newBtn.Image = global::IVT.Properties.Resources.addFile16;
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(23, 22);
            this.newBtn.Text = "New List";
            this.newBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileBtn.Image = global::IVT.Properties.Resources.folder16;
            this.openFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(23, 22);
            this.openFileBtn.Text = "Open a List of Verbs file";
            this.openFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.saveBtn.Image = global::IVT.Properties.Resources.save16;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(32, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.ButtonClick += new System.EventHandler(this.SaveBtn_ButtonClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::IVT.Properties.Resources.save16;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveBtn_ButtonClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Edit your List of Irregular Verbs";
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLbl.AutoEllipsis = true;
            this.fileNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLbl.Location = new System.Drawing.Point(316, 35);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(322, 17);
            this.fileNameLbl.TabIndex = 15;
            this.fileNameLbl.Text = "Editing: [N/A]";
            this.fileNameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.fileNameLbl.Click += new System.EventHandler(this.FileNameLbl_Click);
            // 
            // dataGrdVwCtx
            // 
            this.dataGrdVwCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
            this.dataGrdVwCtx.Name = "dataGrdVwCtx";
            this.dataGrdVwCtx.Size = new System.Drawing.Size(164, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::IVT.Properties.Resources.addRow16;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToolStripMenuItem.Text = "Add a row above";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Image = global::IVT.Properties.Resources.removeRow16;
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.DeleteRowToolStripMenuItem_Click);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(517, 333);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(49, 32);
            this.okBtn.TabIndex = 16;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(572, 333);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(66, 32);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditVerbsForm
            // 
            this.AccessibleName = "Hi";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 377);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.fileNameLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGrdVw);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditVerbsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Irregular verbs list edit - test.ivt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditVerbsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdVw)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.dataGrdVwCtx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdVw;
        private System.Windows.Forms.DataGridViewTextBoxColumn infinitiveCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn preteritCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationCol;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newBtn;
        private System.Windows.Forms.ToolStripButton openFileBtn;
        private System.Windows.Forms.ToolStripSplitButton saveBtn;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.ContextMenuStrip dataGrdVwCtx;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}