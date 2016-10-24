namespace ExtractCsvFromExcel
{
    partial class frmAnalyseerData
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
            this.cmbKolomnamen = new System.Windows.Forms.ComboBox();
            this.lboOmschrijvingen = new System.Windows.Forms.ListBox();
            this.cmbCompatibleSets = new System.Windows.Forms.ComboBox();
            this.btnVeranderProductnaam = new System.Windows.Forms.Button();
            this.txtProductnaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chbOmschrijvend = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKolomnamen
            // 
            this.cmbKolomnamen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKolomnamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbKolomnamen.FormattingEnabled = true;
            this.cmbKolomnamen.Location = new System.Drawing.Point(6, 16);
            this.cmbKolomnamen.Name = "cmbKolomnamen";
            this.cmbKolomnamen.Size = new System.Drawing.Size(498, 267);
            this.cmbKolomnamen.TabIndex = 0;
            this.cmbKolomnamen.SelectedIndexChanged += new System.EventHandler(this.cmbKolomnamen_SelectedIndexChanged);
            // 
            // lboOmschrijvingen
            // 
            this.lboOmschrijvingen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboOmschrijvingen.BackColor = System.Drawing.SystemColors.Window;
            this.lboOmschrijvingen.FormattingEnabled = true;
            this.lboOmschrijvingen.Location = new System.Drawing.Point(6, 312);
            this.lboOmschrijvingen.Name = "lboOmschrijvingen";
            this.lboOmschrijvingen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboOmschrijvingen.Size = new System.Drawing.Size(498, 394);
            this.lboOmschrijvingen.TabIndex = 1;
            // 
            // cmbCompatibleSets
            // 
            this.cmbCompatibleSets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompatibleSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCompatibleSets.FormattingEnabled = true;
            this.cmbCompatibleSets.Location = new System.Drawing.Point(9, 16);
            this.cmbCompatibleSets.Name = "cmbCompatibleSets";
            this.cmbCompatibleSets.Size = new System.Drawing.Size(461, 513);
            this.cmbCompatibleSets.TabIndex = 2;
            this.cmbCompatibleSets.SelectedIndexChanged += new System.EventHandler(this.cmbKolomnamen_SelectedIndexChanged);
            // 
            // btnVeranderProductnaam
            // 
            this.btnVeranderProductnaam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVeranderProductnaam.Location = new System.Drawing.Point(386, 61);
            this.btnVeranderProductnaam.Name = "btnVeranderProductnaam";
            this.btnVeranderProductnaam.Size = new System.Drawing.Size(75, 23);
            this.btnVeranderProductnaam.TabIndex = 3;
            this.btnVeranderProductnaam.Text = "Wijzigen";
            this.btnVeranderProductnaam.UseVisualStyleBackColor = true;
            this.btnVeranderProductnaam.Click += new System.EventHandler(this.btnVeranderProductnaam_Click);
            // 
            // txtProductnaam
            // 
            this.txtProductnaam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductnaam.Location = new System.Drawing.Point(6, 19);
            this.txtProductnaam.Name = "txtProductnaam";
            this.txtProductnaam.Size = new System.Drawing.Size(461, 20);
            this.txtProductnaam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kies de beschrijvende kolom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Productmodellen";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtProductnaam);
            this.groupBox1.Controls.Add(this.btnVeranderProductnaam);
            this.groupBox1.Location = new System.Drawing.Point(3, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voeg toe aan subset";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(395, 714);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Sluiten";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chbOmschrijvend
            // 
            this.chbOmschrijvend.AutoSize = true;
            this.chbOmschrijvend.Location = new System.Drawing.Point(6, 289);
            this.chbOmschrijvend.Name = "chbOmschrijvend";
            this.chbOmschrijvend.Size = new System.Drawing.Size(127, 17);
            this.chbOmschrijvend.TabIndex = 9;
            this.chbOmschrijvend.Text = "Omschrijvende kolom";
            this.chbOmschrijvend.UseVisualStyleBackColor = true;
            this.chbOmschrijvend.Click += new System.EventHandler(this.chbOmschrijvend_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lboOmschrijvingen);
            this.splitContainer1.Panel1.Controls.Add(this.chbOmschrijvend);
            this.splitContainer1.Panel1.Controls.Add(this.cmbKolomnamen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cmbCompatibleSets);
            this.splitContainer1.Size = new System.Drawing.Size(984, 740);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 10;
            // 
            // frmAnalyseerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 764);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAnalyseerData";
            this.Text = "Bewerk productgroepen";
            this.Load += new System.EventHandler(this.frmAnalyseerData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKolomnamen;
        private System.Windows.Forms.ListBox lboOmschrijvingen;
        private System.Windows.Forms.ComboBox cmbCompatibleSets;
        private System.Windows.Forms.Button btnVeranderProductnaam;
        private System.Windows.Forms.TextBox txtProductnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chbOmschrijvend;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}