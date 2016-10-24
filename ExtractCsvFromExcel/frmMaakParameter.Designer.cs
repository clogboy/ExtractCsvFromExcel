namespace ExtractCsvFromExcel
{
    partial class frmMaakParameter
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
            this.tboParNaam = new System.Windows.Forms.TextBox();
            this.cboParType = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chbConfig = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tboParNaam
            // 
            this.tboParNaam.Location = new System.Drawing.Point(12, 42);
            this.tboParNaam.Name = "tboParNaam";
            this.tboParNaam.Size = new System.Drawing.Size(127, 20);
            this.tboParNaam.TabIndex = 0;
            this.tboParNaam.TextChanged += new System.EventHandler(this.tboParNaam_TextChanged);
            // 
            // cboParType
            // 
            this.cboParType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParType.FormattingEnabled = true;
            this.cboParType.Items.AddRange(new object[] {
            "Length",
            "Angle",
            "Integer"});
            this.cboParType.Location = new System.Drawing.Point(145, 42);
            this.cboParType.Name = "cboParType";
            this.cboParType.Size = new System.Drawing.Size(96, 21);
            this.cboParType.TabIndex = 1;
            this.cboParType.SelectedIndexChanged += new System.EventHandler(this.cboParType_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(13, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(236, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Geef hier de naam en type van de parameter in.";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(190, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(51, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // chbConfig
            // 
            this.chbConfig.AutoSize = true;
            this.chbConfig.Location = new System.Drawing.Point(12, 84);
            this.chbConfig.Name = "chbConfig";
            this.chbConfig.Size = new System.Drawing.Size(120, 17);
            this.chbConfig.TabIndex = 5;
            this.chbConfig.Text = "Bepaalt configuratie";
            this.chbConfig.UseVisualStyleBackColor = true;
            this.chbConfig.CheckedChanged += new System.EventHandler(this.chbConfig_CheckedChanged);
            // 
            // frmMaakParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 112);
            this.Controls.Add(this.chbConfig);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cboParType);
            this.Controls.Add(this.tboParNaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaakParameter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parameter";
            this.Load += new System.EventHandler(this.frmMaakParameter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboParNaam;
        private System.Windows.Forms.ComboBox cboParType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chbConfig;
    }
}