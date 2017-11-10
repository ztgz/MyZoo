using System;
using System.Windows.Forms;
using MyZoo.DAL;

namespace MyZoo.UI
{
    public partial class AddSpecies : Form
    {
        private DataAccess _dataAccess;

        private Zoo zoo;

        public AddSpecies(Zoo zoo)
        {
            InitializeComponent();

            this.zoo = zoo;

            _dataAccess = new DataAccess();

            //Load Enviorments into combobox
            LoadEnviorments();

            //Load Food types into combobox
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

        /* Add species record */
        private void button1_Click(object sender, EventArgs e)
        {
            //Get info about the specie to add
            string speciesName = speciesNameTextBox.Text;

            string country = countryTextBox.Text;

            //Only add specie if namn contains characters
            if (speciesName.Length > 0)
            {
                //Try to add species
                if ( _dataAccess.AddSpecie( speciesName, 
                    enviormentComboBox.Text,
                    foodTypeComboBox.Text, 
                    country) )
                {
                    infoLabel.Text = "The specie were added.";

                    speciesNameTextBox.Text = "";
                    countryTextBox.Text = "";
                    
                    //Reload the species in zoo forms
                    zoo.LoadSpecies();
                }
                else
                {
                    infoLabel.Text = "Could not add specie. " +
                                  "\nCheck that the specie name dosen't exist.";
                }
            }
            else
            {
                infoLabel.Text = "You have to specify a name for the specie.";
            }

        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
