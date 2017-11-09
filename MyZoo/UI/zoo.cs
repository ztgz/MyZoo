using System;
using System.ComponentModel;
using System.Diagnostics;
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

            LoadSpeciesComboBox();
        }
        
        public void LoadSpeciesComboBox()
        {
            speciesComboBox.Items.Clear();

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

        private void addSpeciesBTN_Click(object sender, EventArgs e)
        {
            AddSpecies addSpeciesForm = new AddSpecies(this);
            addSpeciesForm.Show();
        }

        private void editSpeciesBTN_Click(object sender, EventArgs e)
        {
            EditSpecies editSpecies = new EditSpecies(this, speciesComboBox.Text, countryAddBox.Text);

            editSpecies.Show();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            int row = GetIndexOfSelectedRowOrCell();
            if (row >= 0)
            {
                //Get Id from first column, which is id
                int id = (int)searchDataGridView[0, row].Value;
                if (id > 0)
                {
                    //Try to get weight from animal
                    decimal.TryParse(searchDataGridView[1,row].Value.ToString(), out decimal weight);
                    OpenAnimalEditForm(id, weight);
                }
            }

        }

        private int GetIndexOfSelectedRowOrCell()
        {
            for (int i = 0; i < searchDataGridView.RowCount; i++)
            {
                //if row is selected
                if (searchDataGridView.Rows[i].Selected)
                {
                    return i;
                }

                //if cell is selected
                for (int x = 0; x < searchDataGridView.ColumnCount; x++)
                {
                    if (searchDataGridView[x, i].Selected)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private void OpenAnimalEditForm(int animalId, decimal? weight)
        {

            //Open edit form
            EditAnimal editForm = new EditAnimal(animalId, weight);
            editForm.Show();
        }

        private void editParentsBTN_Click(object sender, EventArgs e)
        {
            int row = GetIndexOfSelectedRowOrCell();
            if (row >= 0)
            {
                //Get Id from first column, which is id
                int id = (int)searchDataGridView[0, row].Value;
                if (id > 0)
                {
                    //Add id, speice, parent1, parent2
                    EditParents parentsForm = new EditParents(id, 
                      searchDataGridView[2, row].Value.ToString(),
                      int.Parse(searchDataGridView[6, row].Value.ToString()),
                      int.Parse(searchDataGridView[7, row].Value.ToString())
                      );
                    parentsForm.Show();
                }
            }
        }

        
    }
}
