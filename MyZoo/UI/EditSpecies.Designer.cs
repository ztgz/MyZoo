namespace MyZoo.UI
{
    partial class EditSpecies
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.editSpeciesBTN = new System.Windows.Forms.Button();
            this.foodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.enviormentComboBox = new System.Windows.Forms.ComboBox();
            this.speciesNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 339);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 22;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(108, 193);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(191, 22);
            this.countryTextBox.TabIndex = 21;
            // 
            // editSpeciesBTN
            // 
            this.editSpeciesBTN.Location = new System.Drawing.Point(108, 264);
            this.editSpeciesBTN.Name = "editSpeciesBTN";
            this.editSpeciesBTN.Size = new System.Drawing.Size(191, 61);
            this.editSpeciesBTN.TabIndex = 20;
            this.editSpeciesBTN.Text = "Edit Species";
            this.editSpeciesBTN.UseVisualStyleBackColor = true;
            this.editSpeciesBTN.Click += new System.EventHandler(this.editSpeciesBTN_Click);
            // 
            // foodTypeComboBox
            // 
            this.foodTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodTypeComboBox.FormattingEnabled = true;
            this.foodTypeComboBox.Location = new System.Drawing.Point(108, 145);
            this.foodTypeComboBox.Name = "foodTypeComboBox";
            this.foodTypeComboBox.Size = new System.Drawing.Size(191, 24);
            this.foodTypeComboBox.TabIndex = 19;
            // 
            // enviormentComboBox
            // 
            this.enviormentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enviormentComboBox.FormattingEnabled = true;
            this.enviormentComboBox.Location = new System.Drawing.Point(108, 96);
            this.enviormentComboBox.Name = "enviormentComboBox";
            this.enviormentComboBox.Size = new System.Drawing.Size(191, 24);
            this.enviormentComboBox.TabIndex = 18;
            // 
            // speciesNameTextBox
            // 
            this.speciesNameTextBox.Location = new System.Drawing.Point(108, 53);
            this.speciesNameTextBox.Name = "speciesNameTextBox";
            this.speciesNameTextBox.ReadOnly = true;
            this.speciesNameTextBox.Size = new System.Drawing.Size(191, 22);
            this.speciesNameTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Food type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enviorment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Edit Species";
            // 
            // returnBTN
            // 
            this.returnBTN.Location = new System.Drawing.Point(108, 380);
            this.returnBTN.Name = "returnBTN";
            this.returnBTN.Size = new System.Drawing.Size(190, 59);
            this.returnBTN.TabIndex = 23;
            this.returnBTN.Text = "Return to Animals";
            this.returnBTN.UseVisualStyleBackColor = true;
            this.returnBTN.Click += new System.EventHandler(this.returnBTN_Click);
            // 
            // EditSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 449);
            this.Controls.Add(this.returnBTN);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.editSpeciesBTN);
            this.Controls.Add(this.foodTypeComboBox);
            this.Controls.Add(this.enviormentComboBox);
            this.Controls.Add(this.speciesNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSpecies";
            this.Text = "EditSpecies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button editSpeciesBTN;
        private System.Windows.Forms.ComboBox foodTypeComboBox;
        private System.Windows.Forms.ComboBox enviormentComboBox;
        private System.Windows.Forms.TextBox speciesNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBTN;
    }
}