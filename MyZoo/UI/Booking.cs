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
    public partial class Booking : Form
    {
        private DataAccess _dataAccess;

        public Booking()
        {
            InitializeComponent();

            _dataAccess = new DataAccess();

            vetrinaryDataGridView.DataSource = _dataAccess.GetVetrinariesInfo();
        }
    }
}
