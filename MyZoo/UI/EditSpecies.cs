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

        private readonly SqlCommands _sqlCommands;

        public EditSpecies(Zoo zoo, string speciesName, string country)
        {
            InitializeComponent();
            this.zoo = zoo;

            _sqlCommands = new SqlCommands();

            speciesNameTextBox.Text = speciesName;

            countryTextBox.Text = country;

            LoadEnviorments();

            LoadFoodTypes();
        }

        private void LoadEnviorments()
        {
            var enviorments = _sqlCommands.GetEnviormentsNames();

            foreach (var enviorment in enviorments)
            {
                enviormentComboBox.Items.Add(enviorment);
            }

            enviormentComboBox.SelectedIndex = 0;
        }

        private void LoadFoodTypes()
        {
            var foodTypes = _sqlCommands.GetFoodTypeNames();

            foreach (var foodType in foodTypes)
            {
                foodTypeComboBox.Items.Add(foodType);
            }

            foodTypeComboBox.SelectedIndex = 0;
        }

        private void editSpeciesBTN_Click(object sender, EventArgs e)
        {

            if (_sqlCommands.EditSpecies(speciesNameTextBox.Text, enviormentComboBox.Text, foodTypeComboBox.Text,
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
