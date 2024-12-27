namespace ParaRep
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
using System.Collections;
    using System.IO;
    using System.Diagnostics;
    using System.Text;
using System.Collections.Generic;
    
    public partial class MainForm : Form
    {
        private string[] originalParameters;
        //private List<string> parameters;
        private char[] buffer;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            // Set the form's font to the default operating system font (Segoe UI on Vista)
            this.Font = SystemFonts.MessageBoxFont;

            // Required method for designer support
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.originalParameters = Environment.GetCommandLineArgs();
            //this.parameters = new List<string>(this.originalParameters);

//            this.parametersListView.VirtualListSize = this.parameters.

            for (int i = 0; i < this.originalParameters.Length; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(this.originalParameters[i]);
                this.parametersListView.Items.Add(item);
            }
            this.commandLineRichTextBox.Text = Environment.CommandLine;
            //this.textBox1.Text = Environment.CommandLine;


            


            //this.commandLineRichTextBox.RightMargin = TextRenderer.MeasureText(
              //  this.commandLineRichTextBox.Text, this.commandLineRichTextBox.Font).Width * 10;

            //this.commandLineRichTextBox.RightMargin = 500;
            this.buffer = new char[200];

            this.parametersListView.Columns[1].Width = this.parametersListView.ClientSize.Width - this.parametersListView.Columns[0].Width;
            UIFreshener.FreshenListView(this.parametersListView.Handle);
            this.whichParametersComboBox.SelectedIndex = 0;

            UIFreshener.ExtendGlassIntoClientArea(this.Handle, 0, this.panel1.Height, 0, 0);
            //UIFreshener.ExtendGlassIntoClientArea(this.Handle, -1, -1, -1, -1);
            this.TransparencyKey = Color.FromArgb(162, 161, 160);
            
            //this.parametersListView.SelectedIndices.

            /*
            string s = string.Empty;
            IDictionary environmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);
            foreach (DictionaryEntry de in environmentVariables)
            {
                s += de.Key.ToString() + " = " + de.Value.ToString() + Environment.NewLine;
            }
            Clipboard.SetText(s);
            */
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //if (GlassEnabled)
                e.Graphics.Clear(this.TransparencyKey);
            //else
              //  base.OnPaintBackground(e);
        }

        private bool IsUsableParameter(ListViewItem item)
        {
            return (((this.whichParametersComboBox.SelectedIndex == 0) && (item.Index > 0)) ||
                    ((this.whichParametersComboBox.SelectedIndex == 1) && (item.Index >= 0)) ||
                    ((this.whichParametersComboBox.SelectedIndex == 2) && item.Selected) ||
                    ((this.whichParametersComboBox.SelectedIndex == 3) && item.Checked));
        }

        IEnumerable<string> GetParametersToUse()
        {
            foreach (ListViewItem item in this.parametersListView.Items)
            {
                if (this.IsUsableParameter(item))
                {
                    yield return item.SubItems[1].Text;
                }
            }
        } 

        private void reportButton_Click(object sender, EventArgs e)
        {
            string reportPath = Path.ChangeExtension(Application.ExecutablePath, ".HTML");
            HTMLReportGenerator reportGenerator = new HTMLReportGenerator(reportPath, this.GetParametersToUse());
            Process.Start(reportPath);

            //this.parametersListView.Items.GetEnumerator().
        }

        private void copyAsTextListMenu_Click(object sender, EventArgs e)
        {
            ToolStripItem senderToolStrip = sender as ToolStripItem;
            if (senderToolStrip != null)
            {
                ParametersExporter.ExportType exportType = (ParametersExporter.ExportType)Enum.Parse(
                    typeof(ParametersExporter.ExportType), 
                    senderToolStrip.Tag as string);
                ParametersExporter.Copy(this.GetParametersToUse(), exportType);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ParametersExporter.Save(
                    this.saveFileDialog.FileName,
                    this.GetParametersToUse(),
                    (ParametersExporter.ExportType)this.saveFileDialog.FilterIndex - 1);
            }
        }

        private void whichParametersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.parametersListView.CheckBoxes = this.whichParametersComboBox.SelectedIndex == 3;
        }

        delegate string Conversion(int index, string parameter);


        private void DoConversion(Conversion conversion)
        {
            for (int i = 0; i < this.parametersListView.Items.Count; i++)
            {
                ListViewItem item = this.parametersListView.Items[i];
                if (this.IsUsableParameter(item))
                {
                    try
                    {
                        item.SubItems[1].Text = conversion(i, item.SubItems[1].Text);
                    }
                    catch (System.ArgumentException)
                    {

                    }
                }
            }
        }


        private void reduceToFileNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DoConversion((index, parameter) => { return Path.GetFileName(parameter); });
        }

        private void reduceToFileExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DoConversion((index, parameter) => { return Path.GetExtension(parameter); });
        }

        private void restoreOriginalParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DoConversion((index, parameter) => { return this.originalParameters[index]; });
        }
    }
}
