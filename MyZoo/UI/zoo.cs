using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyZoo.DataContext;
using MyZoo.DAL;
using MyZoo.Models;

namespace MyZoo.UI
{
    public partial class Zoo : Form
    {
        private SqlCommands _sqlCommands;

        private BindingList<Species> speciesList;

        public Zoo()
        {
            InitializeComponent();

            speciesList = null;

            _sqlCommands = new SqlCommands();
            
            InitialLoad();
        }

        private void InitialLoad()
        {
            LoadSpeciesComboBox();

        }

        private void LoadSpeciesComboBox()
        {
            speciesList = _sqlCommands.GetSpecieses();
            foreach (var specie in speciesList)
            {
                speciesComboBox.Items.Add(specie.SName);
            }

            speciesComboBox.SelectedIndex = 0;

            LoadSpecieInfo();
        }

        private void SpeciesComboBoxChanged(object sender, EventArgs e)
        {
            LoadSpecieInfo();
        }

        private void LoadSpecieInfo()
        {
            SpeciesInfo sInfo = _sqlCommands.GetSpeciesInfo(speciesComboBox.Text);

            //Load species info
            enviormentAddTextBox.Text = sInfo.EnviormentName;
            foodTypeAddTextBox.Text = sInfo.FoodTypName;
            countryAddBox.Text = sInfo.CountryName;

            AddParentsToComboBox();

        }

        private void AddParentsToComboBox()
        {
            //Set default parent1 to 0
            parent1ComboBox.Items.Clear();
            parent1ComboBox.Items.Add(0);
            parent1ComboBox.SelectedIndex = 0;

            //Set default parent2 to 0
            parent2ComboBox.Items.Clear();
            parent2ComboBox.Items.Add(0);
            parent2ComboBox.SelectedIndex = 0;

            //Load possible parrents into combo boxes
            foreach (var id in _sqlCommands.GetAnimalsOfType(speciesComboBox.Text))
            {
                parent1ComboBox.Items.Add(id);
                parent2ComboBox.Items.Add(id);
            }
        }
        

        private void searchBTN_Click(object sender, EventArgs e)
        {
            searchDataGridView.DataSource = _sqlCommands.GetAnimalInfos(foodTypeSearchBox.Text, speciesSearchBox.Text, enviormentSearchBox.Text);
        }

        private void animalAddBTN_Click(object sender, EventArgs e)
        {
            //Get weight of animal
            decimal.TryParse(weightAddTextBox.Text, out decimal weight);

            //Get Id of parents
            int.TryParse(parent1ComboBox.Text, out int parent1);
            int.TryParse(parent2ComboBox.Text, out int parent2);

            _sqlCommands.AddAnimal(speciesComboBox.Text, weight, parent1, parent2 );

            weightAddTextBox.Text = "";
        }
    }
}
