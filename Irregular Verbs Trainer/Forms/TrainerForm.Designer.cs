namespace IVT.Forms
{
    partial class TrainerForm
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
                if (trainer != null)
                {
                    trainer.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infinitiveAnswerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.preteritCorrectionLbl = new System.Windows.Forms.Label();
            this.infinitiveCorrectionLbl = new System.Windows.Forms.Label();
            this.preteritAnswerTxt = new System.Windows.Forms.TextBox();
            this.ppAnswerTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ppCorrectionLbl = new System.Windows.Forms.Label();
            this.translationAnswerTxt = new System.Windows.Forms.TextBox();
            this.translationCorrectionLbl = new System.Windows.Forms.Label();
            this.loadedFileLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scoreStateLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.aboutBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.passBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.editVerbsBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train yourself! Complete the answer:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Infinitive:";
            // 
            // infinitiveAnswerTxt
            // 
            this.infinitiveAnswerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.infinitiveAnswerTxt.Location = new System.Drawing.Point(3, 23);
            this.infinitiveAnswerTxt.Name = "infinitiveAnswerTxt";
            this.infinitiveAnswerTxt.Size = new System.Drawing.Size(145, 25);
            this.infinitiveAnswerTxt.TabIndex = 5;
            this.infinitiveAnswerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infinitiveAnswerTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTxt_KeyDown);
            this.infinitiveAnswerTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnswerTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preterit:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Present Perfect:";
            // 
            // layoutPanel
            // 
            this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPanel.ColumnCount = 4;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.Controls.Add(this.preteritCorrectionLbl, 0, 2);
            this.layoutPanel.Controls.Add(this.infinitiveCorrectionLbl, 0, 2);
            this.layoutPanel.Controls.Add(this.label3, 1, 0);
            this.layoutPanel.Controls.Add(this.label4, 2, 0);
            this.layoutPanel.Controls.Add(this.infinitiveAnswerTxt, 0, 1);
            this.layoutPanel.Controls.Add(this.preteritAnswerTxt, 1, 1);
            this.layoutPanel.Controls.Add(this.ppAnswerTxt, 2, 1);
            this.layoutPanel.Controls.Add(this.label2, 0, 0);
            this.layoutPanel.Controls.Add(this.label8, 3, 0);
            this.layoutPanel.Controls.Add(this.ppCorrectionLbl, 2, 2);
            this.layoutPanel.Controls.Add(this.translationAnswerTxt, 3, 1);
            this.layoutPanel.Controls.Add(this.translationCorrectionLbl, 3, 2);
            this.layoutPanel.Location = new System.Drawing.Point(13, 88);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(607, 68);
            this.layoutPanel.TabIndex = 10;
            // 
            // preteritCorrectionLbl
            // 
            this.preteritCorrectionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preteritCorrectionLbl.AutoSize = true;
            this.preteritCorrectionLbl.ForeColor = System.Drawing.Color.Green;
            this.preteritCorrectionLbl.Location = new System.Drawing.Point(188, 49);
            this.preteritCorrectionLbl.Name = "preteritCorrectionLbl";
            this.preteritCorrectionLbl.Size = new System.Drawing.Size(77, 17);
            this.preteritCorrectionLbl.TabIndex = 12;
            this.preteritCorrectionLbl.Text = "[Correction]";
            // 
            // infinitiveCorrectionLbl
            // 
            this.infinitiveCorrectionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infinitiveCorrectionLbl.AutoSize = true;
            this.infinitiveCorrectionLbl.ForeColor = System.Drawing.Color.Green;
            this.infinitiveCorrectionLbl.Location = new System.Drawing.Point(37, 49);
            this.infinitiveCorrectionLbl.Name = "infinitiveCorrectionLbl";
            this.infinitiveCorrectionLbl.Size = new System.Drawing.Size(77, 17);
            this.infinitiveCorrectionLbl.TabIndex = 10;
            this.infinitiveCorrectionLbl.Text = "[Correction]";
            // 
            // preteritAnswerTxt
            // 
            this.preteritAnswerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.preteritAnswerTxt.Location = new System.Drawing.Point(154, 23);
            this.preteritAnswerTxt.Name = "preteritAnswerTxt";
            this.preteritAnswerTxt.Size = new System.Drawing.Size(145, 25);
            this.preteritAnswerTxt.TabIndex = 6;
            this.preteritAnswerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.preteritAnswerTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTxt_KeyDown);
            this.preteritAnswerTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnswerTxt_KeyPress);
            // 
            // ppAnswerTxt
            // 
            this.ppAnswerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ppAnswerTxt.Location = new System.Drawing.Point(305, 23);
            this.ppAnswerTxt.Name = "ppAnswerTxt";
            this.ppAnswerTxt.Size = new System.Drawing.Size(145, 25);
            this.ppAnswerTxt.TabIndex = 7;
            this.ppAnswerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppAnswerTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTxt_KeyDown);
            this.ppAnswerTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnswerTxt_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Translation:";
            // 
            // ppCorrectionLbl
            // 
            this.ppCorrectionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ppCorrectionLbl.AutoSize = true;
            this.ppCorrectionLbl.ForeColor = System.Drawing.Color.Green;
            this.ppCorrectionLbl.Location = new System.Drawing.Point(339, 49);
            this.ppCorrectionLbl.Name = "ppCorrectionLbl";
            this.ppCorrectionLbl.Size = new System.Drawing.Size(77, 17);
            this.ppCorrectionLbl.TabIndex = 11;
            this.ppCorrectionLbl.Text = "[Correction]";
            // 
            // translationAnswerTxt
            // 
            this.translationAnswerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.translationAnswerTxt.Location = new System.Drawing.Point(456, 23);
            this.translationAnswerTxt.Name = "translationAnswerTxt";
            this.translationAnswerTxt.Size = new System.Drawing.Size(148, 25);
            this.translationAnswerTxt.TabIndex = 8;
            this.translationAnswerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.translationAnswerTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTxt_KeyDown);
            this.translationAnswerTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnswerTxt_KeyPress);
            // 
            // translationCorrectionLbl
            // 
            this.translationCorrectionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translationCorrectionLbl.AutoSize = true;
            this.translationCorrectionLbl.ForeColor = System.Drawing.Color.Green;
            this.translationCorrectionLbl.Location = new System.Drawing.Point(491, 49);
            this.translationCorrectionLbl.Name = "translationCorrectionLbl";
            this.translationCorrectionLbl.Size = new System.Drawing.Size(77, 17);
            this.translationCorrectionLbl.TabIndex = 11;
            this.translationCorrectionLbl.Text = "[Correction]";
            // 
            // loadedFileLbl
            // 
            this.loadedFileLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadedFileLbl.AutoEllipsis = true;
            this.loadedFileLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadedFileLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedFileLbl.Location = new System.Drawing.Point(9, 199);
            this.loadedFileLbl.Name = "loadedFileLbl";
            this.loadedFileLbl.Size = new System.Drawing.Size(302, 13);
            this.loadedFileLbl.TabIndex = 11;
            this.loadedFileLbl.Text = "Loaded list file: [N/A]";
            this.loadedFileLbl.Click += new System.EventHandler(this.LoadedFileLbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Irregular Verbs Trainer";
            // 
            // scoreStateLbl
            // 
            this.scoreStateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scoreStateLbl.AutoSize = true;
            this.scoreStateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreStateLbl.ForeColor = System.Drawing.Color.Green;
            this.scoreStateLbl.Location = new System.Drawing.Point(12, 159);
            this.scoreStateLbl.Name = "scoreStateLbl";
            this.scoreStateLbl.Size = new System.Drawing.Size(12, 17);
            this.scoreStateLbl.TabIndex = 16;
            this.scoreStateLbl.Text = " ";
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.Image = global::IVT.Properties.Resources.help16;
            this.aboutBtn.Location = new System.Drawing.Point(335, 12);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(31, 31);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.aboutBtn, "About Irregular Verbs Trainer...");
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.scoreLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Image = global::IVT.Properties.Resources.flame16;
            this.scoreLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scoreLbl.Location = new System.Drawing.Point(12, 177);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(71, 17);
            this.scoreLbl.TabIndex = 15;
            this.scoreLbl.Text = "Score: 0    ";
            this.toolTip1.SetToolTip(this.scoreLbl, "The more flames you have, the best you are! (100 flames max.)");
            this.scoreLbl.Click += new System.EventHandler(this.ScoreLbl_Click);
            // 
            // passBtn
            // 
            this.passBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.passBtn.Image = global::IVT.Properties.Resources.go16;
            this.passBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passBtn.Location = new System.Drawing.Point(547, 177);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(73, 26);
            this.passBtn.TabIndex = 1;
            this.passBtn.Text = "Pass";
            this.passBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.passBtn, "You lose less flames if you pass a verb you can\'t complete than if you make mista" +
        "kes.");
            this.passBtn.UseVisualStyleBackColor = true;
            this.passBtn.Click += new System.EventHandler(this.PassBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyBtn.Image = global::IVT.Properties.Resources.history16;
            this.historyBtn.Location = new System.Drawing.Point(372, 12);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(31, 31);
            this.historyBtn.TabIndex = 17;
            this.historyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.historyBtn, "Your training history");
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Image = global::IVT.Properties.Resources.stop16;
            this.stopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopBtn.Location = new System.Drawing.Point(352, 177);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(78, 26);
            this.stopBtn.TabIndex = 9;
            this.stopBtn.Text = "Stop";
            this.stopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // editVerbsBtn
            // 
            this.editVerbsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editVerbsBtn.Image = global::IVT.Properties.Resources.edit16;
            this.editVerbsBtn.Location = new System.Drawing.Point(503, 12);
            this.editVerbsBtn.Name = "editVerbsBtn";
            this.editVerbsBtn.Size = new System.Drawing.Size(117, 31);
            this.editVerbsBtn.TabIndex = 4;
            this.editVerbsBtn.Text = "Edit Verbs List";
            this.editVerbsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editVerbsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editVerbsBtn.UseVisualStyleBackColor = true;
            this.editVerbsBtn.Click += new System.EventHandler(this.EditVerbsBtn_Click);
            // 
            // actionBtn
            // 
            this.actionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionBtn.Image = global::IVT.Properties.Resources.power16;
            this.actionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actionBtn.Location = new System.Drawing.Point(436, 171);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(105, 38);
            this.actionBtn.TabIndex = 0;
            this.actionBtn.Text = "Start!";
            this.actionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsBtn.Image = global::IVT.Properties.Resources.gear16;
            this.optionsBtn.Location = new System.Drawing.Point(409, 12);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(88, 31);
            this.optionsBtn.TabIndex = 3;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 221);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.scoreStateLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editVerbsBtn);
            this.Controls.Add(this.loadedFileLbl);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(613, 236);
            this.Name = "TrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Irregular Verbs Trainer";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox infinitiveAnswerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Label preteritCorrectionLbl;
        private System.Windows.Forms.Label ppCorrectionLbl;
        private System.Windows.Forms.Label infinitiveCorrectionLbl;
        private System.Windows.Forms.TextBox preteritAnswerTxt;
        private System.Windows.Forms.TextBox ppAnswerTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox translationAnswerTxt;
        private System.Windows.Forms.Label translationCorrectionLbl;
        private System.Windows.Forms.Label loadedFileLbl;
        private System.Windows.Forms.Button editVerbsBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label scoreStateLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button historyBtn;
    }
}