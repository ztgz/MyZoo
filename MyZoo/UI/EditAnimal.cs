using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyZoo.DAL;

namespace MyZoo.UI
{
    public partial class EditAnimal : Form
    {
        private SqlCommands _sqlCommands;

        private int animalId;

        public EditAnimal(int animalId, decimal? animalWeight)
        {
            Debug.WriteLine(animalWeight);
            InitializeComponent();

            _sqlCommands = new SqlCommands();

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

            var speciesList = _sqlCommands.GetSpecieses();
            foreach (var specie in speciesList)
            {
                speciesComboBox.Items.Add(specie.SName);
            }

            speciesComboBox.SelectedIndex = 0;

        }

        private void editAnimalBTN_Click(object sender, EventArgs e)
        {
            decimal.TryParse(weightAddTextBox.Text, out decimal weight);

            _sqlCommands.EditAnimal(animalId, speciesComboBox.Text, weight);

            this.Close();
        }
    }
}
