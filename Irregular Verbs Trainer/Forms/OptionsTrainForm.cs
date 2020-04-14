using IVT.Objects;
using System;
using System.Windows.Forms;

namespace IVT.Forms
{
    public partial class OptionsTrainForm : Form
    {
        public OptionsTrainForm()
        {
            InitializeComponent();

            LoadParameters();

            if (timerRdo.Checked)
            {
                timerTimingTimePicker.Enabled = true;
                timerVerbsNup.Enabled = true;
            }
            else
            {
                timerTimingTimePicker.Enabled = false;
                timerVerbsNup.Enabled = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void GapChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox init = (CheckBox)sender;
            if (init.Checked)
            {
                randomChk.Checked = false;
            }
            if (infinitiveChk.Checked
                && preteritChk.Checked
                && ppChk.Checked
                && translationChk.Checked)
            {
                randomChk.Checked = true;
            }
        }

        private void LoadParameters()
        {
            if (Properties.Settings.Default.answerMode == AnswerMode.Normal)
            {
                normalModeRdo.Checked = true;
            }
            else
            {
                timerRdo.Checked = true;
            }

            timerVerbsNup.Value = Properties.Settings.Default.timerModeNumberOfVerbs;
            timerTimingTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                Properties.Settings.Default.timerModeTiming.Hours,
                Properties.Settings.Default.timerModeTiming.Minutes,
                Properties.Settings.Default.timerModeTiming.Seconds);

            infinitiveChk.Checked = Properties.Settings.Default.infinitiveGap;
            preteritChk.Checked = Properties.Settings.Default.preteritGap;
            ppChk.Checked = Properties.Settings.Default.ppGap;
            translationChk.Checked = Properties.Settings.Default.translationGap;
            randomChk.Checked = Properties.Settings.Default.randomGaps;

            if (Properties.Settings.Default.verbApparitionMode == VerbsAppartionMode.Random)
            {
                randomRdo.Checked = true;
            }
            else if (Properties.Settings.Default.verbApparitionMode == VerbsAppartionMode.Ascendant)
            {
                ascendantRdo.Checked = true;
            }
            else if (Properties.Settings.Default.verbApparitionMode == VerbsAppartionMode.Descendent)
            {
                descendentRdo.Checked = true;
            }

            availableChancesNup.Value = Properties.Settings.Default.availableChances;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            SaveParameters();
            this.DialogResult = DialogResult.OK;
        }

        private void RandomGapChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox init = (CheckBox)sender;
            if (init.Checked)
            {
                infinitiveChk.Checked = false;
                preteritChk.Checked = false;
                ppChk.Checked = false;
                translationChk.Checked = false;
            }
        }

        private void SaveParameters()
        {
            if (normalModeRdo.Checked)
            {
                Properties.Settings.Default.answerMode = Objects.AnswerMode.Normal;
            }
            else
            {
                Properties.Settings.Default.answerMode = Objects.AnswerMode.Timer;
            }

            Properties.Settings.Default.timerModeNumberOfVerbs = (int)timerVerbsNup.Value;
            Properties.Settings.Default.timerModeTiming = new TimeSpan(timerTimingTimePicker.Value.Hour,
                timerTimingTimePicker.Value.Minute, timerTimingTimePicker.Value.Second);

            Properties.Settings.Default.infinitiveGap = infinitiveChk.Checked;
            Properties.Settings.Default.preteritGap = preteritChk.Checked;
            Properties.Settings.Default.ppGap = ppChk.Checked;
            Properties.Settings.Default.translationGap = translationChk.Checked;
            Properties.Settings.Default.randomGaps = randomChk.Checked;

            if (randomRdo.Checked)
            {
                Properties.Settings.Default.verbApparitionMode = VerbsAppartionMode.Random;
            }
            else if (ascendantRdo.Checked)
            {
                Properties.Settings.Default.verbApparitionMode = VerbsAppartionMode.Ascendant;
            }
            else if (descendentRdo.Checked)
            {
                Properties.Settings.Default.verbApparitionMode = VerbsAppartionMode.Descendent;
            }

            Properties.Settings.Default.availableChances = (int)availableChancesNup.Value;

            Properties.Settings.Default.Save();
        }

        private void TimerRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (timerRdo.Checked)
            {
                timerTimingTimePicker.Enabled = true;
                timerVerbsNup.Enabled = true;
            }
            else
            {
                timerTimingTimePicker.Enabled = false;
                timerVerbsNup.Enabled = false;
            }
        }
    }
}