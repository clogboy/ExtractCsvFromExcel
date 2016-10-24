namespace ExtractCsvFromExcel
{
    partial class CsvGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CsvGenerator));
            this.ofdOpenExcel = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBestand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaakProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKoppelExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBewerkSubsets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelecteerBestand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHerstellen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWerkblad = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgrExcelData = new System.Windows.Forms.DataGridView();
            this.trvProductModelTypes = new System.Windows.Forms.TreeView();
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.veranderStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddComment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveComment = new System.Windows.Forms.ToolStripMenuItem();
            this.splTreeAndDataGrid = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tboSearch = new System.Windows.Forms.TextBox();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrExcelData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splTreeAndDataGrid)).BeginInit();
            this.splTreeAndDataGrid.Panel1.SuspendLayout();
            this.splTreeAndDataGrid.Panel2.SuspendLayout();
            this.splTreeAndDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdOpenExcel
            // 
            this.ofdOpenExcel.Filter = "Microsoft Excel 2007|*.xlsx";
            this.ofdOpenExcel.Title = "Selecteer Excel bestand";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBestand,
            this.mnuProject});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBestand
            // 
            this.mnuBestand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaakProject,
            this.mnuOpenProject});
            this.mnuBestand.Name = "mnuBestand";
            this.mnuBestand.Size = new System.Drawing.Size(61, 20);
            this.mnuBestand.Text = "&Bestand";
            // 
            // mnuMaakProject
            // 
            this.mnuMaakProject.Enabled = false;
            this.mnuMaakProject.Name = "mnuMaakProject";
            this.mnuMaakProject.Size = new System.Drawing.Size(174, 22);
            this.mnuMaakProject.Text = "B&ewaar project...";
            this.mnuMaakProject.Click += new System.EventHandler(this.mnuMaakProject_Click);
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.Size = new System.Drawing.Size(174, 22);
            this.mnuOpenProject.Text = "&Open een project...";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuProject
            // 
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKoppelExcel,
            this.toolStripSeparator1,
            this.mnuBewerkSubsets,
            this.mnuUpdateData});
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(56, 20);
            this.mnuProject.Text = "&Project";
            // 
            // mnuKoppelExcel
            // 
            this.mnuKoppelExcel.Name = "mnuKoppelExcel";
            this.mnuKoppelExcel.Size = new System.Drawing.Size(207, 22);
            this.mnuKoppelExcel.Text = "&Koppel een Excel bestand";
            this.mnuKoppelExcel.Click += new System.EventHandler(this.mnuKoppelExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // mnuBewerkSubsets
            // 
            this.mnuBewerkSubsets.Enabled = false;
            this.mnuBewerkSubsets.Name = "mnuBewerkSubsets";
            this.mnuBewerkSubsets.Size = new System.Drawing.Size(207, 22);
            this.mnuBewerkSubsets.Text = "Bewerk &subsets...";
            this.mnuBewerkSubsets.Click += new System.EventHandler(this.btnAnalyseerTabel_Click);
            // 
            // mnuUpdateData
            // 
            this.mnuUpdateData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelecteerBestand,
            this.mnuHerstellen});
            this.mnuUpdateData.Enabled = false;
            this.mnuUpdateData.Name = "mnuUpdateData";
            this.mnuUpdateData.Size = new System.Drawing.Size(207, 22);
            this.mnuUpdateData.Text = "&Update Exceldata";
            // 
            // mnuSelecteerBestand
            // 
            this.mnuSelecteerBestand.Name = "mnuSelecteerBestand";
            this.mnuSelecteerBestand.Size = new System.Drawing.Size(206, 22);
            this.mnuSelecteerBestand.Text = "Bestand selecteren";
            this.mnuSelecteerBestand.Click += new System.EventHandler(this.mnuSelecteerBestand_Click);
            // 
            // mnuHerstellen
            // 
            this.mnuHerstellen.Enabled = false;
            this.mnuHerstellen.Name = "mnuHerstellen";
            this.mnuHerstellen.Size = new System.Drawing.Size(206, 22);
            this.mnuHerstellen.Text = "Wijzigingen terugdraaien";
            this.mnuHerstellen.Click += new System.EventHandler(this.wijzigingenTerugdraaienToolStripMenuItem_Click);
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(3, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(19, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(3, 32);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(19, 23);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWerkblad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(839, 22);
            this.statusStrip1.TabIndex = 5;
            // 
            // lblWerkblad
            // 
            this.lblWerkblad.Name = "lblWerkblad";
            this.lblWerkblad.Size = new System.Drawing.Size(0, 17);
            // 
            // dgrExcelData
            // 
            this.dgrExcelData.AllowUserToAddRows = false;
            this.dgrExcelData.AllowUserToDeleteRows = false;
            this.dgrExcelData.AllowUserToOrderColumns = true;
            this.dgrExcelData.AllowUserToResizeRows = false;
            this.dgrExcelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrExcelData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrExcelData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgrExcelData.Location = new System.Drawing.Point(28, 32);
            this.dgrExcelData.MultiSelect = false;
            this.dgrExcelData.Name = "dgrExcelData";
            this.dgrExcelData.ReadOnly = true;
            this.dgrExcelData.Size = new System.Drawing.Size(511, 457);
            this.dgrExcelData.TabIndex = 1;
            this.dgrExcelData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrExcelData_CellContentClick);
            // 
            // trvProductModelTypes
            // 
            this.trvProductModelTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvProductModelTypes.Location = new System.Drawing.Point(0, 0);
            this.trvProductModelTypes.Name = "trvProductModelTypes";
            this.trvProductModelTypes.ShowNodeToolTips = true;
            this.trvProductModelTypes.Size = new System.Drawing.Size(269, 489);
            this.trvProductModelTypes.StateImageList = this.imgIcons;
            this.trvProductModelTypes.TabIndex = 7;
            this.trvProductModelTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProductModelTypes_AfterSelect);
            this.trvProductModelTypes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvProductModelTypes_NodeMouseClick);
            this.trvProductModelTypes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvProductModelTypes_NodeMouseDoubleClick);
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons.Images.SetKeyName(0, "tag.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veranderStatusToolStripMenuItem,
            this.mnuAddComment,
            this.mnuRemoveComment});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // veranderStatusToolStripMenuItem
            // 
            this.veranderStatusToolStripMenuItem.Name = "veranderStatusToolStripMenuItem";
            this.veranderStatusToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.veranderStatusToolStripMenuItem.Text = "Verander status";
            this.veranderStatusToolStripMenuItem.Click += new System.EventHandler(this.veranderStatusToolStripMenuItem_Click);
            // 
            // mnuAddComment
            // 
            this.mnuAddComment.Name = "mnuAddComment";
            this.mnuAddComment.Size = new System.Drawing.Size(183, 22);
            this.mnuAddComment.Text = "Voeg opmerking toe";
            this.mnuAddComment.Click += new System.EventHandler(this.mnuAddComment_Click);
            // 
            // mnuRemoveComment
            // 
            this.mnuRemoveComment.Enabled = false;
            this.mnuRemoveComment.Name = "mnuRemoveComment";
            this.mnuRemoveComment.Size = new System.Drawing.Size(183, 22);
            this.mnuRemoveComment.Text = "Verwijder opmerking";
            this.mnuRemoveComment.Click += new System.EventHandler(this.mnuRemoveComment_Click);
            // 
            // splTreeAndDataGrid
            // 
            this.splTreeAndDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splTreeAndDataGrid.Location = new System.Drawing.Point(12, 27);
            this.splTreeAndDataGrid.Name = "splTreeAndDataGrid";
            // 
            // splTreeAndDataGrid.Panel1
            // 
            this.splTreeAndDataGrid.Panel1.Controls.Add(this.trvProductModelTypes);
            // 
            // splTreeAndDataGrid.Panel2
            // 
            this.splTreeAndDataGrid.Panel2.Controls.Add(this.label1);
            this.splTreeAndDataGrid.Panel2.Controls.Add(this.tboSearch);
            this.splTreeAndDataGrid.Panel2.Controls.Add(this.dgrExcelData);
            this.splTreeAndDataGrid.Panel2.Controls.Add(this.btnDown);
            this.splTreeAndDataGrid.Panel2.Controls.Add(this.btnUp);
            this.splTreeAndDataGrid.Size = new System.Drawing.Size(815, 489);
            this.splTreeAndDataGrid.SplitterDistance = 272;
            this.splTreeAndDataGrid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zoeken:";
            // 
            // tboSearch
            // 
            this.tboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboSearch.Enabled = false;
            this.tboSearch.Location = new System.Drawing.Point(275, 2);
            this.tboSearch.Name = "tboSearch";
            this.tboSearch.Size = new System.Drawing.Size(261, 20);
            this.tboSearch.TabIndex = 4;
            this.tboSearch.TextChanged += new System.EventHandler(this.tboSearch_TextChanged);
            // 
            // sfdSaveData
            // 
            this.sfdSaveData.Filter = "xml|*.xml";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.Filter = "xml|*.xml";
            // 
            // CsvGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 541);
            this.Controls.Add(this.splTreeAndDataGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CsvGenerator";
            this.Text = "ITANNEX csv generator voor ETIM-ready content";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsvGenerator_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrExcelData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splTreeAndDataGrid.Panel1.ResumeLayout(false);
            this.splTreeAndDataGrid.Panel2.ResumeLayout(false);
            this.splTreeAndDataGrid.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splTreeAndDataGrid)).EndInit();
            this.splTreeAndDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenExcel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBestand;
        private System.Windows.Forms.ToolStripMenuItem mnuMaakProject;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuKoppelExcel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWerkblad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuBewerkSubsets;
        private System.Windows.Forms.DataGridView dgrExcelData;
        private System.Windows.Forms.TreeView trvProductModelTypes;
        private System.Windows.Forms.SplitContainer splTreeAndDataGrid;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateData;
        private System.Windows.Forms.ToolStripMenuItem mnuHerstellen;
        private System.Windows.Forms.ToolStripMenuItem mnuSelecteerBestand;
        private System.Windows.Forms.TextBox tboSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veranderStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddComment;
        private System.Windows.Forms.ImageList imgIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveComment;
    }
}

