using System;
using System.Windows.Forms;
using MyZoo.DAL;

namespace MyZoo.UI
{
    public partial class EditAnimal : Form
    {
        private DataAccess _dataAccess;

        private int animalId;

        private Zoo zoo;

        public EditAnimal(int animalId, decimal? animalWeight, Zoo zoo)
        {
            InitializeComponent();

            this.zoo = zoo;

            _dataAccess = new DataAccess();

            this.animalId = animalId;

            animalLabel.Text = "Edit animal with id " + animalId;

            if (animalWeight != null)
            {
                weightAddTextBox.Text = animalWeight.ToString();
            }

            LoadSpeciesComboBox();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            zoo.Show();

            base.OnFormClosing(e);
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
            //Try to get weight from combo box
            decimal.TryParse(weightAddTextBox.Text, out decimal weight);

            //Edit animal
            if (_dataAccess.EditAnimal(animalId, speciesComboBox.Text, weight))
            {
                infoLabel.Text = "Animal successfully edited.";
            }
            else
            {
                infoLabel.Text = "Edit failed.";
            }
            
            //Refresh the zoo search list
            zoo.Search();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
