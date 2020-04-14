using IVT.Objects;
using IVT.Xml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IVT.Forms
{
    public partial class EditVerbsForm : Form
    {
        private bool fileChanged = false;
        private bool userHasEdit = false;

        public EditVerbsForm(EditRequest editRequest = EditRequest.Default)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            UserHasEdit = false;

            if (!File.Exists(Properties.Settings.Default.verbsFilePath) && Properties.Settings.Default.verbsFilePath != "")
            {
                MessageBox.Show(this, "Your last file \"" + Path.GetFileName(Properties.Settings.Default.verbsFilePath)
                    + "\" could not be found. Relocate it or create a new one trough the Edit window.", this.Text + " - File could not be located",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Properties.Settings.Default.verbsFilePath = "";
                Properties.Settings.Default.Save();
            }

            if (editRequest == EditRequest.CreateNewFile)
            {
                ParseDictionaryInGrid(null);
            }
            else if (editRequest == EditRequest.OpenFile)
            {
                OpenFileBtn_Click(null, null);
            }
            else
            {
                if (Properties.Settings.Default.verbsFilePath == "") // If no stored file path, start a new File
                {
                    ParseDictionaryInGrid(null);
                }
                else
                {
                    ParseDictionaryInGrid(XmlEditor.ReadDictionnaryInFile(Properties.Settings.Default.verbsFilePath));
                }
            }

            UpdateTitleWithFileName();
        }

        public bool FileChanged { get => fileChanged; private set => fileChanged = value; }
        public bool UserHasEdit { get => userHasEdit; private set { if (value && !FileChanged) { FileChanged = true; }; userHasEdit = value; } }

        public void NewBtn_Click(object sender, EventArgs e)
        {
            dataGrdVw.EndEdit();
            if (UserHasEdit)
            {
                AskSaveModifications();
            }

            ParseDictionaryInGrid(null); // reset the grid

            Properties.Settings.Default.verbsFilePath = "";
            Properties.Settings.Default.Save();
            UpdateTitleWithFileName();
        }

        public void OpenFileBtn_Click(object sender, EventArgs e)
        {
            dataGrdVw.EndEdit();
            if (UserHasEdit)
            {
                AskSaveModifications();
            }

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Open an Irregular Verbs Trainer file",
                Filter = "Irregular Verbs Trainer file (*.ivt)|*.ivt|All files (*.*)|*.*",
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ParseDictionaryInGrid(XmlEditor.ReadDictionnaryInFile(ofd.FileName));
                Properties.Settings.Default.verbsFilePath = ofd.FileName; // Set active file as new one
                Properties.Settings.Default.Save();
                UpdateTitleWithFileName();
                return;
            }
            else
            {
                return;
            }
        }

        private void AskSaveModifications()
        {
            DialogResult result = MessageBox.Show("Do you want to save modifications?", "Save modifications",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {
                SaveBtn_ButtonClick(null, null);
            }
            // If no, simply continue
        }

        private void DataGrdVw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.
            dataGrdVw.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void DataGrdVw_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Confirm that the cell is not empty.
            if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()) && !dataGrdVw.Rows[e.RowIndex].IsNewRow)
            {
                dataGrdVw.Rows[e.RowIndex].ErrorText =
                    "All verb forms must be completed.";
                e.Cancel = true;
            }
        }

        private void DataGrdVw_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UserHasEdit = true;
            UpdateTitleWithFileName();
        }

        private void FileNameLbl_Click(object sender, EventArgs e)
        {
            dataGrdVw.EndEdit();
            if (Properties.Settings.Default.verbsFilePath != "")
            {
                Process.Start(Path.GetDirectoryName(Properties.Settings.Default.verbsFilePath));
            }
        }

        private Dictionary<string, Verb> ParseDataInDictionary()
        {
            // Format DataGrdVw as a Dictionary
            Dictionary<string, Verb> activeDict = new Dictionary<string, Verb>();

            foreach (DataGridViewRow row in dataGrdVw.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        MessageBox.Show("Missing verb form.", this.Text + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGrdVw.CurrentCell = cell;
                        return null;
                    }
                    else
                    {
                        if (String.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            MessageBox.Show("Missing verb form.", this.Text + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGrdVw.CurrentCell = cell;
                            return null;
                        }
                    }
                }

                Verb rowVerb = new Verb(Regex.Replace(row.Cells["infinitiveCol"].Value.ToString(), @"\s+", " "),
                    Regex.Replace(row.Cells["preteritCol"].Value.ToString(), @"\s+", " "),
                    Regex.Replace(row.Cells["ppCol"].Value.ToString(), @"\s+", " "),
                    Regex.Replace(row.Cells["translationCol"].Value.ToString(), @"\s+", " "));

                activeDict.Add(rowVerb.Infinitive, rowVerb);
            }

            return activeDict;
        }

        private void ParseDictionaryInGrid(Dictionary<string, Verb> dict)
        {
            // Reset the grid
            dataGrdVw.Rows.Clear();
            dataGrdVw.Columns.Clear();
            this.dataGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infinitiveCol,
            this.preteritCol,
            this.ppCol,
            this.translationCol});

            if (dict == null)
            {
                UserHasEdit = false;
                return;
            }

            // Parse data
            foreach (Verb verbDict in dict.Values)
            {
                dataGrdVw.Rows.Add(verbDict.Infinitive, verbDict.Preterit, verbDict.PresentPerfect, verbDict.Translation);
            }

            dataGrdVw.CurrentCell = dataGrdVw.Rows[dataGrdVw.NewRowIndex].Cells[0];

            UserHasEdit = false;
            UpdateTitleWithFileName();
        }

        private void SaveAsBtn_Click(object sender, EventArgs e)
        {
            dataGrdVw.EndEdit();

            SaveFileDialog sfd = new SaveFileDialog()
            {
                AddExtension = true,
                DefaultExt = "ivt",
                CheckPathExists = true,
                Title = "Save your list of irregular verbs",
                OverwritePrompt = true,
                Filter = "Irregular Verbs Trainer File (*.ivt)|*.ivt"
            };
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Dictionary<string, Verb> activeDict = ParseDataInDictionary();
            if (activeDict == null) return;

            if (XmlEditor.SaveDictionaryInFile(activeDict, sfd.FileName)) // If save was done TRUE
            {
                Properties.Settings.Default.verbsFilePath = sfd.FileName; // Set active file as new one
                Properties.Settings.Default.Save();
                UserHasEdit = false;
                UpdateTitleWithFileName();
            }
            else
            {
                return;
            }
        }

        private void SaveBtn_ButtonClick(object sender, EventArgs e)
        {
            Save();
        }

        private void Save(bool closeAfter = false)
        {
            string savePath;

            dataGrdVw.EndEdit();

            if (Properties.Settings.Default.verbsFilePath == "") // If no stored file path, start a new File
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    AddExtension = true,
                    DefaultExt = "ivt",
                    CheckPathExists = true,
                    Title = "Save your list of irregular verbs",
                    OverwritePrompt = true,
                    Filter = "Irregular Verbs Trainer File (*.ivt)|*.ivt"
                };
                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                savePath = sfd.FileName;
            }
            else
            {
                savePath = Properties.Settings.Default.verbsFilePath;
            }

            Dictionary<string, Verb> activeDict = ParseDataInDictionary();
            if (activeDict == null) return;

            if (XmlEditor.SaveDictionaryInFile(activeDict, savePath)) // If save was done TRUE
            {
                Properties.Settings.Default.verbsFilePath = savePath; // Set active file as new one
                Properties.Settings.Default.Save();
                UserHasEdit = false;
                UpdateTitleWithFileName();
            }
            else
            {
                return;
            }

            if (closeAfter)
            {
                this.Close();
            }
        }

        private void UpdateTitleWithFileName()
        {
            if (Properties.Settings.Default.verbsFilePath == "")
            {
                this.Text = "Irregular verbs list edit - Unsaved*";
                fileNameLbl.Text = "Editing: Unsaved*";
            }
            else
            {
                this.Text = "Irregular verbs list edit - " + Path.GetFileName(Properties.Settings.Default.verbsFilePath);
                fileNameLbl.Text = "Editing: " + Path.GetFileName(Properties.Settings.Default.verbsFilePath);
                if (UserHasEdit)
                {
                    this.Text += "*";
                    fileNameLbl.Text += "*";
                }
            }
        }

        private void DataGrdVw_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (String.IsNullOrWhiteSpace((String)dataGrdVw.CurrentCell.Value) && !dataGrdVw.CurrentRow.IsNewRow && dataGrdVw.SelectedCells[0].RowIndex != e.RowIndex)
                {
                    return;
                }

                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (dataGrdVw.Rows[e.RowIndex].IsNewRow)
                {
                    return;
                }
                else if (e.ColumnIndex < 0)
                {
                    if (!dataGrdVw.Rows[e.RowIndex].Selected)
                    {
                        dataGrdVw.ClearSelection();
                        dataGrdVw.Rows[e.RowIndex].Selected = true;
                    }
                    dataGrdVwCtx.Show(MousePosition);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace((String)dataGrdVw.CurrentCell.Value)
                        | (String.IsNullOrWhiteSpace((String)dataGrdVw.CurrentCell.Value) && dataGrdVw.CurrentRow.IsNewRow))
                    {
                        dataGrdVw.CurrentCell = dataGrdVw.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        addToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        addToolStripMenuItem.Visible = false;
                    }
                    dataGrdVw.Rows[e.RowIndex].Selected = true;
                    dataGrdVw.Focus();
                    dataGrdVwCtx.Show(MousePosition);
                }
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrdVw.SelectedRows.Count >= 1)
            {
                dataGrdVw.Rows.Insert(dataGrdVw.SelectedRows[0].Index, 1);
                dataGrdVw.CurrentCell = dataGrdVw.Rows[dataGrdVw.SelectedRows[0].Index - 1].Cells[0];
            }
        }

        private void DeleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrdVw.SelectedRows.Count >= 1)
            {
                if (MessageBox.Show(this, "Do you really want to delete the selected row(s)?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
                foreach (DataGridViewRow row in dataGrdVw.SelectedRows)
                {
                    dataGrdVw.Rows.Remove(row);
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Save(true);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditVerbsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userHasEdit)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before exit?", "Warning", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    Save(true);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}