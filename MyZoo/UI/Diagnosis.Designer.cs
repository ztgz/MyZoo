namespace MyZoo.UI
{
    partial class Diagnosis
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingIdLabel = new System.Windows.Forms.Label();
            this.medicineDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.medecinesComboBox = new System.Windows.Forms.ComboBox();
            this.addMedecineBTN = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecineInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removeMedicine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecineInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnosis";
            // 
            // bookingIdLabel
            // 
            this.bookingIdLabel.AutoSize = true;
            this.bookingIdLabel.Location = new System.Drawing.Point(15, 13);
            this.bookingIdLabel.Name = "bookingIdLabel";
            this.bookingIdLabel.Size = new System.Drawing.Size(44, 17);
            this.bookingIdLabel.TabIndex = 1;
            this.bookingIdLabel.Text = "Edit b";
            // 
            // medicineDataGridView
            // 
            this.medicineDataGridView.AllowUserToAddRows = false;
            this.medicineDataGridView.AllowUserToDeleteRows = false;
            this.medicineDataGridView.AutoGenerateColumns = false;
            this.medicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.medicineDataGridView.DataSource = this.medecineInfoBindingSource;
            this.medicineDataGridView.Location = new System.Drawing.Point(483, 41);
            this.medicineDataGridView.Name = "medicineDataGridView";
            this.medicineDataGridView.ReadOnly = true;
            this.medicineDataGridView.RowTemplate.Height = 24;
            this.medicineDataGridView.Size = new System.Drawing.Size(232, 276);
            this.medicineDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prescribed medication";
            // 
            // medecinesComboBox
            // 
            this.medecinesComboBox.FormattingEnabled = true;
            this.medecinesComboBox.Location = new System.Drawing.Point(483, 336);
            this.medecinesComboBox.Name = "medecinesComboBox";
            this.medecinesComboBox.Size = new System.Drawing.Size(232, 24);
            this.medecinesComboBox.TabIndex = 4;
            // 
            // addMedecineBTN
            // 
            this.addMedecineBTN.Location = new System.Drawing.Point(594, 375);
            this.addMedecineBTN.Name = "addMedecineBTN";
            this.addMedecineBTN.Size = new System.Drawing.Size(157, 44);
            this.addMedecineBTN.TabIndex = 5;
            this.addMedecineBTN.Text = "Add Medicine";
            this.addMedecineBTN.UseVisualStyleBackColor = true;
            this.addMedecineBTN.Click += new System.EventHandler(this.addMedecineBTN_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(18, 248);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(393, 94);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medecineInfoBindingSource
            // 
            this.medecineInfoBindingSource.DataSource = typeof(MyZoo.Models.MedecineInfo);
            // 
            // removeMedicine
            // 
            this.removeMedicine.Location = new System.Drawing.Point(436, 375);
            this.removeMedicine.Name = "removeMedicine";
            this.removeMedicine.Size = new System.Drawing.Size(137, 44);
            this.removeMedicine.TabIndex = 7;
            this.removeMedicine.Text = "Remove Medicine";
            this.removeMedicine.UseVisualStyleBackColor = true;
            this.removeMedicine.Click += new System.EventHandler(this.removeMedicine_Click);
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 431);
            this.Controls.Add(this.removeMedicine);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addMedecineBTN);
            this.Controls.Add(this.medecinesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicineDataGridView);
            this.Controls.Add(this.bookingIdLabel);
            this.Controls.Add(this.label1);
            this.Name = "Diagnosis";
            this.Text = "Diagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecineInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookingIdLabel;
        private System.Windows.Forms.DataGridView medicineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medecineInfoBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox medecinesComboBox;
        private System.Windows.Forms.Button addMedecineBTN;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button removeMedicine;
    }
}