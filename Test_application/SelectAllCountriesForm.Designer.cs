namespace Test_application
{
    partial class SelectAllCountriesForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCountriesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllCountriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.toolsToolStripMenuItem.Text = "Инструменты";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Обновить";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // selectAllCountriesDataGridView
            // 
            this.selectAllCountriesDataGridView.AllowUserToAddRows = false;
            this.selectAllCountriesDataGridView.AllowUserToDeleteRows = false;
            this.selectAllCountriesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.selectAllCountriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectAllCountriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCountryColumn,
            this.countryCodeColumn,
            this.capitalColumn,
            this.areaColumn,
            this.populationColumn,
            this.regionColumn});
            this.selectAllCountriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllCountriesDataGridView.Location = new System.Drawing.Point(0, 24);
            this.selectAllCountriesDataGridView.Name = "selectAllCountriesDataGridView";
            this.selectAllCountriesDataGridView.Size = new System.Drawing.Size(660, 332);
            this.selectAllCountriesDataGridView.TabIndex = 2;
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
            // SelectAllCountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 356);
            this.Controls.Add(this.selectAllCountriesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1352, 790);
            this.MinimumSize = new System.Drawing.Size(676, 395);
            this.Name = "SelectAllCountriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectAllCountriesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.selectAllCountriesForm_FormClosing);
            this.Load += new System.EventHandler(this.selectAllCountriesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllCountriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView selectAllCountriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionColumn;
    }
}