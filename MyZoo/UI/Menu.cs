using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
