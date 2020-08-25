namespace Test_application
{
    partial class InsertCountryForm
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
            this.insertCountryTabControl = new System.Windows.Forms.TabControl();
            this.insertCountryTabPage = new System.Windows.Forms.TabPage();
            this.backInsertCountryFormButton = new System.Windows.Forms.Button();
            this.insertCountryButton = new System.Windows.Forms.Button();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.countryCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameCountryTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.capitalLabel = new System.Windows.Forms.Label();
            this.countryCodeLabel = new System.Windows.Forms.Label();
            this.nameCountryLabel = new System.Windows.Forms.Label();
            this.insertCountryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCountryTabControl.SuspendLayout();
            this.insertCountryTabPage.SuspendLayout();
            this.insertCountryMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertCountryTabControl
            // 
            this.insertCountryTabControl.Controls.Add(this.insertCountryTabPage);
            this.insertCountryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertCountryTabControl.Location = new System.Drawing.Point(0, 24);
            this.insertCountryTabControl.Name = "insertCountryTabControl";
            this.insertCountryTabControl.SelectedIndex = 0;
            this.insertCountryTabControl.Size = new System.Drawing.Size(284, 311);
            this.insertCountryTabControl.TabIndex = 1;
            // 
            // insertCountryTabPage
            // 
            this.insertCountryTabPage.Controls.Add(this.backInsertCountryFormButton);
            this.insertCountryTabPage.Controls.Add(this.insertCountryButton);
            this.insertCountryTabPage.Controls.Add(this.regionTextBox);
            this.insertCountryTabPage.Controls.Add(this.populationTextBox);
            this.insertCountryTabPage.Controls.Add(this.areaTextBox);
            this.insertCountryTabPage.Controls.Add(this.capitalTextBox);
            this.insertCountryTabPage.Controls.Add(this.countryCodeTextBox);
            this.insertCountryTabPage.Controls.Add(this.nameCountryTextBox);
            this.insertCountryTabPage.Controls.Add(this.regionLabel);
            this.insertCountryTabPage.Controls.Add(this.populationLabel);
            this.insertCountryTabPage.Controls.Add(this.areaLabel);
            this.insertCountryTabPage.Controls.Add(this.capitalLabel);
            this.insertCountryTabPage.Controls.Add(this.countryCodeLabel);
            this.insertCountryTabPage.Controls.Add(this.nameCountryLabel);
            this.insertCountryTabPage.Location = new System.Drawing.Point(4, 22);
            this.insertCountryTabPage.Name = "insertCountryTabPage";
            this.insertCountryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertCountryTabPage.Size = new System.Drawing.Size(276, 285);
            this.insertCountryTabPage.TabIndex = 0;
            this.insertCountryTabPage.Text = "INSERT";
            this.insertCountryTabPage.UseVisualStyleBackColor = true;
            // 
            // backInsertCountryFormButton
            // 
            this.backInsertCountryFormButton.Location = new System.Drawing.Point(8, 254);
            this.backInsertCountryFormButton.Name = "backInsertCountryFormButton";
            this.backInsertCountryFormButton.Size = new System.Drawing.Size(75, 23);
            this.backInsertCountryFormButton.TabIndex = 14;
            this.backInsertCountryFormButton.Text = "Назад";
            this.backInsertCountryFormButton.UseVisualStyleBackColor = true;
            this.backInsertCountryFormButton.Click += new System.EventHandler(this.backInsertCountryFormButton_Click);
            // 
            // insertCountryButton
            // 
            this.insertCountryButton.Location = new System.Drawing.Point(193, 254);
            this.insertCountryButton.Name = "insertCountryButton";
            this.insertCountryButton.Size = new System.Drawing.Size(75, 23);
            this.insertCountryButton.TabIndex = 13;
            this.insertCountryButton.Text = "Добавить";
            this.insertCountryButton.UseVisualStyleBackColor = true;
            this.insertCountryButton.Click += new System.EventHandler(this.insertCountryButton_Click);
            // 
            // regionTextBox
            // 
            this.regionTextBox.Location = new System.Drawing.Point(114, 184);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(150, 20);
            this.regionTextBox.TabIndex = 12;
            this.regionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.regionTextBox_KeyPress);
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(114, 149);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(150, 20);
            this.populationTextBox.TabIndex = 11;
            this.populationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.populationTextBox_KeyPress);
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(114, 114);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(150, 20);
            this.areaTextBox.TabIndex = 10;
            this.areaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaTextBox_KeyPress);
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Location = new System.Drawing.Point(114, 79);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(150, 20);
            this.capitalTextBox.TabIndex = 9;
            this.capitalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capitalTextBox_KeyPress);
            // 
            // countryCodeTextBox
            // 
            this.countryCodeTextBox.Location = new System.Drawing.Point(114, 44);
            this.countryCodeTextBox.Name = "countryCodeTextBox";
            this.countryCodeTextBox.Size = new System.Drawing.Size(150, 20);
            this.countryCodeTextBox.TabIndex = 8;
            this.countryCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countryCodeTextBox_KeyPress);
            // 
            // nameCountryTextBox
            // 
            this.nameCountryTextBox.Location = new System.Drawing.Point(114, 9);
            this.nameCountryTextBox.Name = "nameCountryTextBox";
            this.nameCountryTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameCountryTextBox.TabIndex = 7;
            this.nameCountryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameCountryTextBox_KeyPress);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(8, 187);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(46, 13);
            this.regionLabel.TabIndex = 6;
            this.regionLabel.Text = "Регион:";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(8, 152);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(66, 13);
            this.populationLabel.TabIndex = 5;
            this.populationLabel.Text = "Население:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(8, 117);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(57, 13);
            this.areaLabel.TabIndex = 4;
            this.areaLabel.Text = "Площадь:";
            // 
            // capitalLabel
            // 
            this.capitalLabel.AutoSize = true;
            this.capitalLabel.Location = new System.Drawing.Point(8, 82);
            this.capitalLabel.Name = "capitalLabel";
            this.capitalLabel.Size = new System.Drawing.Size(52, 13);
            this.capitalLabel.TabIndex = 3;
            this.capitalLabel.Text = "Столица:";
            // 
            // countryCodeLabel
            // 
            this.countryCodeLabel.AutoSize = true;
            this.countryCodeLabel.Location = new System.Drawing.Point(8, 47);
            this.countryCodeLabel.Name = "countryCodeLabel";
            this.countryCodeLabel.Size = new System.Drawing.Size(69, 13);
            this.countryCodeLabel.TabIndex = 2;
            this.countryCodeLabel.Text = "Код страны:";
            // 
            // nameCountryLabel
            // 
            this.nameCountryLabel.AutoSize = true;
            this.nameCountryLabel.Location = new System.Drawing.Point(8, 12);
            this.nameCountryLabel.Name = "nameCountryLabel";
            this.nameCountryLabel.Size = new System.Drawing.Size(100, 13);
            this.nameCountryLabel.TabIndex = 1;
            this.nameCountryLabel.Text = "Название страны:";
            // 
            // insertCountryMenuStrip
            // 
            this.insertCountryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментыToolStripMenuItem});
            this.insertCountryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.insertCountryMenuStrip.Name = "insertCountryMenuStrip";
            this.insertCountryMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.insertCountryMenuStrip.TabIndex = 2;
            this.insertCountryMenuStrip.Text = "menuStrip1";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearAllToolStripMenuItem.Text = "Очистить все";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // InsertCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.insertCountryTabControl);
            this.Controls.Add(this.insertCountryMenuStrip);
            this.MainMenuStrip = this.insertCountryMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 374);
            this.MinimumSize = new System.Drawing.Size(300, 374);
            this.Name = "InsertCountryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertCountryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertCountryForm_FormClosing);
            this.Load += new System.EventHandler(this.InsertCountryForm_Load);
            this.insertCountryTabControl.ResumeLayout(false);
            this.insertCountryTabPage.ResumeLayout(false);
            this.insertCountryTabPage.PerformLayout();
            this.insertCountryMenuStrip.ResumeLayout(false);
            this.insertCountryMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl insertCountryTabControl;
        private System.Windows.Forms.TabPage insertCountryTabPage;
        private System.Windows.Forms.Button backInsertCountryFormButton;
        private System.Windows.Forms.Button insertCountryButton;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.TextBox countryCodeTextBox;
        public System.Windows.Forms.TextBox nameCountryTextBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label capitalLabel;
        private System.Windows.Forms.Label countryCodeLabel;
        private System.Windows.Forms.Label nameCountryLabel;
        private System.Windows.Forms.MenuStrip insertCountryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    }
}