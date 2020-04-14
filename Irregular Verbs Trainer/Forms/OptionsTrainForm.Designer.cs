namespace IVT.Forms
{
    partial class OptionsTrainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsTrainForm));
            this.infinitiveChk = new System.Windows.Forms.CheckBox();
            this.preteritChk = new System.Windows.Forms.CheckBox();
            this.ppChk = new System.Windows.Forms.CheckBox();
            this.randomChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.translationChk = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.randomRdo = new System.Windows.Forms.RadioButton();
            this.descendentRdo = new System.Windows.Forms.RadioButton();
            this.ascendantRdo = new System.Windows.Forms.RadioButton();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timerTimingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerVerbsNup = new System.Windows.Forms.NumericUpDown();
            this.timerRdo = new System.Windows.Forms.RadioButton();
            this.normalModeRdo = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.availableChancesNup = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerVerbsNup)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableChancesNup)).BeginInit();
            this.SuspendLayout();
            // 
            // infinitiveChk
            // 
            this.infinitiveChk.AutoSize = true;
            this.infinitiveChk.Location = new System.Drawing.Point(15, 24);
            this.infinitiveChk.Name = "infinitiveChk";
            this.infinitiveChk.Size = new System.Drawing.Size(77, 21);
            this.infinitiveChk.TabIndex = 1;
            this.infinitiveChk.Text = "Inifinitive";
            this.toolTip1.SetToolTip(this.infinitiveChk, "Infinitif");
            this.infinitiveChk.UseVisualStyleBackColor = true;
            this.infinitiveChk.CheckedChanged += new System.EventHandler(this.GapChk_CheckedChanged);
            // 
            // preteritChk
            // 
            this.preteritChk.AutoSize = true;
            this.preteritChk.Location = new System.Drawing.Point(98, 24);
            this.preteritChk.Name = "preteritChk";
            this.preteritChk.Size = new System.Drawing.Size(69, 21);
            this.preteritChk.TabIndex = 2;
            this.preteritChk.Text = "Preterit";
            this.toolTip1.SetToolTip(this.preteritChk, "Prétérit");
            this.preteritChk.UseVisualStyleBackColor = true;
            this.preteritChk.CheckedChanged += new System.EventHandler(this.GapChk_CheckedChanged);
            // 
            // ppChk
            // 
            this.ppChk.AutoSize = true;
            this.ppChk.Location = new System.Drawing.Point(173, 24);
            this.ppChk.Name = "ppChk";
            this.ppChk.Size = new System.Drawing.Size(114, 21);
            this.ppChk.TabIndex = 3;
            this.ppChk.Text = "Present Perfect";
            this.toolTip1.SetToolTip(this.ppChk, "Parfait");
            this.ppChk.UseVisualStyleBackColor = true;
            this.ppChk.CheckedChanged += new System.EventHandler(this.GapChk_CheckedChanged);
            // 
            // randomChk
            // 
            this.randomChk.AutoSize = true;
            this.randomChk.Location = new System.Drawing.Point(44, 50);
            this.randomChk.Name = "randomChk";
            this.randomChk.Size = new System.Drawing.Size(76, 21);
            this.randomChk.TabIndex = 4;
            this.randomChk.Text = "Random";
            this.toolTip1.SetToolTip(this.randomChk, "Aléatoire");
            this.randomChk.UseVisualStyleBackColor = true;
            this.randomChk.CheckedChanged += new System.EventHandler(this.RandomGapChk_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.translationChk);
            this.groupBox1.Controls.Add(this.infinitiveChk);
            this.groupBox1.Controls.Add(this.randomChk);
            this.groupBox1.Controls.Add(this.preteritChk);
            this.groupBox1.Controls.Add(this.ppChk);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gaps options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "OR";
            // 
            // translationChk
            // 
            this.translationChk.AutoSize = true;
            this.translationChk.Location = new System.Drawing.Point(293, 24);
            this.translationChk.Name = "translationChk";
            this.translationChk.Size = new System.Drawing.Size(90, 21);
            this.translationChk.TabIndex = 5;
            this.translationChk.Text = "Translation";
            this.toolTip1.SetToolTip(this.translationChk, "Traduction");
            this.translationChk.UseVisualStyleBackColor = true;
            this.translationChk.CheckedChanged += new System.EventHandler(this.GapChk_CheckedChanged);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(327, 357);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(49, 32);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.randomRdo);
            this.groupBox2.Controls.Add(this.descendentRdo);
            this.groupBox2.Controls.Add(this.ascendantRdo);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verbs in the list apparition";
            // 
            // randomRdo
            // 
            this.randomRdo.AutoSize = true;
            this.randomRdo.Location = new System.Drawing.Point(15, 24);
            this.randomRdo.Name = "randomRdo";
            this.randomRdo.Size = new System.Drawing.Size(75, 21);
            this.randomRdo.TabIndex = 1;
            this.randomRdo.TabStop = true;
            this.randomRdo.Text = "Random";
            this.toolTip1.SetToolTip(this.randomRdo, "Aléatoire");
            this.randomRdo.UseVisualStyleBackColor = true;
            // 
            // descendentRdo
            // 
            this.descendentRdo.AutoSize = true;
            this.descendentRdo.Location = new System.Drawing.Point(188, 24);
            this.descendentRdo.Name = "descendentRdo";
            this.descendentRdo.Size = new System.Drawing.Size(94, 21);
            this.descendentRdo.TabIndex = 1;
            this.descendentRdo.TabStop = true;
            this.descendentRdo.Text = "Descendent";
            this.toolTip1.SetToolTip(this.descendentRdo, "De la fin ou début selon l\'infinitif des verbes");
            this.descendentRdo.UseVisualStyleBackColor = true;
            // 
            // ascendantRdo
            // 
            this.ascendantRdo.AutoSize = true;
            this.ascendantRdo.Location = new System.Drawing.Point(96, 24);
            this.ascendantRdo.Name = "ascendantRdo";
            this.ascendantRdo.Size = new System.Drawing.Size(86, 21);
            this.ascendantRdo.TabIndex = 0;
            this.ascendantRdo.TabStop = true;
            this.ascendantRdo.Text = "Ascendant";
            this.toolTip1.SetToolTip(this.ascendantRdo, "Du début à la fin selon l\'infinitif des verbes");
            this.ascendantRdo.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(382, 357);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(64, 32);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.timerTimingTimePicker);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.timerVerbsNup);
            this.groupBox3.Controls.Add(this.timerRdo);
            this.groupBox3.Controls.Add(this.normalModeRdo);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 123);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "(Hours:Minutes:Seconds)";
            // 
            // timerTimingTimePicker
            // 
            this.timerTimingTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timerTimingTimePicker.Location = new System.Drawing.Point(220, 77);
            this.timerTimingTimePicker.Name = "timerTimingTimePicker";
            this.timerTimingTimePicker.ShowUpDown = true;
            this.timerTimingTimePicker.Size = new System.Drawing.Size(116, 25);
            this.timerTimingTimePicker.TabIndex = 9;
            this.toolTip1.SetToolTip(this.timerTimingTimePicker, "(Heures:Minutes:Secondes)");
            this.timerTimingTimePicker.Value = new System.DateTime(2017, 7, 6, 0, 5, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "verbs in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Objective:";
            // 
            // timerVerbsNup
            // 
            this.timerVerbsNup.Location = new System.Drawing.Point(96, 78);
            this.timerVerbsNup.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.timerVerbsNup.Name = "timerVerbsNup";
            this.timerVerbsNup.Size = new System.Drawing.Size(58, 25);
            this.timerVerbsNup.TabIndex = 4;
            this.timerVerbsNup.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timerRdo
            // 
            this.timerRdo.AutoSize = true;
            this.timerRdo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timerRdo.Location = new System.Drawing.Point(15, 51);
            this.timerRdo.Name = "timerRdo";
            this.timerRdo.Size = new System.Drawing.Size(126, 21);
            this.timerRdo.TabIndex = 3;
            this.timerRdo.TabStop = true;
            this.timerRdo.Text = "Against the Clock";
            this.toolTip1.SetToolTip(this.timerRdo, "Contre la Montre");
            this.timerRdo.UseVisualStyleBackColor = true;
            this.timerRdo.CheckedChanged += new System.EventHandler(this.TimerRdo_CheckedChanged);
            // 
            // normalModeRdo
            // 
            this.normalModeRdo.AutoSize = true;
            this.normalModeRdo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.normalModeRdo.Location = new System.Drawing.Point(15, 24);
            this.normalModeRdo.Name = "normalModeRdo";
            this.normalModeRdo.Size = new System.Drawing.Size(70, 21);
            this.normalModeRdo.TabIndex = 2;
            this.normalModeRdo.TabStop = true;
            this.normalModeRdo.Text = "Normal";
            this.normalModeRdo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.availableChancesNup);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 60);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mistakes";
            // 
            // availableChancesNup
            // 
            this.availableChancesNup.Location = new System.Drawing.Point(368, 24);
            this.availableChancesNup.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.availableChancesNup.Name = "availableChancesNup";
            this.availableChancesNup.Size = new System.Drawing.Size(58, 25);
            this.availableChancesNup.TabIndex = 11;
            this.availableChancesNup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Available chances (additional trials before loosing a point):";
            // 
            // OptionsTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 401);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsTrainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Training options";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerVerbsNup)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableChancesNup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox infinitiveChk;
        private System.Windows.Forms.CheckBox preteritChk;
        private System.Windows.Forms.CheckBox ppChk;
        private System.Windows.Forms.CheckBox randomChk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox translationChk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton randomRdo;
        private System.Windows.Forms.RadioButton descendentRdo;
        private System.Windows.Forms.RadioButton ascendantRdo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton timerRdo;
        private System.Windows.Forms.RadioButton normalModeRdo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timerVerbsNup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timerTimingTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown availableChancesNup;
        private System.Windows.Forms.Label label6;
    }
}