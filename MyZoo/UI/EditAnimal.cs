using System;
using System.Diagnostics;
using System.Windows.Forms;
using MyZoo.DAL;

namespace MyZoo.UI
{
    public partial class EditAnimal : Form
    {
        private DataAccess _dataAccess;
        private int animalId;

        public EditAnimal(int animalId, decimal? animalWeight)
        {
            Debug.WriteLine(animalWeight);
            InitializeComponent();

            _dataAccess = new DataAccess();

            this.animalId = animalId;

            animalLabel.Text = "Edit animal with id " + animalId;

            if (animalWeight != null)
            {
                weightAddTextBox.Text = animalWeight.ToString();
            }

            LoadSpeciesComboBox();
        }

        private void LoadSpeciesComboBox()
        {
            speciesComboBox.Items.Clear();

            var speciesList = _dataAccess.GetSpecieses();
            foreach (var specie in speciesList)
            {
                speciesComboBox.Items.Add(specie.SName);
            }

            speciesComboBox.SelectedIndex = 0;

        }

        private void editAnimalBTN_Click(object sender, EventArgs e)
        {
            decimal.TryParse(weightAddTextBox.Text, out decimal weight);

            if (_dataAccess.EditAnimal(animalId, speciesComboBox.Text, weight))
            {
                infoLabel.Text = "Animal successfully edited.";
            }
            else
            {
                infoLabel.Text = "Edit failed.";
            }

        }
    }
}
