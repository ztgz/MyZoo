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
    public partial class Zoo : Form
    {
        private DataAccess dataAccess;
        public Zoo()
        {
            InitializeComponent();

            dataAccess = new DataAccess();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            searchDataGridView.DataSource = dataAccess.GetAnimalInfos(foodTypeSearchBox.Text, speciesSearchBox.Text, enviormentSearchBox.Text);
        }
    }
}
