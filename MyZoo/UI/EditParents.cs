﻿using System;
using System.Collections.Generic;
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

        private Zoo zoo;

        private DataAccess _dataAccess;

        public EditParents(int animalId, string animalSpecie, int parent1Id, int parent2Id, Zoo zoo)
        {
            InitializeComponent();

            _dataAccess = new DataAccess();

            this.animalId = animalId;
            infoLabel.Text = "Parents to animal id " + animalId;

            this.animalSpecie = animalSpecie;

            this.parent1Id = parent1Id;
            this.parent2Id = parent2Id;

            this.zoo = zoo;

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
            List<int> parentsIDs = _dataAccess.GetAnimalsOfType(animalSpecie);

            for (int i = 0; i < parentsIDs.Count; i++)
            {
                if (parentsIDs[i] != animalId)
                {
                    parent1ComboBox.Items.Add(parentsIDs[i]);
                    parent2ComboBox.Items.Add(parentsIDs[i]);
                }
            }

            //Set parents from before, 
            for (int i = 0; i < parent1ComboBox.Items.Count; i++)
            {
                if(int.Parse(parent1ComboBox.Items[i].ToString()) == parent1Id)
                {
                    parent1ComboBox.SelectedIndex = i;
                }
                if (int.Parse(parent2ComboBox.Items[i].ToString()) == parent2Id)
                {
                    parent2ComboBox.SelectedIndex = i;
                }
            }
        }

        private void editParentsBTN_Click(object sender, EventArgs e)
        {
            //edit parents
            if (_dataAccess.EditParents(animalId, int.Parse(parent1ComboBox.Text),
                int.Parse(parent2ComboBox.Text)))
            {
                succesLabel.Text = "Parents were selected.";
            }
            else
            {
                succesLabel.Text = "Parents could not be selected.";
            }

            //reload the search box
            zoo.Search();
        }
    }
}
