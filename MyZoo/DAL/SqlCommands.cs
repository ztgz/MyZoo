using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyZoo.DataContext;
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


        public BindingList<AnimalInfo> GetAnimalInfos(string foodType, string species, string enviorment)
        {
            return _dataAccess.GetAnimalInfos(foodType, species, enviorment);
        }

        public BindingList<Species> GetSpecieses()
        {
            return _dataAccess.GetSpecieses();
        }

        public SpeciesInfo GetSpeciesInfo(string speciesName)
        {
            return _dataAccess.GetSpecieInfo(speciesName);
        }

        public bool AddAnimal(string speciesName, decimal? weight)
        {
            return _dataAccess.AddAnimal(speciesName, weight);
        }

        public List<int> GetAnimalsOfType(string speciesName)
        {
            var info = _dataAccess.GetAnimalInfos("", speciesName, "");

            return info.Select(s => s.Id).ToList();
        }
    }
}
