using System;
using System.Windows.Forms;
using MyZoo.DAL;

namespace MyZoo.UI
{
    public partial class EditSpecies : Form
    {
        private Zoo zoo;

        private DataAccess _dataAccess;

        public EditSpecies(Zoo zoo, string speciesName, string country)
        {
            InitializeComponent();
            this.zoo = zoo;

            _dataAccess = new DataAccess();

            speciesNameTextBox.Text = speciesName;

            countryTextBox.Text = country;

            LoadEnviorments();

            LoadFoodTypes();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            zoo.Show();

            base.OnFormClosing(e);
        }

        private void LoadEnviorments()
        {
            var enviorments = _dataAccess.GetEnviormentsNames();

            foreach (var enviorment in enviorments)
            {
                enviormentComboBox.Items.Add(enviorment);
            }

            enviormentComboBox.SelectedIndex = 0;
        }

        private void LoadFoodTypes()
        {
            var foodTypes = _dataAccess.GetFoodTypeNames();

            foreach (var foodType in foodTypes)
            {
                foodTypeComboBox.Items.Add(foodType);
            }

            foodTypeComboBox.SelectedIndex = 0;
        }

        private void editSpeciesBTN_Click(object sender, EventArgs e)
        {
            //Edit specie
            if (_dataAccess.EditSpecies(speciesNameTextBox.Text, enviormentComboBox.Text, foodTypeComboBox.Text,
                countryTextBox.Text))
            {
                infoLabel.Text = speciesNameTextBox.Text + " were succesfully edited.";

                //Reload species in zoo form
                zoo.LoadSpecies();

                //Reload search results in zoo form
                zoo.Search();
            }
            else
            {
                infoLabel.Text = speciesNameTextBox.Text + " edit failed.";
            }

        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
