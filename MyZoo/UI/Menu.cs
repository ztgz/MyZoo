using System;
using System.Windows.Forms;

namespace MyZoo.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void animalsBTN_Click(object sender, EventArgs e)
        {
            Program.activeForm = Program.RUNZOO;
            this.Close();
        }

        private void veterinaryBTN_Click(object sender, EventArgs e)
        {
            Program.activeForm = Program.RUNVETERINARY;
            this.Close();
        }
    }
}
