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

            if (_dataAccess.EditSpecie(speciesNameTextBox.Text, enviormentComboBox.Text, foodTypeComboBox.Text,
                countryTextBox.Text))
            {
                infoLabel.Text = speciesNameTextBox.Text + " were succesfully edited.";

                zoo.LoadSpeciesComboBox();
            }
            else
            {
                infoLabel.Text = speciesNameTextBox.Text + " edit failed.";
            }

        }
    }
}
