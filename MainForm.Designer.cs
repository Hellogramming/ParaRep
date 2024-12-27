namespace ParaRep
{
    partial class MainForm
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
            this.parametersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.commandLineRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.reduceToFileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduceToFileExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.restoreOriginalParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copySplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.copyAsTextListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsCommaDelimitedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsTabDelimitedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsXMLMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsHTMLMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsBatchCommandMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.reportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whichParametersComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parametersListView
            // 
            this.parametersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.parametersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parametersListView.FullRowSelect = true;
            this.parametersListView.Location = new System.Drawing.Point(0, 178);
            this.parametersListView.Name = "parametersListView";
            this.parametersListView.Size = new System.Drawing.Size(952, 236);
            this.parametersListView.TabIndex = 0;
            this.parametersListView.UseCompatibleStateImageBehavior = false;
            this.parametersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Parameter";
            this.columnHeader2.Width = 194;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.commandLineRichTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(952, 86);
            this.panel1.TabIndex = 3;
            // 
            // commandLineRichTextBox
            // 
            this.commandLineRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.commandLineRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commandLineRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLineRichTextBox.ForeColor = System.Drawing.Color.Gray;
            this.commandLineRichTextBox.Location = new System.Drawing.Point(10, 10);
            this.commandLineRichTextBox.Name = "commandLineRichTextBox";
            this.commandLineRichTextBox.ReadOnly = true;
            this.commandLineRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.commandLineRichTextBox.Size = new System.Drawing.Size(932, 66);
            this.commandLineRichTextBox.TabIndex = 0;
            this.commandLineRichTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.copySplitButton,
            this.saveButton,
            this.reportButton,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.whichParametersComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 86);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 10, 1);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(952, 92);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reduceToFileNameToolStripMenuItem,
            this.reduceToFileExtensionToolStripMenuItem,
            this.toolStripSeparator4,
            this.restoreOriginalParametersToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::ParaRep.Properties.Resources.ImageToolbarConvert48;
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(117, 85);
            this.toolStripDropDownButton2.Text = "Convert";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reduceToFileNameToolStripMenuItem
            // 
            this.reduceToFileNameToolStripMenuItem.Name = "reduceToFileNameToolStripMenuItem";
            this.reduceToFileNameToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.reduceToFileNameToolStripMenuItem.Text = "Reduce To File Name";
            this.reduceToFileNameToolStripMenuItem.Click += new System.EventHandler(this.reduceToFileNameToolStripMenuItem_Click);
            // 
            // reduceToFileExtensionToolStripMenuItem
            // 
            this.reduceToFileExtensionToolStripMenuItem.Name = "reduceToFileExtensionToolStripMenuItem";
            this.reduceToFileExtensionToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.reduceToFileExtensionToolStripMenuItem.Text = "Reduce To File Extension";
            this.reduceToFileExtensionToolStripMenuItem.Click += new System.EventHandler(this.reduceToFileExtensionToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(363, 6);
            // 
            // restoreOriginalParametersToolStripMenuItem
            // 
            this.restoreOriginalParametersToolStripMenuItem.Name = "restoreOriginalParametersToolStripMenuItem";
            this.restoreOriginalParametersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restoreOriginalParametersToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.restoreOriginalParametersToolStripMenuItem.Text = "Restore Original Parameters";
            this.restoreOriginalParametersToolStripMenuItem.Click += new System.EventHandler(this.restoreOriginalParametersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 88);
            // 
            // copySplitButton
            // 
            this.copySplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsTextListMenu,
            this.copyAsCommaDelimitedMenu,
            this.copyAsTabDelimitedMenu,
            this.copyAsXMLMenu,
            this.copyAsHTMLMenu,
            this.copyAsBatchCommandMenu});
            this.copySplitButton.Image = global::ParaRep.Properties.Resources.ImageToolbarCopy48;
            this.copySplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copySplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copySplitButton.Margin = new System.Windows.Forms.Padding(0, 1, 4, 2);
            this.copySplitButton.Name = "copySplitButton";
            this.copySplitButton.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.copySplitButton.Size = new System.Drawing.Size(100, 85);
            this.copySplitButton.Tag = "Text";
            this.copySplitButton.Text = "Copy";
            this.copySplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.copySplitButton.ButtonClick += new System.EventHandler(this.copyAsTextListMenu_Click);
            // 
            // copyAsTextListMenu
            // 
            this.copyAsTextListMenu.Name = "copyAsTextListMenu";
            this.copyAsTextListMenu.Size = new System.Drawing.Size(253, 30);
            this.copyAsTextListMenu.Tag = "Text";
            this.copyAsTextListMenu.Text = "As Text List (Default)";
            this.copyAsTextListMenu.Click += new System.EventHandler(this.copyAsTextListMenu_Click);
            // 
            // copyAsCommaDelimitedMenu
            // 
            this.copyAsCommaDelimitedMenu.Name = "copyAsCommaDelimitedMenu";
            this.copyAsCommaDelimitedMenu.Size = new System.Drawing.Size(253, 30);
            this.copyAsCommaDelimitedMenu.Tag = "CommaDelimited";
            this.copyAsCommaDelimitedMenu.Text = "As Comma Delimited";
            this.copyAsCommaDelimitedMenu.Click += new System.EventHandler(this.copyAsTextListMenu_Click);
            // 
            // copyAsTabDelimitedMenu
            // 
            this.copyAsTabDelimitedMenu.Name = "copyAsTabDelimitedMenu";
            this.copyAsTabDelimitedMenu.Size = new System.Drawing.Size(253, 30);
            this.copyAsTabDelimitedMenu.Tag = "TabDelimited";
            this.copyAsTabDelimitedMenu.Text = "As Tab Delimited";
            this.copyAsTabDelimitedMenu.Click += new System.EventHandler(this.copyAsTextListMenu_Click);
            // 
            // copyAsXMLMenu
            // 
            this.copyAsXMLMenu.Name = "copyAsXMLMenu";
            this.copyAsXMLMenu.Size = new System.Drawing.Size(253, 30);
            this.copyAsXMLMenu.Tag = "Xml";
            this.copyAsXMLMenu.Text = "As XML";
            this.copyAsXMLMenu.Click += new System.EventHandler(this.copyAsTextListMenu_Click);
            // 
            // copyAsHTMLMenu
            // 
            this.copyAsHTMLMenu.Name = "copyAsHTMLMenu";
            this.copyAsHTMLMenu.Size = new System.Drawing.Size(253, 30);
            this.copyAsHTMLMenu.Tag = "Html";
            this.copyAsHTMLMenu.Text = "As HTML";
            this.copyAsHTMLMenu.Click += new System.EventHandler(this.copyAsTextListMenu_Click);
            // 
            // copyAsBatchCommandMenu
            // 
            this.copyAsBatchCommandMenu.Name = "copyAsBatchCommandMenu";
            this.copyAsBatchCommandMenu.Size = new System.Drawing.Size(253, 30);
            this.copyAsBatchCommandMenu.Tag = "Batch";
            this.copyAsBatchCommandMenu.Text = "As Batch Command";
            this.copyAsBatchCommandMenu.Click += new System.EventHandler(this.copyAsTextListMenu_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::ParaRep.Properties.Resources.ImageToolbarSave48;
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.saveButton.Size = new System.Drawing.Size(83, 85);
            this.saveButton.Text = "Save";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Image = global::ParaRep.Properties.Resources.ImageToolbarReport48;
            this.reportButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportButton.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.reportButton.Size = new System.Drawing.Size(100, 85);
            this.reportButton.Text = "Report";
            this.reportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 88);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ParaRep.Properties.Resources.ImageToolbarRun48;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.toolStripButton1.Size = new System.Drawing.Size(82, 85);
            this.toolStripButton1.Text = "Run";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 88);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::ParaRep.Properties.Resources.ImageToolbarOnlineHelp48;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(92, 85);
            this.toolStripDropDownButton1.Text = "Help";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // whichParametersComboBox
            // 
            this.whichParametersComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.whichParametersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whichParametersComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.whichParametersComboBox.Items.AddRange(new object[] {
            "Use All Parameters From 1",
            "Use All Parameters From 0",
            "Use Selected Parameters",
            "Use Checked Parameters"});
            this.whichParametersComboBox.Name = "whichParametersComboBox";
            this.whichParametersComboBox.Size = new System.Drawing.Size(240, 88);
            this.whichParametersComboBox.SelectedIndexChanged += new System.EventHandler(this.whichParametersComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Comma Delimited Files (*.csv)|*.csv|Tab Delimited Files " +
    "(*.txt)|*.txt|XML Files (*.xml)|*.xml|HTML Files (*.html)|*.html|Batch Files (*." +
    "bat)|*.bat";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 436);
            this.Controls.Add(this.parametersListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "ParaReport";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView parametersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton copySplitButton;
        private System.Windows.Forms.ToolStripMenuItem copyAsTextListMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAsCommaDelimitedMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAsTabDelimitedMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAsXMLMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAsHTMLMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAsBatchCommandMenu;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton reportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox whichParametersComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox commandLineRichTextBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem reduceToFileNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduceToFileExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem restoreOriginalParametersToolStripMenuItem;
    }
}

