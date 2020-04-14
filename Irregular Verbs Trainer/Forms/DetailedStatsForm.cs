using IVT.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVT.Forms
{
    public partial class DetailedStatsForm : Form
    {
        private TrainingHistory TH;

        public DetailedStatsForm(TrainingHistory th)
        {
            InitializeComponent();

            TH = th;

            this.Text = "Training of " + TH.Date.ToShortDateString() + " at " + TH.Date.ToLongTimeString();
            titleLbl.Text = "Training of " + TH.Date.ToShortDateString() + " at " + TH.Date.ToLongTimeString();

            FormatOutput();
        }

        private void FormatOutput()
        {
            rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)14.25, FontStyle.Bold);
            rtb.SelectionColor = Color.RoyalBlue;
            rtb.AppendText("Training of " + TH.Date.ToShortDateString() + " at " + TH.Date.ToLongTimeString() + Environment.NewLine);

            rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)8, FontStyle.Italic);
            rtb.SelectionColor = Color.Black;
            rtb.AppendText("Training list: " + TH.ListName + Environment.NewLine + Environment.NewLine);

            rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Bold | FontStyle.Underline);
            rtb.SelectionColor = Color.Black;
            rtb.AppendText("Your stats:" + Environment.NewLine);

            rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
            rtb.SelectionColor = Color.Black;
            rtb.AppendText("Training mode: ");

            if (TH.Mode == AnswerMode.Normal)
            {
                rtb.AppendText("Normal" + Environment.NewLine);
            }
            else if (TH.Mode == AnswerMode.Timer)
            {
                rtb.AppendText("Timer" + Environment.NewLine);
                rtb.AppendText("------------------------------" + Environment.NewLine);
                rtb.AppendText("> Objective: " + TH.MinimumVerbs + " in " + TH.TimerObjectiveTime.ToString(@"hh\:mm\:ss")
                    + ", speed: " + Math.Round(TH.ObjectiveSpeed, 2).ToString() + " verbs/minute" + Environment.NewLine);
                rtb.AppendText("> You did: " + TH.WonVerbs + " in " + TH.Duration.ToString(@"hh\:mm\:ss")
                    + ", average speed: " + Math.Round(TH.AverageSpeed, 2).ToString() + " verbs/minute" + Environment.NewLine);
                if (TH.ObjectiveWon)
                {
                    rtb.SelectionColor = Color.Green;
                    rtb.AppendText("Objective won !" + Environment.NewLine);
                }
                else
                {
                    rtb.SelectionColor = Color.Red;
                    rtb.AppendText("Objective failed." + Environment.NewLine);
                }
                rtb.SelectionColor = Color.Black;
                rtb.AppendText("------------------------------" + Environment.NewLine);
            }

            rtb.AppendText("Score: ");
            if (TH.Score >= 20)
            {
                rtb.SelectionColor = Color.Green;
            }
            else if (TH.Score >= 0)
            {
                rtb.SelectionColor = Color.DarkOrange;
            }
            else
            {
                rtb.SelectionColor = Color.Red;
            }
            rtb.AppendText(TH.Score + " flames" + Environment.NewLine);

            rtb.SelectionColor = Color.Black;
            rtb.AppendText("Win percentage: " + Math.Round(TH.WinPercentage, 1) + "%" + Environment.NewLine);
            rtb.AppendText("Correct verbs: " + TH.WonVerbs + "; Wrong verbs: " + (TH.WonVerbs - TH.TotalVerbs) + "; Total verbs: " + TH.TotalVerbs +
                Environment.NewLine);

            if (TH.Mode == AnswerMode.Normal)
            {
                rtb.AppendText("Duration time: " + TH.Duration.ToString(@"hh\:mm\:ss") + Environment.NewLine);
                rtb.AppendText("Answer speed: " + Math.Round(TH.AverageSpeed, 2).ToString() + " verbs/minute" + Environment.NewLine);
            }

            rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Bold | FontStyle.Underline);
            rtb.AppendText(Environment.NewLine + "What you have done:" + Environment.NewLine);

            int i = 1;
            foreach (VerbAnswer va in TH.VerbAnswers)
            {
                rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                rtb.SelectionColor = Color.Black;
                rtb.AppendText(i.ToString("D3") + " | "); // "001 | "

                // INFINITIVE
                if (va.InfinitiveAnswer.NotAnswerable)
                {
                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Italic);
                    rtb.SelectionColor = Color.Gray;
                    rtb.AppendText(va.InitialVerb.Infinitive + " ");
                }
                else
                {
                    foreach (string wa in va.InfinitiveAnswer.WrongAnswers)
                    {
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Strikeout);
                        rtb.SelectionColor = Color.Red;
                        rtb.AppendText(wa);
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(" ");
                    }

                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                    if (va.InfinitiveAnswer.AnsweredCorrectly)
                    {
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(va.InitialVerb.Infinitive + " ");
                    }
                    else
                    {
                        rtb.SelectionColor = Color.Green;
                        rtb.AppendText("(" + va.InitialVerb.Infinitive + ") ");
                    }
                }

                rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                rtb.SelectionColor = Color.Black;
                rtb.AppendText("; ");

                // PRETERIT
                if (va.PreteritAnswer.NotAnswerable)
                {
                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Italic);
                    rtb.SelectionColor = Color.Gray;
                    rtb.AppendText(va.InitialVerb.Preterit + " ");
                }
                else
                {
                    foreach (string wa in va.PreteritAnswer.WrongAnswers)
                    {
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Strikeout);
                        rtb.SelectionColor = Color.Red;
                        rtb.AppendText(wa);
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(" ");
                    }

                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                    if (va.PreteritAnswer.AnsweredCorrectly)
                    {
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(va.InitialVerb.Preterit + " ");
                    }
                    else
                    {
                        rtb.SelectionColor = Color.Green;
                        rtb.AppendText("(" + va.InitialVerb.Preterit + ") ");
                    }
                }

                rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                rtb.SelectionColor = Color.Black;
                rtb.AppendText("; ");


                // PRESENT PERFECT
                if (va.PresentPerfectAnswer.NotAnswerable)
                {
                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Italic);
                    rtb.SelectionColor = Color.Gray;
                    rtb.AppendText(va.InitialVerb.PresentPerfect + " ");
                }
                else
                {
                    foreach (string wa in va.PresentPerfectAnswer.WrongAnswers)
                    {
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Strikeout);
                        rtb.SelectionColor = Color.Red;
                        rtb.AppendText(wa);
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(" ");
                    }

                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                    if (va.PresentPerfectAnswer.AnsweredCorrectly)
                    {
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(va.InitialVerb.PresentPerfect + " ");
                    }
                    else
                    {
                        rtb.SelectionColor = Color.Green;
                        rtb.AppendText("(" + va.InitialVerb.PresentPerfect + ") ");
                    }
                }

                rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                rtb.SelectionColor = Color.Black;
                rtb.AppendText("; ");
                

                // TRANSLATION
                if (va.TranslationAnswer.NotAnswerable)
                {
                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Italic);
                    rtb.SelectionColor = Color.Gray;
                    rtb.AppendText(va.InitialVerb.Translation + " ");
                }
                else
                {
                    foreach (string wa in va.TranslationAnswer.WrongAnswers)
                    {
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Strikeout);
                        rtb.SelectionColor = Color.Red;
                        rtb.AppendText(wa);
                        rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(" ");
                    }

                    rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                    if (va.TranslationAnswer.AnsweredCorrectly)
                    {
                        rtb.SelectionColor = Color.Black;
                        rtb.AppendText(va.InitialVerb.Translation + " ");
                    }
                    else
                    {
                        rtb.SelectionColor = Color.Green;
                        rtb.AppendText("(" + va.InitialVerb.Translation + ") ");
                    }
                }

                // DURATION
                rtb.SelectionFont = new Font(new FontFamily("Segoe UI"), (float)9.75, FontStyle.Regular);
                rtb.SelectionColor = Color.Black;
                rtb.AppendText("| Time: " + va.VerbElapsedTime.ToString(@"mm\:ss\,ff"));

                rtb.AppendText(Environment.NewLine);
                i++;
            }

            rtb.SelectionStart = 0;
            rtb.ScrollToCaret();
        }

        private void CopyToClipboardBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataObject m_data = new DataObject();

                m_data.SetData(DataFormats.Rtf, true, rtb.Rtf);
                // NOTE: '\line' converts to a linefeed only.  Replace linefeed only with \r\n
                // However '\par' converts to \r\n so you may want to use a regex to make sure you
                // are only replacing \n that are not preceeded by \r
                m_data.SetData(DataFormats.Text, true, rtb.Text.Replace("\n", "\r\n"));
                Clipboard.SetDataObject(m_data, true);
                MessageBox.Show("Successfully copied your training stats to the Clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not copy your training stats to the Clipboard. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
