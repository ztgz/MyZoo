using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
    
}
