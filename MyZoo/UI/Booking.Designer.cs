namespace MyZoo.UI
{
    partial class Booking
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
            this.vetrinaryDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.freeTimesDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookingHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTimesBTN = new System.Windows.Forms.Button();
            this.bookingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinaryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedTimesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetrinaryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTimeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vetrinaryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeTimesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTimesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetrinaryInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vetrinaryDataGridView
            // 
            this.vetrinaryDataGridView.AllowUserToAddRows = false;
            this.vetrinaryDataGridView.AllowUserToDeleteRows = false;
            this.vetrinaryDataGridView.AutoGenerateColumns = false;
            this.vetrinaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vetrinaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.vetrinaryDataGridView.DataSource = this.vetrinaryInfoBindingSource;
            this.vetrinaryDataGridView.Location = new System.Drawing.Point(22, 49);
            this.vetrinaryDataGridView.Name = "vetrinaryDataGridView";
            this.vetrinaryDataGridView.ReadOnly = true;
            this.vetrinaryDataGridView.RowTemplate.Height = 24;
            this.vetrinaryDataGridView.Size = new System.Drawing.Size(227, 216);
            this.vetrinaryDataGridView.TabIndex = 0;
            this.vetrinaryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vetrinaryDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veterinarians";
            // 
            // freeTimesDataGridView
            // 
            this.freeTimesDataGridView.AllowUserToAddRows = false;
            this.freeTimesDataGridView.AllowUserToDeleteRows = false;
            this.freeTimesDataGridView.AutoGenerateColumns = false;
            this.freeTimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freeTimesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vetIdDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.animalIdDataGridViewTextBoxColumn1});
            this.freeTimesDataGridView.DataSource = this.bookingInfoBindingSource1;
            this.freeTimesDataGridView.Location = new System.Drawing.Point(294, 49);
            this.freeTimesDataGridView.Name = "freeTimesDataGridView";
            this.freeTimesDataGridView.ReadOnly = true;
            this.freeTimesDataGridView.RowTemplate.Height = 24;
            this.freeTimesDataGridView.Size = new System.Drawing.Size(603, 216);
            this.freeTimesDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Free Times";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(918, 49);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 11, 0, 0, 0, 0);
            // 
            // animalsDataGridView
            // 
            this.animalsDataGridView.AllowUserToAddRows = false;
            this.animalsDataGridView.AllowUserToDeleteRows = false;
            this.animalsDataGridView.AutoGenerateColumns = false;
            this.animalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.speciesDataGridViewTextBoxColumn});
            this.animalsDataGridView.DataSource = this.simpleAnimalBindingSource;
            this.animalsDataGridView.Location = new System.Drawing.Point(22, 311);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.ReadOnly = true;
            this.animalsDataGridView.RowTemplate.Height = 24;
            this.animalsDataGridView.Size = new System.Drawing.Size(227, 214);
            this.animalsDataGridView.TabIndex = 5;
            this.animalsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.animalsDataGridView_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Animals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Booking history for animal";
            // 
            // bookingHistoryDataGridView
            // 
            this.bookingHistoryDataGridView.AllowUserToAddRows = false;
            this.bookingHistoryDataGridView.AllowUserToDeleteRows = false;
            this.bookingHistoryDataGridView.AutoGenerateColumns = false;
            this.bookingHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIdDataGridViewTextBoxColumn,
            this.animalIdDataGridViewTextBoxColumn,
            this.veterinaryIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.bookingHistoryDataGridView.DataSource = this.bookedTimesBindingSource1;
            this.bookingHistoryDataGridView.Location = new System.Drawing.Point(294, 311);
            this.bookingHistoryDataGridView.Name = "bookingHistoryDataGridView";
            this.bookingHistoryDataGridView.ReadOnly = true;
            this.bookingHistoryDataGridView.RowTemplate.Height = 24;
            this.bookingHistoryDataGridView.Size = new System.Drawing.Size(603, 214);
            this.bookingHistoryDataGridView.TabIndex = 8;
            // 
            // searchTimesBTN
            // 
            this.searchTimesBTN.Location = new System.Drawing.Point(918, 93);
            this.searchTimesBTN.Name = "searchTimesBTN";
            this.searchTimesBTN.Size = new System.Drawing.Size(200, 47);
            this.searchTimesBTN.TabIndex = 9;
            this.searchTimesBTN.Text = "Search free times";
            this.searchTimesBTN.UseVisualStyleBackColor = true;
            this.searchTimesBTN.Click += new System.EventHandler(this.searchTimesBTN_Click);
            // 
            // bookingIdDataGridViewTextBoxColumn
            // 
            this.bookingIdDataGridViewTextBoxColumn.DataPropertyName = "BookingId";
            this.bookingIdDataGridViewTextBoxColumn.HeaderText = "BookingId";
            this.bookingIdDataGridViewTextBoxColumn.Name = "bookingIdDataGridViewTextBoxColumn";
            this.bookingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // veterinaryIdDataGridViewTextBoxColumn
            // 
            this.veterinaryIdDataGridViewTextBoxColumn.DataPropertyName = "VeterinaryId";
            this.veterinaryIdDataGridViewTextBoxColumn.HeaderText = "VeterinaryId";
            this.veterinaryIdDataGridViewTextBoxColumn.Name = "veterinaryIdDataGridViewTextBoxColumn";
            this.veterinaryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.veterinaryIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookedTimesBindingSource1
            // 
            this.bookedTimesBindingSource1.DataSource = typeof(MyZoo.Models.BookedTimes);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 35;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simpleAnimalBindingSource
            // 
            this.simpleAnimalBindingSource.DataSource = typeof(MyZoo.Models.SimpleAnimal);
            // 
            // vetIdDataGridViewTextBoxColumn
            // 
            this.vetIdDataGridViewTextBoxColumn.DataPropertyName = "VetId";
            this.vetIdDataGridViewTextBoxColumn.HeaderText = "VetId";
            this.vetIdDataGridViewTextBoxColumn.Name = "vetIdDataGridViewTextBoxColumn";
            this.vetIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalIdDataGridViewTextBoxColumn1
            // 
            this.animalIdDataGridViewTextBoxColumn1.DataPropertyName = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn1.HeaderText = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn1.Name = "animalIdDataGridViewTextBoxColumn1";
            this.animalIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookingInfoBindingSource1
            // 
            this.bookingInfoBindingSource1.DataSource = typeof(MyZoo.Models.BookingInfo);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 35;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vetrinaryInfoBindingSource
            // 
            this.vetrinaryInfoBindingSource.DataSource = typeof(MyZoo.Models.VetrinaryInfo);
            // 
            // bookingInfoBindingSource
            // 
            this.bookingInfoBindingSource.DataSource = typeof(MyZoo.Models.BookingInfo);
            // 
            // bookedTimesBindingSource
            // 
            this.bookedTimesBindingSource.DataSource = typeof(MyZoo.Models.BookedTimes);
            // 
            // bookTimeBTN
            // 
            this.bookTimeBTN.Location = new System.Drawing.Point(918, 165);
            this.bookTimeBTN.Name = "bookTimeBTN";
            this.bookTimeBTN.Size = new System.Drawing.Size(200, 54);
            this.bookTimeBTN.TabIndex = 10;
            this.bookTimeBTN.Text = "Book time";
            this.bookTimeBTN.UseVisualStyleBackColor = true;
            this.bookTimeBTN.Click += new System.EventHandler(this.bookTimeBTN_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 560);
            this.Controls.Add(this.bookTimeBTN);
            this.Controls.Add(this.searchTimesBTN);
            this.Controls.Add(this.bookingHistoryDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.animalsDataGridView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.freeTimesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vetrinaryDataGridView);
            this.Name = "Booking";
            this.Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)(this.vetrinaryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeTimesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTimesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetrinaryInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTimesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vetrinaryInfoBindingSource;
        private System.Windows.Forms.DataGridView vetrinaryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView freeTimesDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource bookingInfoBindingSource;
        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.BindingSource simpleAnimalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView bookingHistoryDataGridView;
        private System.Windows.Forms.BindingSource bookedTimesBindingSource;
        private System.Windows.Forms.BindingSource bookedTimesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinaryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button searchTimesBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bookingInfoBindingSource1;
        private System.Windows.Forms.Button bookTimeBTN;
    }
}