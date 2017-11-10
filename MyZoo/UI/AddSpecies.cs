using System;
using System.Windows.Forms;
using MyZoo.DAL;

namespace MyZoo.UI
{
    public partial class AddSpecies : Form
    {
        //private readonly SqlCommands _sqlCommands;
        private DataAccess _dataAccess;

        private Zoo zoo;

        public AddSpecies(Zoo zoo)
        {
            InitializeComponent();

            this.zoo = zoo;

            _dataAccess = new DataAccess();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string speciesName = speciesNameTextBox.Text;
            string country = countryTextBox.Text;

            if (speciesName.Length > 0)
            {
                if (_dataAccess.AddSpecie(speciesName, enviormentComboBox.Text,
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            zoo.Show();

            base.OnFormClosing(e);
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
