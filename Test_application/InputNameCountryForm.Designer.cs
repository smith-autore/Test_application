namespace Test_application
{
    partial class InputNameCountryForm
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
            this.inputNameCountryLabel = new System.Windows.Forms.Label();
            this.inputNameCountryTextBox = new System.Windows.Forms.TextBox();
            this.getInformationButton = new System.Windows.Forms.Button();
            this.closeInputNameCountryFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNameCountryLabel
            // 
            this.inputNameCountryLabel.AutoSize = true;
            this.inputNameCountryLabel.Location = new System.Drawing.Point(9, 19);
            this.inputNameCountryLabel.Name = "inputNameCountryLabel";
            this.inputNameCountryLabel.Size = new System.Drawing.Size(143, 13);
            this.inputNameCountryLabel.TabIndex = 0;
            this.inputNameCountryLabel.Text = "Введите название страны:";
            // 
            // inputNameCountryTextBox
            // 
            this.inputNameCountryTextBox.Location = new System.Drawing.Point(161, 16);
            this.inputNameCountryTextBox.Name = "inputNameCountryTextBox";
            this.inputNameCountryTextBox.Size = new System.Drawing.Size(131, 20);
            this.inputNameCountryTextBox.TabIndex = 1;
            this.inputNameCountryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNameCountryTextBox_KeyPress);
            // 
            // getInformationButton
            // 
            this.getInformationButton.Location = new System.Drawing.Point(161, 79);
            this.getInformationButton.Name = "getInformationButton";
            this.getInformationButton.Size = new System.Drawing.Size(131, 30);
            this.getInformationButton.TabIndex = 2;
            this.getInformationButton.Text = "Получить информацию";
            this.getInformationButton.UseVisualStyleBackColor = true;
            this.getInformationButton.Click += new System.EventHandler(this.GetInformationButton_Click);
            // 
            // closeInputNameCountryFormButton
            // 
            this.closeInputNameCountryFormButton.Location = new System.Drawing.Point(12, 79);
            this.closeInputNameCountryFormButton.Name = "closeInputNameCountryFormButton";
            this.closeInputNameCountryFormButton.Size = new System.Drawing.Size(75, 30);
            this.closeInputNameCountryFormButton.TabIndex = 3;
            this.closeInputNameCountryFormButton.Text = "Назад";
            this.closeInputNameCountryFormButton.UseVisualStyleBackColor = true;
            this.closeInputNameCountryFormButton.Click += new System.EventHandler(this.CloseInputNameCountryFormButton_Click);
            // 
            // InputNameCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.closeInputNameCountryFormButton);
            this.Controls.Add(this.getInformationButton);
            this.Controls.Add(this.inputNameCountryTextBox);
            this.Controls.Add(this.inputNameCountryLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 160);
            this.MinimumSize = new System.Drawing.Size(320, 160);
            this.Name = "InputNameCountryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputNameCountryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputNameCountryLabel;
        private System.Windows.Forms.Button closeInputNameCountryFormButton;
        private System.Windows.Forms.Button getInformationButton;
        private System.Windows.Forms.TextBox inputNameCountryTextBox;
    }
}