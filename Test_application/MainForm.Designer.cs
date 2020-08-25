namespace Test_application
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMainWindow = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItemMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFunctionalityToolStripMenuItemMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDevelopersToolStripMenuItemMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputNameCountryButton = new System.Windows.Forms.Button();
            this.outputOfAllCountriesFromTheDatabaseButton = new System.Windows.Forms.Button();
            this.menuStripMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainWindow
            // 
            this.menuStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItemMainWindow,
            this.closeToolStripMenuItem});
            this.menuStripMainWindow.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainWindow.Name = "menuStripMainWindow";
            this.menuStripMainWindow.Size = new System.Drawing.Size(259, 24);
            this.menuStripMainWindow.TabIndex = 0;
            this.menuStripMainWindow.Text = "menuStrip1";
            // 
            // helpToolStripMenuItemMainWindow
            // 
            this.helpToolStripMenuItemMainWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFunctionalityToolStripMenuItemMainWindow,
            this.aboutDevelopersToolStripMenuItemMainWindow});
            this.helpToolStripMenuItemMainWindow.Name = "helpToolStripMenuItemMainWindow";
            this.helpToolStripMenuItemMainWindow.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItemMainWindow.Text = "Справка";
            // 
            // aboutFunctionalityToolStripMenuItemMainWindow
            // 
            this.aboutFunctionalityToolStripMenuItemMainWindow.Name = "aboutFunctionalityToolStripMenuItemMainWindow";
            this.aboutFunctionalityToolStripMenuItemMainWindow.Size = new System.Drawing.Size(162, 22);
            this.aboutFunctionalityToolStripMenuItemMainWindow.Text = "О функционале";
            this.aboutFunctionalityToolStripMenuItemMainWindow.Click += new System.EventHandler(this.aboutFunctionalityToolStripMenuItemMainWindow_Click);
            // 
            // aboutDevelopersToolStripMenuItemMainWindow
            // 
            this.aboutDevelopersToolStripMenuItemMainWindow.Name = "aboutDevelopersToolStripMenuItemMainWindow";
            this.aboutDevelopersToolStripMenuItemMainWindow.Size = new System.Drawing.Size(162, 22);
            this.aboutDevelopersToolStripMenuItemMainWindow.Text = "О разработчике";
            this.aboutDevelopersToolStripMenuItemMainWindow.Click += new System.EventHandler(this.aboutDevelopersToolStripMenuItemMainWindow_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.closeToolStripMenuItem.Text = "Выход";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // inputNameCountryButton
            // 
            this.inputNameCountryButton.Location = new System.Drawing.Point(12, 105);
            this.inputNameCountryButton.Name = "inputNameCountryButton";
            this.inputNameCountryButton.Size = new System.Drawing.Size(100, 50);
            this.inputNameCountryButton.TabIndex = 1;
            this.inputNameCountryButton.Text = "Ввод названия страны";
            this.inputNameCountryButton.UseVisualStyleBackColor = true;
            this.inputNameCountryButton.Click += new System.EventHandler(this.inputNameCountryButton_Click);
            // 
            // outputOfAllCountriesFromTheDatabaseButton
            // 
            this.outputOfAllCountriesFromTheDatabaseButton.Location = new System.Drawing.Point(147, 105);
            this.outputOfAllCountriesFromTheDatabaseButton.Name = "outputOfAllCountriesFromTheDatabaseButton";
            this.outputOfAllCountriesFromTheDatabaseButton.Size = new System.Drawing.Size(100, 50);
            this.outputOfAllCountriesFromTheDatabaseButton.TabIndex = 2;
            this.outputOfAllCountriesFromTheDatabaseButton.Text = "Вывод всех стран с БД";
            this.outputOfAllCountriesFromTheDatabaseButton.UseVisualStyleBackColor = true;
            this.outputOfAllCountriesFromTheDatabaseButton.Click += new System.EventHandler(this.outputOfAllCountriesFromTheDatabaseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 236);
            this.Controls.Add(this.outputOfAllCountriesFromTheDatabaseButton);
            this.Controls.Add(this.inputNameCountryButton);
            this.Controls.Add(this.menuStripMainWindow);
            this.MainMenuStrip = this.menuStripMainWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 275);
            this.MinimumSize = new System.Drawing.Size(275, 275);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuStripMainWindow.ResumeLayout(false);
            this.menuStripMainWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainWindow;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItemMainWindow;
        private System.Windows.Forms.ToolStripMenuItem aboutFunctionalityToolStripMenuItemMainWindow;
        private System.Windows.Forms.ToolStripMenuItem aboutDevelopersToolStripMenuItemMainWindow;
        private System.Windows.Forms.Button inputNameCountryButton;
        private System.Windows.Forms.Button outputOfAllCountriesFromTheDatabaseButton;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

