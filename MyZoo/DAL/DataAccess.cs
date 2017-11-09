using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MyZoo.DataContext;
using MyZoo.Models;

namespace MyZoo.DAL
{
    public class DataAccess
    {
        public BindingList<AnimalInfo> GetAnimalInfos(string foodType, string species, string enviorment)
        {
            BindingList<AnimalInfo> animalInfos;
            using (var db = new ZooContext())
            {

                //Get all the animals that match the criteria
                var animals = from animal in db.Animal
                    where animal.Species.FoodType.FName.Contains(foodType) &
                          animal.Species.Enviorment.EName.Contains(enviorment) &
                          animal.Species.SName.Contains(species)
                    select new AnimalInfo
                    {
                        Id = animal.Id,
                        Country = animal.Species.Country,
                        Enviorment = animal.Species.Enviorment.EName,
                        FoodType = animal.Species.FoodType.FName,
                        Species = animal.Species.SName,
                        Weight = animal.AnimalWeight,
                    };
                
                List<AnimalInfo> animalList = animals.ToList();

                //Add parents to the animals
                foreach (var relation in db.Relations)
                {
                    for (int i = 0; i < animalList.Count; i++)
                    {
                        if (relation.ChildId == animalList[i].Id)
                        {
                            if (animalList[i].Parent1Id == 0)
                            {
                                animalList[i].Parent1Id = relation.ParentId.Value;
                            }
                            else
                            {
                                animalList[i].Parent2Id = relation.ParentId.Value;
                            }
                        }
                    }
                }
                

                animalInfos = new BindingList<AnimalInfo>(animalList);
            }

            return animalInfos;
        }

        public BindingList<Species> GetSpecieses()
        {
            BindingList<Species> specieses;

            using (var db = new ZooContext())
            {
                var species = from specie in db.Species
                    select specie;

                specieses = new BindingList<Species>(species.ToList());
            }
            
            return specieses;
        }

        public SpeciesInfo GetSpecieInfo(string speciesName)
        {
            SpeciesInfo specie = null;

            using (var db = new ZooContext())
            {
                Species species = db.Species.SingleOrDefault(s => s.SName == speciesName);
                if (species != null)
                {
                    specie = new SpeciesInfo()
                    {
                        Id = species.Id,
                        SpeciesName = species.SName,
                        EnviormentName = species.Enviorment.EName,
                        CountryName = species.Country,
                        FoodTypName = species.FoodType.FName
                    };
                }
                
            }

            return specie;
        }

        public bool AddAnimal(string speciesName, decimal? weight, int parent1, int parent2)
        {
            using (var db = new ZooContext())
            {
                Species species = db.Species.SingleOrDefault(s => s.SName == speciesName);

                if (species == null)
                    return false;

                Animal animal = new Animal()
                {
                    Species = species,
                    AnimalWeight = weight
                };

                db.Animal.Add(animal);

                db.SaveChanges();

                //Add parents
                if (parent1 != 0)
                {
                    Relations relation = new Relations
                    {
                        ChildId = animal.Id,
                        ParentId = parent1
                    };

                    db.Relations.Add(relation);
                }

                if (parent2 != 0 && parent2 != parent1)
                {
                    Relations relation = new Relations
                    {
                        ChildId = animal.Id,
                        ParentId = parent2
                    };

                    db.Relations.Add(relation);
                }

                db.SaveChanges();
            }

            return true;
        }

        public List<Enviorment> GetEnviorments()
        {
            List<Enviorment> enviorments = new List<Enviorment>();

            using (var db = new ZooContext())
            {
                enviorments = db.Enviorment.ToList();
            }

            return enviorments;
        }

        public List<FoodType> GetFoodTypes()
        {
            List<FoodType> foodTypes = new List<FoodType>();

            using (var db = new ZooContext())
            {
                foodTypes = db.FoodType.ToList();
            }

            return foodTypes;
        }

        public bool AddSpecie(string name, string enviorment, string foodType, string country)
        {
            bool specieAdded = false;
            
            using (var db = new ZooContext())
            {
                FoodType food = db.FoodType.SingleOrDefault(f => f.FName == foodType);

                Enviorment env = db.Enviorment.SingleOrDefault(e => e.EName == enviorment);

                Species specie = new Species()
                {
                    SName = name,
                    FoodType = food,
                    Country = country,
                    Enviorment = env
                };

                db.Species.Add(specie);

                db.SaveChanges();

                specieAdded = true;
            }

            return specieAdded;
        }

        public bool EditSpecie(string name, string enviorment, string foodType, string country)
        {
            bool specieEdited = false;

            using (var db = new ZooContext())
            {
                FoodType food = db.FoodType.SingleOrDefault(f => f.FName == foodType);

                Enviorment env = db.Enviorment.SingleOrDefault(e => e.EName == enviorment);

                Species specie = db.Species.SingleOrDefault(s => s.SName == name);

                specie.Country = country;
                specie.Enviorment = env;
                specie.FoodType = food;

                db.SaveChanges();

                specieEdited = true;
            }

            return specieEdited;
        }

    }
    
}
