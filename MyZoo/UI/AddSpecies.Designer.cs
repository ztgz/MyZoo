namespace MyZoo.UI
{
    partial class AddSpecies
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.speciesNameTextBox = new System.Windows.Forms.TextBox();
            this.enviormentComboBox = new System.Windows.Forms.ComboBox();
            this.foodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Species";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enviorment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Food type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country";
            // 
            // speciesNameTextBox
            // 
            this.speciesNameTextBox.Location = new System.Drawing.Point(112, 53);
            this.speciesNameTextBox.Name = "speciesNameTextBox";
            this.speciesNameTextBox.Size = new System.Drawing.Size(191, 22);
            this.speciesNameTextBox.TabIndex = 5;
            // 
            // enviormentComboBox
            // 
            this.enviormentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enviormentComboBox.FormattingEnabled = true;
            this.enviormentComboBox.Location = new System.Drawing.Point(112, 96);
            this.enviormentComboBox.Name = "enviormentComboBox";
            this.enviormentComboBox.Size = new System.Drawing.Size(191, 24);
            this.enviormentComboBox.TabIndex = 6;
            // 
            // foodTypeComboBox
            // 
            this.foodTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodTypeComboBox.FormattingEnabled = true;
            this.foodTypeComboBox.Location = new System.Drawing.Point(112, 145);
            this.foodTypeComboBox.Name = "foodTypeComboBox";
            this.foodTypeComboBox.Size = new System.Drawing.Size(191, 24);
            this.foodTypeComboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Species";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(112, 193);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(191, 22);
            this.countryTextBox.TabIndex = 10;
            // 
            // AddSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 458);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.foodTypeComboBox);
            this.Controls.Add(this.enviormentComboBox);
            this.Controls.Add(this.speciesNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSpecies";
            this.Text = "AddSpecies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox speciesNameTextBox;
        private System.Windows.Forms.ComboBox enviormentComboBox;
        private System.Windows.Forms.ComboBox foodTypeComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox countryTextBox;
    }
}