using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyZoo.DAL;

namespace MyZoo.UI
{
    public partial class EditParents : Form
    {
        private int animalId;
        private string animalSpecie;
        private int parent1Id;
        private int parent2Id;

        private SqlCommands _sqlCommands;

        public EditParents(int animalId, string animalSpecie, int parent1Id, int parent2Id)
        {
            InitializeComponent();

            _sqlCommands = new SqlCommands();

            this.animalId = animalId;
            infoLabel.Text = "Parents to animal id " + animalId;

            this.animalSpecie = animalSpecie;

            this.parent1Id = parent1Id;
            this.parent2Id = parent2Id;

            AddParentsToComboBox();
        }

        //private void Load possible parents
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
            List<int> parentsIDs = _sqlCommands.GetAnimalsOfType(animalSpecie);

            for (int i = 0; i < parentsIDs.Count; i++)
            {
                if (parentsIDs[i] != animalId)
                {
                    parent1ComboBox.Items.Add(parentsIDs[i]);
                    parent2ComboBox.Items.Add(parentsIDs[i]);
                }

                //Select current parent
                if(parentsIDs[i] == parent1Id)
                    parent1ComboBox.SelectedIndex = i + 1;

                //Select current parent
                if (parentsIDs[i] == parent2Id)
                    parent2ComboBox.SelectedIndex = i + 1;
            }
        }

        private void editParentsBTN_Click(object sender, EventArgs e)
        {
            //edit parents
            if (_sqlCommands.EditParents(animalId, int.Parse(parent1ComboBox.Text),
                int.Parse(parent2ComboBox.Text)))
            {
                succesLabel.Text = "Parents were selected.";
            }
            else
            {
                succesLabel.Text = "Parents could not be selected.";
            }
        }
    }
}
