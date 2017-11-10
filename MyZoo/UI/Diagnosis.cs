using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyZoo.DAL;
using MyZoo.Extensions;
using MyZoo.Models;

namespace MyZoo.UI
{
    public partial class Diagnosis : Form
    {
        private DataAccess _dataAccess = new DataAccess();

        private int diagnosisId;

        private Booking bookingForm;

        public Diagnosis(int bookingId, int animalId, Booking bookingForm)
        {
            InitializeComponent();

            this.bookingForm = bookingForm;

            //Get the diagnosisID from the bookingId
            //If diagonsis dosn't exsist, then it's created
            diagnosisId = _dataAccess.CreateAndGetDiagnosisId(bookingId);

            //Info text
            bookingIdLabel.Text = $"Edit information for booking id: {bookingId}. " +
                                  $"\nJournal regarding animal id: {animalId}"
                                  + $"\nDiagnosis id: {diagnosisId}";
            
            //Description text
            descriptionTextBox.Text = _dataAccess.GetDiagnosisJournal(diagnosisId);

            FillMedicineComboBox();

            FillMedicineList();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            bookingForm.Show();

            base.OnFormClosing(e);
        }

        private void FillMedicineList()
        {
            medicineDataGridView.DataSource = _dataAccess.GetMedicinesInDiagnosis(diagnosisId)
                .Select(m => new MedecineInfo{ Name = m.MedicineName}).ToList();
        }

        private void FillMedicineComboBox()
        {
            medecinesComboBox.Items.Clear();

            foreach (var medecine in _dataAccess.GetMedicineNames().ToArray())
            {
                medecinesComboBox.Items.Add(medecine.Name);
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _dataAccess.SetDiagnosisJournal(diagnosisId, descriptionTextBox.Text);
        }

        private void addMedecineBTN_Click(object sender, EventArgs e)
        {
            //Name of the medicine that is being added
            string medicineName = medecinesComboBox.Text;

            //Try to add the medecine to medecine record
            if (_dataAccess.TryAddMedecine(medicineName))
                FillMedicineComboBox(); //Refill combobox if new medicine was created

            //Keep track if the medicine should be added
            bool addMedicine = true; 

            foreach (var medicine in _dataAccess.GetMedicinesInDiagnosis(diagnosisId))
            {
                if (medicine.MedicineName == medicineName)
                {
                    //Medicine is already in journal
                    addMedicine = false; 
                    break;
                }
            }

            //Add medicine to diagnosis
            if(addMedicine)
                _dataAccess.AddMedicineDiagnosisRelation(diagnosisId, medicineName);


            //Refill medicinelist
            FillMedicineList();
        }

        private void removeMedicine_Click(object sender, EventArgs e)
        {
            int rowIndex = HelperMethod.GetSelectedRowIndex(medicineDataGridView);

            if (rowIndex >= 0)
            {
                string medicineName = medicineDataGridView[0, rowIndex].Value.ToString();

                _dataAccess.RemoveMedicineRelation(diagnosisId, medicineName);

                FillMedicineList();
            }            
        }

        //Close form
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
