namespace ExtractCsvFromExcel
{
    partial class frmLinkParameters
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
            this.lboParameters = new System.Windows.Forms.ListBox();
            this.btnMaakParameter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBewaarCsv = new System.Windows.Forms.Button();
            this.tboCsvNaam = new System.Windows.Forms.TextBox();
            this.btnMaakFeature = new System.Windows.Forms.Button();
            this.dgrCsvGegevens = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDoubleData = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.sfdBewaarCsv = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCsvGegevens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboParameters
            // 
            this.lboParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboParameters.FormattingEnabled = true;
            this.lboParameters.Location = new System.Drawing.Point(3, 3);
            this.lboParameters.Name = "lboParameters";
            this.lboParameters.Size = new System.Drawing.Size(288, 550);
            this.lboParameters.TabIndex = 0;
            this.lboParameters.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lboParameters_DrawItem);
            this.lboParameters.SelectedIndexChanged += new System.EventHandler(this.lboParameters_SelectedIndexChanged);
            // 
            // btnMaakParameter
            // 
            this.btnMaakParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaakParameter.Enabled = false;
            this.btnMaakParameter.Location = new System.Drawing.Point(12, 607);
            this.btnMaakParameter.Name = "btnMaakParameter";
            this.btnMaakParameter.Size = new System.Drawing.Size(110, 23);
            this.btnMaakParameter.TabIndex = 3;
            this.btnMaakParameter.Text = "Voeg parameter toe";
            this.btnMaakParameter.UseVisualStyleBackColor = true;
            this.btnMaakParameter.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnBewaarCsv);
            this.groupBox1.Controls.Add(this.tboCsvNaam);
            this.groupBox1.Location = new System.Drawing.Point(12, 649);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bewaar CSV";
            // 
            // btnBewaarCsv
            // 
            this.btnBewaarCsv.Location = new System.Drawing.Point(222, 17);
            this.btnBewaarCsv.Name = "btnBewaarCsv";
            this.btnBewaarCsv.Size = new System.Drawing.Size(30, 23);
            this.btnBewaarCsv.TabIndex = 5;
            this.btnBewaarCsv.Text = "...";
            this.btnBewaarCsv.UseVisualStyleBackColor = true;
            this.btnBewaarCsv.Click += new System.EventHandler(this.btnBewaarCsv_Click);
            // 
            // tboCsvNaam
            // 
            this.tboCsvNaam.Location = new System.Drawing.Point(6, 19);
            this.tboCsvNaam.Name = "tboCsvNaam";
            this.tboCsvNaam.Size = new System.Drawing.Size(210, 20);
            this.tboCsvNaam.TabIndex = 0;
            // 
            // btnMaakFeature
            // 
            this.btnMaakFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaakFeature.Location = new System.Drawing.Point(127, 607);
            this.btnMaakFeature.Name = "btnMaakFeature";
            this.btnMaakFeature.Size = new System.Drawing.Size(110, 23);
            this.btnMaakFeature.TabIndex = 6;
            this.btnMaakFeature.Text = "Voeg feature toe";
            this.btnMaakFeature.UseVisualStyleBackColor = true;
            this.btnMaakFeature.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgrCsvGegevens
            // 
            this.dgrCsvGegevens.AllowUserToAddRows = false;
            this.dgrCsvGegevens.AllowUserToDeleteRows = false;
            this.dgrCsvGegevens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrCsvGegevens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCsvGegevens.EnableHeadersVisualStyles = false;
            this.dgrCsvGegevens.Location = new System.Drawing.Point(3, 3);
            this.dgrCsvGegevens.Name = "dgrCsvGegevens";
            this.dgrCsvGegevens.Size = new System.Drawing.Size(591, 547);
            this.dgrCsvGegevens.TabIndex = 5;
            this.dgrCsvGegevens.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgrCsvGegevens_CellBeginEdit);
            this.dgrCsvGegevens.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrCsvGegevens_CellEndEdit);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(26, 24);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(35, 13);
            this.lblProduct.TabIndex = 9;
            this.lblProduct.Text = "label1";
            // 
            // lblDoubleData
            // 
            this.lblDoubleData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoubleData.AutoSize = true;
            this.lblDoubleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDoubleData.Location = new System.Drawing.Point(683, 666);
            this.lblDoubleData.Name = "lblDoubleData";
            this.lblDoubleData.Size = new System.Drawing.Size(214, 13);
            this.lblDoubleData.TabIndex = 10;
            this.lblDoubleData.Text = "Er zijn dubbele gegevens gevonden!";
            this.lblDoubleData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDoubleData.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(832, 712);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(751, 712);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUndo.Location = new System.Drawing.Point(837, 19);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(70, 23);
            this.btnUndo.TabIndex = 13;
            this.btnUndo.Text = "Stap terug";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // sfdBewaarCsv
            // 
            this.sfdBewaarCsv.Filter = "csv|*.csv";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lboParameters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgrCsvGegevens);
            this.splitContainer1.Size = new System.Drawing.Size(895, 553);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 14;
            // 
            // frmLinkParameters
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(919, 747);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDoubleData);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnMaakFeature);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMaakParameter);
            this.Name = "frmLinkParameters";
            this.Text = "Bewerk parameters";
            this.Load += new System.EventHandler(this.frmLinkParameters_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCsvGegevens)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboParameters;
        private System.Windows.Forms.Button btnMaakParameter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBewaarCsv;
        private System.Windows.Forms.TextBox tboCsvNaam;
        private System.Windows.Forms.Button btnMaakFeature;
        private System.Windows.Forms.DataGridView dgrCsvGegevens;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblDoubleData;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.SaveFileDialog sfdBewaarCsv;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}