using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IVT.Objects;
using IVT.Tools;
using IVT.Forms;

namespace IVT.Forms
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();

            LoadHistorical();
        }

        private void LoadHistorical()
        {
            lstView.Items.Clear();

            foreach (TrainingHistory item in HistoryManager.GetTrainingHistoryList())
            {
                ListViewItem lvi = new ListViewItem()
                {
                    UseItemStyleForSubItems = false
                };
                if (item.Mode == AnswerMode.Normal)
                {
                    lvi.ImageKey = "flame16.png";
                    lvi.Text = " Normal";
                    lvi.SubItems.Add(item.Date.ToShortDateString() + " " + item.Date.ToLongTimeString());
                    lvi.SubItems.Add(item.ListName);
                    if (item.Score >= 20)
                    {
                        lvi.SubItems.Add(item.Score.ToString(), Color.Green, Color.Transparent, new Font(new FontFamily("Segoe UI"), 9.75f));
                    }
                    else if (item.Score > 0)
                    {
                        lvi.SubItems.Add(item.Score.ToString(), Color.DarkOrange, Color.Transparent, new Font(new FontFamily("Segoe UI"), 9.75f));
                    }
                    else if (item.Score <= 0)
                    {
                        lvi.SubItems.Add(item.Score.ToString(), Color.Red, Color.Transparent, new Font(new FontFamily("Segoe UI"), 9.75f));
                    }
                    lvi.SubItems.Add(item.Duration.ToString(@"hh\:mm\:ss"));                    
                }
                else if (item.Mode == AnswerMode.Timer)
                {
                    lvi.ImageKey = "clock16.png";
                    lvi.Text = " Against the clock";
                    lvi.SubItems.Add(item.Date.ToShortDateString() + " " + item.Date.ToLongTimeString());
                    lvi.SubItems.Add(item.ListName);
                    if (item.ObjectiveWon)
                    {
                        lvi.SubItems.Add("Objective reached", Color.Green, Color.Transparent, new Font(new FontFamily("Segoe UI"), 9.75f));
                    }
                    else
                    {
                        lvi.SubItems.Add("Objective failed", Color.Red, Color.Transparent, new Font(new FontFamily("Segoe UI"), 9.75f));
                    }
                    lvi.SubItems.Add(item.Duration.ToString(@"hh\:mm\:ss"));
                }

                lvi.Tag = item.Date;

                lstView.Items.Add(lvi);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you really want to clear your training history?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            HistoryManager.ClearTrainingHistoryList();
            lstView.Items.Clear();
        }

        private void LstView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstView.SelectedItems.Count >= 1)
            {
                lstViewCtx.Show(MousePosition);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count >= 1)
            {
                if (MessageBox.Show(this, "Do you really want to delete the selected training history(-ies)?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
                foreach (ListViewItem item in lstView.SelectedItems)
                {
                    HistoryManager.RemoveTrainingHistory((DateTime)item.Tag);
                    lstView.Items[item.Index].Remove();
                }
            }
        }

        private void LstView_DoubleClick(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count >= 1)
            {
                DetailedStatsForm detailedStatsForm = new DetailedStatsForm(HistoryManager.GetTrainingHistory((DateTime)lstView.SelectedItems[0].Tag));

                Point location = this.PointToScreen(Point.Empty);
                detailedStatsForm.Location = new Point(location.X + (this.Width / 2) - (detailedStatsForm.Width / 2),
                    location.Y + (this.Height / 2) - (detailedStatsForm.Height / 2) - 30);

                detailedStatsForm.ShowDialog();
            }
        }

        private void LstView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lstView.SelectedItems.Count >= 1)
            {
                DetailedStatsForm detailedStatsForm = new DetailedStatsForm(HistoryManager.GetTrainingHistory((DateTime)lstView.SelectedItems[0].Tag));

                Point location = this.PointToScreen(Point.Empty);
                detailedStatsForm.Location = new Point(location.X + (this.Width / 2) - (detailedStatsForm.Width / 2),
                    location.Y + (this.Height / 2) - (detailedStatsForm.Height / 2) - 30);

                detailedStatsForm.ShowDialog();
            }
        }
    }
}
