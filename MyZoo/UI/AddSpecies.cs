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
    public partial class AddSpecies : Form
    {
        private SqlCommands _sqlCommands;

        private Zoo zoo;

        public AddSpecies(Zoo zoo)
        {
            InitializeComponent();

            this.zoo = zoo;

            _sqlCommands = new SqlCommands();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string speciesName = speciesNameTextBox.Text;
            string country = countryTextBox.Text;

            if (speciesName.Length > 0)
            {
                if (_sqlCommands.AddSpecies(speciesName, enviormentComboBox.Text,
                    foodTypeComboBox.Text, country))
                {
                    infoLabel.Text = "The specie were added.";

                    speciesNameTextBox.Text = "";
                    countryTextBox.Text = "";
                    
                    //reload the species combo box in zoo forms
                    zoo.LoadSpeciesComboBox();
                }
                else
                {
                    infoLabel.Text = "Could not att specie. " +
                                  "\nCheck that specie name dosen't exist.";
                }
            }
            else
            {
                infoLabel.Text = "You have to specify a name for the specie.";
            }
        }
    }
}
