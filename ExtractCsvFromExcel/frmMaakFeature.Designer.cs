namespace ExtractCsvFromExcel
{
    partial class frmMaakFeature
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
            this.lboOmschrijvingen = new System.Windows.Forms.ListBox();
            this.tboFilterText = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tboFeatureNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFeatureNamen = new System.Windows.Forms.ComboBox();
            this.btnVerwijderFeature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboOmschrijvingen
            // 
            this.lboOmschrijvingen.FormattingEnabled = true;
            this.lboOmschrijvingen.Location = new System.Drawing.Point(12, 111);
            this.lboOmschrijvingen.Name = "lboOmschrijvingen";
            this.lboOmschrijvingen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboOmschrijvingen.Size = new System.Drawing.Size(407, 290);
            this.lboOmschrijvingen.TabIndex = 0;
            // 
            // tboFilterText
            // 
            this.tboFilterText.Location = new System.Drawing.Point(73, 407);
            this.tboFilterText.Name = "tboFilterText";
            this.tboFilterText.Size = new System.Drawing.Size(346, 20);
            this.tboFilterText.TabIndex = 1;
            this.tboFilterText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(373, 433);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(46, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter tekst";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(407, 59);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Voer tekst in om de producten waarop de feature van toepassing is te filteren. De" +
    "ze feature moet als checkbox of type worden aangemaakt in de family.";
            // 
            // tboFeatureNaam
            // 
            this.tboFeatureNaam.Enabled = false;
            this.tboFeatureNaam.Location = new System.Drawing.Point(94, 80);
            this.tboFeatureNaam.Name = "tboFeatureNaam";
            this.tboFeatureNaam.Size = new System.Drawing.Size(325, 20);
            this.tboFeatureNaam.TabIndex = 5;
            this.tboFeatureNaam.Visible = false;
            this.tboFeatureNaam.TextChanged += new System.EventHandler(this.tboFeatureNaam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Feature naam:";
            // 
            // cmbFeatureNamen
            // 
            this.cmbFeatureNamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeatureNamen.FormattingEnabled = true;
            this.cmbFeatureNamen.Location = new System.Drawing.Point(94, 80);
            this.cmbFeatureNamen.Name = "cmbFeatureNamen";
            this.cmbFeatureNamen.Size = new System.Drawing.Size(325, 21);
            this.cmbFeatureNamen.TabIndex = 7;
            this.cmbFeatureNamen.SelectedIndexChanged += new System.EventHandler(this.cmbFeatureNamen_SelectedIndexChanged);
            // 
            // btnVerwijderFeature
            // 
            this.btnVerwijderFeature.Enabled = false;
            this.btnVerwijderFeature.Location = new System.Drawing.Point(260, 433);
            this.btnVerwijderFeature.Name = "btnVerwijderFeature";
            this.btnVerwijderFeature.Size = new System.Drawing.Size(107, 23);
            this.btnVerwijderFeature.TabIndex = 8;
            this.btnVerwijderFeature.Text = "Verwijder feature";
            this.btnVerwijderFeature.UseVisualStyleBackColor = true;
            this.btnVerwijderFeature.Visible = false;
            this.btnVerwijderFeature.Click += new System.EventHandler(this.btnVerwijderFeature_Click);
            // 
            // frmMaakFeature
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 467);
            this.Controls.Add(this.btnVerwijderFeature);
            this.Controls.Add(this.cmbFeatureNamen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboFeatureNaam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tboFilterText);
            this.Controls.Add(this.lboOmschrijvingen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaakFeature";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feature";
            this.Load += new System.EventHandler(this.frmMaakFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboOmschrijvingen;
        private System.Windows.Forms.TextBox tboFilterText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tboFeatureNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFeatureNamen;
        private System.Windows.Forms.Button btnVerwijderFeature;
    }
}