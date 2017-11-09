using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MyZoo.DataContext;
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

        public bool AddAnimal(string speciesName, decimal? weight, int parent1, int parent2)
        {
            return _dataAccess.AddAnimal(speciesName, weight, parent1, parent2);
        }

        public List<int> GetAnimalsOfType(string speciesName)
        {
            var info = _dataAccess.GetAnimalInfos("", speciesName, "");

            return info.Select(s => s.Id).ToList();
        }

        public List<String> GetEnviormentsNames()
        {
            var enviorments = _dataAccess.GetEnviorments();

            return enviorments.Select(e => e.EName).ToList();
        }

        public List<String> GetFoodTypeNames()
        {
            var foodTypes = _dataAccess.GetFoodTypes();

            return foodTypes.Select(f => f.FName).ToList();
        }

        public bool AddSpecies(string specieName, string enviorment, string foodType, string country)
        {
            //get all species
            var listOfSpecies = _dataAccess.GetSpecieses();

            //specie should not be added if it already exist
            foreach (var speciese in listOfSpecies)
            {
                if (speciese.SName == specieName)
                    return false;
            }
            
            //since species does not exist add new specie
            return _dataAccess.AddSpecie(specieName, enviorment , foodType, country);
        }

        public bool EditSpecies(string name, string enviorment, string foodType, string country)
        {
            return _dataAccess.EditSpecie(name, enviorment, foodType, country);
        }

        public bool EditAnimal(int id, string specie, decimal? weight)
        {
            return _dataAccess.EditAnimal(id, specie, weight);
        }

        public bool EditParents(int animalId, int parent1Id, int parent2Id)
        {
            return _dataAccess.EditParents(animalId, parent1Id, parent2Id);
        }
    }
}
