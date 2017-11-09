namespace MyZoo.UI
{
    partial class Zoo
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
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.foodTypeSearchBox = new System.Windows.Forms.TextBox();
            this.speciesSearchBox = new System.Windows.Forms.TextBox();
            this.enviormentSearchBox = new System.Windows.Forms.TextBox();
            this.foodTypeLabel = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.enviormentLabel = new System.Windows.Forms.Label();
            this.searchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speciesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enviormentAddTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.foodTypeAddTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weightAddTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.countryAddBox = new System.Windows.Forms.TextBox();
            this.addSpeciesBTN = new System.Windows.Forms.Button();
            this.animalAddBTN = new System.Windows.Forms.Button();
            this.parent1ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.parent2ComboBox = new System.Windows.Forms.ComboBox();
            this.editSpeciesBTN = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enviormentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent1IdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent2IdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.AutoGenerateColumns = false;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.enviormentDataGridViewTextBoxColumn,
            this.foodTypeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.parent1IdDataGridViewTextBoxColumn,
            this.parent2IdDataGridViewTextBoxColumn});
            this.searchDataGridView.DataSource = this.animalInfoBindingSource;
            this.searchDataGridView.Location = new System.Drawing.Point(22, 278);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.Size = new System.Drawing.Size(1103, 273);
            this.searchDataGridView.TabIndex = 0;
            // 
            // foodTypeSearchBox
            // 
            this.foodTypeSearchBox.Location = new System.Drawing.Point(62, 240);
            this.foodTypeSearchBox.Name = "foodTypeSearchBox";
            this.foodTypeSearchBox.Size = new System.Drawing.Size(207, 22);
            this.foodTypeSearchBox.TabIndex = 1;
            // 
            // speciesSearchBox
            // 
            this.speciesSearchBox.Location = new System.Drawing.Point(373, 240);
            this.speciesSearchBox.Name = "speciesSearchBox";
            this.speciesSearchBox.Size = new System.Drawing.Size(207, 22);
            this.speciesSearchBox.TabIndex = 1;
            // 
            // enviormentSearchBox
            // 
            this.enviormentSearchBox.Location = new System.Drawing.Point(676, 240);
            this.enviormentSearchBox.Name = "enviormentSearchBox";
            this.enviormentSearchBox.Size = new System.Drawing.Size(207, 22);
            this.enviormentSearchBox.TabIndex = 1;
            // 
            // foodTypeLabel
            // 
            this.foodTypeLabel.AutoSize = true;
            this.foodTypeLabel.Location = new System.Drawing.Point(62, 217);
            this.foodTypeLabel.Name = "foodTypeLabel";
            this.foodTypeLabel.Size = new System.Drawing.Size(76, 17);
            this.foodTypeLabel.TabIndex = 2;
            this.foodTypeLabel.Text = "Food Type";
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(373, 217);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(58, 17);
            this.speciesLabel.TabIndex = 3;
            this.speciesLabel.Text = "Species";
            // 
            // enviormentLabel
            // 
            this.enviormentLabel.AutoSize = true;
            this.enviormentLabel.Location = new System.Drawing.Point(676, 216);
            this.enviormentLabel.Name = "enviormentLabel";
            this.enviormentLabel.Size = new System.Drawing.Size(79, 17);
            this.enviormentLabel.TabIndex = 4;
            this.enviormentLabel.Text = "Enviorment";
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(997, 240);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(96, 23);
            this.searchBTN.TabIndex = 5;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Species";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add animal";
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(130, 41);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(194, 24);
            this.speciesComboBox.TabIndex = 8;
            this.speciesComboBox.SelectedIndexChanged += new System.EventHandler(this.SpeciesComboBoxChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enviorment";
            // 
            // enviormentAddTextBox
            // 
            this.enviormentAddTextBox.Location = new System.Drawing.Point(130, 87);
            this.enviormentAddTextBox.Name = "enviormentAddTextBox";
            this.enviormentAddTextBox.ReadOnly = true;
            this.enviormentAddTextBox.Size = new System.Drawing.Size(194, 22);
            this.enviormentAddTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Food type";
            // 
            // foodTypeAddTextBox
            // 
            this.foodTypeAddTextBox.Location = new System.Drawing.Point(130, 134);
            this.foodTypeAddTextBox.Name = "foodTypeAddTextBox";
            this.foodTypeAddTextBox.ReadOnly = true;
            this.foodTypeAddTextBox.Size = new System.Drawing.Size(194, 22);
            this.foodTypeAddTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Weight";
            // 
            // weightAddTextBox
            // 
            this.weightAddTextBox.Location = new System.Drawing.Point(423, 91);
            this.weightAddTextBox.Name = "weightAddTextBox";
            this.weightAddTextBox.Size = new System.Drawing.Size(198, 22);
            this.weightAddTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search for animal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Country";
            // 
            // countryAddBox
            // 
            this.countryAddBox.Location = new System.Drawing.Point(427, 137);
            this.countryAddBox.Name = "countryAddBox";
            this.countryAddBox.ReadOnly = true;
            this.countryAddBox.Size = new System.Drawing.Size(194, 22);
            this.countryAddBox.TabIndex = 18;
            // 
            // addSpeciesBTN
            // 
            this.addSpeciesBTN.Location = new System.Drawing.Point(557, 31);
            this.addSpeciesBTN.Name = "addSpeciesBTN";
            this.addSpeciesBTN.Size = new System.Drawing.Size(120, 43);
            this.addSpeciesBTN.TabIndex = 19;
            this.addSpeciesBTN.Text = "Add New Species";
            this.addSpeciesBTN.UseVisualStyleBackColor = true;
            this.addSpeciesBTN.Click += new System.EventHandler(this.addSpeciesBTN_Click);
            // 
            // animalAddBTN
            // 
            this.animalAddBTN.Location = new System.Drawing.Point(985, 115);
            this.animalAddBTN.Name = "animalAddBTN";
            this.animalAddBTN.Size = new System.Drawing.Size(108, 52);
            this.animalAddBTN.TabIndex = 20;
            this.animalAddBTN.Text = "Add Animal";
            this.animalAddBTN.UseVisualStyleBackColor = true;
            this.animalAddBTN.Click += new System.EventHandler(this.animalAddBTN_Click);
            // 
            // parent1ComboBox
            // 
            this.parent1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parent1ComboBox.FormattingEnabled = true;
            this.parent1ComboBox.Location = new System.Drawing.Point(732, 87);
            this.parent1ComboBox.Name = "parent1ComboBox";
            this.parent1ComboBox.Size = new System.Drawing.Size(194, 24);
            this.parent1ComboBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Parent 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Parent 2";
            // 
            // parent2ComboBox
            // 
            this.parent2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parent2ComboBox.FormattingEnabled = true;
            this.parent2ComboBox.Location = new System.Drawing.Point(732, 137);
            this.parent2ComboBox.Name = "parent2ComboBox";
            this.parent2ComboBox.Size = new System.Drawing.Size(194, 24);
            this.parent2ComboBox.TabIndex = 23;
            // 
            // editSpeciesBTN
            // 
            this.editSpeciesBTN.Location = new System.Drawing.Point(411, 31);
            this.editSpeciesBTN.Name = "editSpeciesBTN";
            this.editSpeciesBTN.Size = new System.Drawing.Size(119, 43);
            this.editSpeciesBTN.TabIndex = 25;
            this.editSpeciesBTN.Text = "Edit Species";
            this.editSpeciesBTN.UseVisualStyleBackColor = true;
            this.editSpeciesBTN.Click += new System.EventHandler(this.editSpeciesBTN_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enviormentDataGridViewTextBoxColumn
            // 
            this.enviormentDataGridViewTextBoxColumn.DataPropertyName = "Enviorment";
            this.enviormentDataGridViewTextBoxColumn.HeaderText = "Enviorment";
            this.enviormentDataGridViewTextBoxColumn.Name = "enviormentDataGridViewTextBoxColumn";
            this.enviormentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodTypeDataGridViewTextBoxColumn
            // 
            this.foodTypeDataGridViewTextBoxColumn.DataPropertyName = "FoodType";
            this.foodTypeDataGridViewTextBoxColumn.HeaderText = "FoodType";
            this.foodTypeDataGridViewTextBoxColumn.Name = "foodTypeDataGridViewTextBoxColumn";
            this.foodTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parent1IdDataGridViewTextBoxColumn
            // 
            this.parent1IdDataGridViewTextBoxColumn.DataPropertyName = "Parent1Id";
            this.parent1IdDataGridViewTextBoxColumn.HeaderText = "Parent1Id";
            this.parent1IdDataGridViewTextBoxColumn.Name = "parent1IdDataGridViewTextBoxColumn";
            this.parent1IdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parent2IdDataGridViewTextBoxColumn
            // 
            this.parent2IdDataGridViewTextBoxColumn.DataPropertyName = "Parent2Id";
            this.parent2IdDataGridViewTextBoxColumn.HeaderText = "Parent2Id";
            this.parent2IdDataGridViewTextBoxColumn.Name = "parent2IdDataGridViewTextBoxColumn";
            this.parent2IdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalInfoBindingSource
            // 
            this.animalInfoBindingSource.DataSource = typeof(MyZoo.Models.AnimalInfo);
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(1131, 306);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(145, 45);
            this.editBTN.TabIndex = 26;
            this.editBTN.Text = "Edit row";
            this.editBTN.UseVisualStyleBackColor = true;
            // 
            // Zoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 563);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.editSpeciesBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.parent2ComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.parent1ComboBox);
            this.Controls.Add(this.animalAddBTN);
            this.Controls.Add(this.addSpeciesBTN);
            this.Controls.Add(this.countryAddBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.weightAddTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.foodTypeAddTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enviormentAddTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.enviormentLabel);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.foodTypeLabel);
            this.Controls.Add(this.enviormentSearchBox);
            this.Controls.Add(this.speciesSearchBox);
            this.Controls.Add(this.foodTypeSearchBox);
            this.Controls.Add(this.searchDataGridView);
            this.Name = "Zoo";
            this.Text = "Zoo";
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.TextBox foodTypeSearchBox;
        private System.Windows.Forms.TextBox speciesSearchBox;
        private System.Windows.Forms.TextBox enviormentSearchBox;
        private System.Windows.Forms.Label foodTypeLabel;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label enviormentLabel;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enviormentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent1IdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent2IdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource animalInfoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox speciesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enviormentAddTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox foodTypeAddTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weightAddTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox countryAddBox;
        private System.Windows.Forms.Button addSpeciesBTN;
        private System.Windows.Forms.Button animalAddBTN;
        private System.Windows.Forms.ComboBox parent1ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox parent2ComboBox;
        private System.Windows.Forms.Button editSpeciesBTN;
        private System.Windows.Forms.Button editBTN;
    }
}