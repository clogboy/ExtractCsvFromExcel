namespace ExtractCsvFromExcel
{
    partial class frmSelectWorksheet
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
            this.cmbWorksheet = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbWorksheet
            // 
            this.cmbWorksheet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorksheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorksheet.FormattingEnabled = true;
            this.cmbWorksheet.Location = new System.Drawing.Point(12, 12);
            this.cmbWorksheet.Name = "cmbWorksheet";
            this.cmbWorksheet.Size = new System.Drawing.Size(232, 21);
            this.cmbWorksheet.TabIndex = 0;
            this.cmbWorksheet.SelectedIndexChanged += new System.EventHandler(this.cmbWorksheet_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(205, 50);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(39, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmSelectWorksheet
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 85);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbWorksheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectWorksheet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecteer werkblad...";
            this.Load += new System.EventHandler(this.formSelectWorksheet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWorksheet;
        private System.Windows.Forms.Button btnOK;
    }
}