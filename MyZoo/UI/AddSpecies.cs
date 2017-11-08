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


        public AddSpecies(Zoo zoo)
        {
            InitializeComponent();

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
    }
}
