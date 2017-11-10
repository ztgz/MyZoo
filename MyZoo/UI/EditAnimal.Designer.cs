namespace MyZoo.UI
{
    partial class EditAnimal
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
            this.animalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speciesComboBox = new System.Windows.Forms.ComboBox();
            this.weightAddTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editAnimalBTN = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.returnBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalLabel
            // 
            this.animalLabel.AutoSize = true;
            this.animalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalLabel.Location = new System.Drawing.Point(13, 13);
            this.animalLabel.Name = "animalLabel";
            this.animalLabel.Size = new System.Drawing.Size(92, 29);
            this.animalLabel.TabIndex = 0;
            this.animalLabel.Text = "Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Species";
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(89, 63);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(194, 24);
            this.speciesComboBox.TabIndex = 9;
            // 
            // weightAddTextBox
            // 
            this.weightAddTextBox.Location = new System.Drawing.Point(89, 110);
            this.weightAddTextBox.Name = "weightAddTextBox";
            this.weightAddTextBox.Size = new System.Drawing.Size(194, 22);
            this.weightAddTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Weight";
            // 
            // editAnimalBTN
            // 
            this.editAnimalBTN.Location = new System.Drawing.Point(206, 147);
            this.editAnimalBTN.Name = "editAnimalBTN";
            this.editAnimalBTN.Size = new System.Drawing.Size(105, 50);
            this.editAnimalBTN.TabIndex = 17;
            this.editAnimalBTN.Text = "Edit Animal";
            this.editAnimalBTN.UseVisualStyleBackColor = true;
            this.editAnimalBTN.Click += new System.EventHandler(this.editAnimalBTN_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(13, 229);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 18;
            // 
            // returnBTN
            // 
            this.returnBTN.Location = new System.Drawing.Point(206, 229);
            this.returnBTN.Name = "returnBTN";
            this.returnBTN.Size = new System.Drawing.Size(105, 52);
            this.returnBTN.TabIndex = 19;
            this.returnBTN.Text = "Return";
            this.returnBTN.UseVisualStyleBackColor = true;
            this.returnBTN.Click += new System.EventHandler(this.returnBTN_Click);
            // 
            // EditAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 293);
            this.Controls.Add(this.returnBTN);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.editAnimalBTN);
            this.Controls.Add(this.weightAddTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animalLabel);
            this.Name = "EditAnimal";
            this.Text = "EditAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label animalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox speciesComboBox;
        private System.Windows.Forms.TextBox weightAddTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editAnimalBTN;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button returnBTN;
    }
}