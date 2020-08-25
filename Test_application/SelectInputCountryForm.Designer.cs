namespace Test_application
{
    partial class SelectInputCountryForm
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
            this.selectInputCountryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInputCountryDataGridView = new System.Windows.Forms.DataGridView();
            this.nameCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectInputCountryMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectInputCountryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectInputCountryMenuStrip
            // 
            this.selectInputCountryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.selectInputCountryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.selectInputCountryMenuStrip.Name = "selectInputCountryMenuStrip";
            this.selectInputCountryMenuStrip.Size = new System.Drawing.Size(660, 24);
            this.selectInputCountryMenuStrip.TabIndex = 0;
            this.selectInputCountryMenuStrip.Text = "selectInputCountryMenuStrip";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.backToolStripMenuItem.Text = "Назад";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // selectInputCountryDataGridView
            // 
            this.selectInputCountryDataGridView.AllowUserToAddRows = false;
            this.selectInputCountryDataGridView.AllowUserToDeleteRows = false;
            this.selectInputCountryDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.selectInputCountryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectInputCountryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCountryColumn,
            this.countryCodeColumn,
            this.capitalColumn,
            this.areaColumn,
            this.populationColumn,
            this.regionColumn});
            this.selectInputCountryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectInputCountryDataGridView.Location = new System.Drawing.Point(0, 24);
            this.selectInputCountryDataGridView.Name = "selectInputCountryDataGridView";
            this.selectInputCountryDataGridView.Size = new System.Drawing.Size(660, 332);
            this.selectInputCountryDataGridView.TabIndex = 1;
            // 
            // nameCountryColumn
            // 
            this.nameCountryColumn.HeaderText = "Name_country";
            this.nameCountryColumn.Name = "nameCountryColumn";
            // 
            // countryCodeColumn
            // 
            this.countryCodeColumn.HeaderText = "Country_code";
            this.countryCodeColumn.Name = "countryCodeColumn";
            // 
            // capitalColumn
            // 
            this.capitalColumn.HeaderText = "Capital";
            this.capitalColumn.Name = "capitalColumn";
            // 
            // areaColumn
            // 
            this.areaColumn.HeaderText = "Area";
            this.areaColumn.Name = "areaColumn";
            // 
            // populationColumn
            // 
            this.populationColumn.HeaderText = "Population";
            this.populationColumn.Name = "populationColumn";
            // 
            // regionColumn
            // 
            this.regionColumn.HeaderText = "Region";
            this.regionColumn.Name = "regionColumn";
            // 
            // SelectInputCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 356);
            this.Controls.Add(this.selectInputCountryDataGridView);
            this.Controls.Add(this.selectInputCountryMenuStrip);
            this.MainMenuStrip = this.selectInputCountryMenuStrip;
            this.MaximumSize = new System.Drawing.Size(1352, 790);
            this.MinimumSize = new System.Drawing.Size(676, 395);
            this.Name = "SelectInputCountryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectInputCountryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectInputCountryForm_FormClosing);
            this.Load += new System.EventHandler(this.selectInputCountryForm_Load);
            this.selectInputCountryMenuStrip.ResumeLayout(false);
            this.selectInputCountryMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectInputCountryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip selectInputCountryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView selectInputCountryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionColumn;
    }
}