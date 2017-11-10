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
using MyZoo.Models;

namespace MyZoo.UI
{
    public partial class Diagnosis : Form
    {
        private DataAccess _dataAccess = new DataAccess();

        private int diagnosisId;

        public Diagnosis(int bookingId, int animalId)
        {
            InitializeComponent();

            diagnosisId = bookingId;

            bookingIdLabel.Text = $"Edit information for booking {bookingId}. Journal regarding animal {animalId}";
            
            FillMedicineComboBox();

            FillMedicineList();
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

        private void addMedecineBTN_Click(object sender, EventArgs e)
        {
            //name of the medicine that is being added
            string medicineName = medecinesComboBox.Text;

            //Try to add the medecine to medecine record
            bool refilComboBox = _dataAccess.TryAddMedecine(medicineName);

            bool addMedicine = true;

            foreach (var medicine in _dataAccess.GetMedicinesInDiagnosis(diagnosisId))
            {
                if (medicine.MedicineName == medicineName)
                {
                    addMedicine = false; //medecine is already in journal
                    break;
                }
            }

            if(addMedicine)
                _dataAccess.AddMedicineDiagnosisRelation(diagnosisId, medicineName);

            //Refill combobox if new medicine was created
            if(refilComboBox)
                FillMedicineComboBox();

            //Refill medicinelist
            FillMedicineList();
        }
    }
}
