namespace MyZoo.UI
{
    partial class EditParents
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
            this.label9 = new System.Windows.Forms.Label();
            this.parent2ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.parent1ComboBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.editParentsBTN = new System.Windows.Forms.Button();
            this.succesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Parent 2";
            // 
            // parent2ComboBox
            // 
            this.parent2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parent2ComboBox.FormattingEnabled = true;
            this.parent2ComboBox.Location = new System.Drawing.Point(89, 103);
            this.parent2ComboBox.Name = "parent2ComboBox";
            this.parent2ComboBox.Size = new System.Drawing.Size(194, 24);
            this.parent2ComboBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Parent 1";
            // 
            // parent1ComboBox
            // 
            this.parent1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parent1ComboBox.FormattingEnabled = true;
            this.parent1ComboBox.Location = new System.Drawing.Point(89, 53);
            this.parent1ComboBox.Name = "parent1ComboBox";
            this.parent1ComboBox.Size = new System.Drawing.Size(194, 24);
            this.parent1ComboBox.TabIndex = 25;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(7, 13);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(67, 17);
            this.infoLabel.TabIndex = 29;
            this.infoLabel.Text = "Animal ID";
            // 
            // editParentsBTN
            // 
            this.editParentsBTN.Location = new System.Drawing.Point(109, 159);
            this.editParentsBTN.Name = "editParentsBTN";
            this.editParentsBTN.Size = new System.Drawing.Size(156, 38);
            this.editParentsBTN.TabIndex = 30;
            this.editParentsBTN.Text = "Select Parents";
            this.editParentsBTN.UseVisualStyleBackColor = true;
            this.editParentsBTN.Click += new System.EventHandler(this.editParentsBTN_Click);
            // 
            // succesLabel
            // 
            this.succesLabel.AutoSize = true;
            this.succesLabel.Location = new System.Drawing.Point(13, 211);
            this.succesLabel.Name = "succesLabel";
            this.succesLabel.Size = new System.Drawing.Size(0, 17);
            this.succesLabel.TabIndex = 31;
            // 
            // EditParents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 264);
            this.Controls.Add(this.succesLabel);
            this.Controls.Add(this.editParentsBTN);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.parent2ComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.parent1ComboBox);
            this.Name = "EditParents";
            this.Text = "EditParents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox parent2ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox parent1ComboBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button editParentsBTN;
        private System.Windows.Forms.Label succesLabel;
    }
}