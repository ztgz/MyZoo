using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyZoo.DAL;
using MyZoo.Models;

namespace MyZoo.DAL
{
    public class SqlCommands
    {
        private DataAccess _dataAccess;

        public SqlCommands()
        {
            _dataAccess = new DataAccess();
        }

        
    }
}
