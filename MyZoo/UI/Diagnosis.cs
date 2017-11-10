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

            //Gets diagnosis number for bookingId
            diagnosisId = _dataAccess.CreateAndGetDiagnosisId(bookingId);

            //info text
            bookingIdLabel.Text = $"Edit information for booking {bookingId}. Journal regarding animal {animalId}"
                + $"\n Diagnosis {diagnosisId}";
            
            //Description text
            descriptionTextBox.Text = _dataAccess.GetDiagnosisJournal(diagnosisId);

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

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _dataAccess.SetDiagnosisJournal(diagnosisId, descriptionTextBox.Text);
        }

        private void removeMedicine_Click(object sender, EventArgs e)
        {
            int rowIndex = GetIndexOfSelectedRowOrCell(medicineDataGridView);

            if (rowIndex >= 0)
            {
                string medicineName = medicineDataGridView[0, rowIndex].Value.ToString();

                _dataAccess.RemoveMedicineRelation(diagnosisId, medicineName);

                FillMedicineList();
            }            
        }

        private int GetIndexOfSelectedRowOrCell(DataGridView dw)
        {
            for (int i = 0; i < dw.RowCount; i++)
            {
                //if row is selected
                if (dw.Rows[i].Selected)
                {
                    return i;
                }

                //if cell is selected
                for (int x = 0; x < dw.ColumnCount; x++)
                {
                    if (dw[x, i].Selected)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
