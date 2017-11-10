using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
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

        public List<int> GetAnimalsOfType(string speciesName)
        {
            var info = GetAnimalInfos("", speciesName, "");

            return info.Select(s => s.Id).ToList();
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

        public List<String> GetEnviormentsNames()
        {
            var enviorments = GetEnviorments();

            return enviorments.Select(e => e.EName).ToList();
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

        public List<String> GetFoodTypeNames()
        {
            var foodTypes = GetFoodTypes();

            return foodTypes.Select(f => f.FName).ToList();
        }

        public bool AddSpecie(string name, string enviorment, string foodType, string country)
        {
            bool specieAdded = false;

            //get all species
            var listOfSpecies = GetSpecieses();

            //specie should not be added if it already exist
            foreach (var speciese in listOfSpecies)
            {
                if (speciese.SName == name)
                    return false;
            }

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

        public bool EditAnimal(int id, string specie, decimal? weight)
        {
            bool editedAnimal = false;

            using (var db = new ZooContext())
            {
                Animal animal = db.Animal.SingleOrDefault(a => a.Id == id);

                Species species = db.Species.SingleOrDefault(s => s.SName == specie);

                animal.Species = species;
                animal.AnimalWeight = weight;

                db.SaveChanges();

                editedAnimal = true;
            }

            return editedAnimal;
        }

        public bool EditParents(int animalId, int parent1Id, int parent2Id)
        {
            bool editedParents = false;

            using (var db = new ZooContext())
            {
                Animal animal = db.Animal.SingleOrDefault(a => a.Id == animalId);

                List<Relations> relationships = db.Relations.ToList();

                //remove old parents
                for (int i = relationships.Count - 1; i >= 0; i--)
                {
                    if (relationships[i].ChildId == animalId)
                    {
                        //db.Relations.Attach(relationships[i]);
                        //db.Relations.Remove(relationships[i]);
                        db.Entry(relationships[i]).State = EntityState.Deleted;
                    }
                }

                db.SaveChanges();
                
                //Add relations
                if (parent1Id > 0)
                {
                    Animal parent = db.Animal.SingleOrDefault(a => a.Id == parent1Id);
                    
                    Relations relations = new Relations()
                    {
                        Animal1 = parent,
                        Animal = animal
                    };

                    db.Relations.Add(relations);
                }

                if (parent2Id > 0)
                {
                    Animal parent = db.Animal.SingleOrDefault(a => a.Id == parent2Id);

                    Relations relations = new Relations()
                    {
                        Animal1 = parent,
                        Animal = animal
                    };

                    db.Relations.Add(relations);
                }

                db.SaveChanges();

                editedParents = true;
            }

            return editedParents;
        }

        public bool DeleteAnimal(int animalId)
        {
            bool deletedAnimal = false;

            //remove all relationship where animal is the child
            EditParents(animalId, 0, 0);

            using (var db = new ZooContext())
            {
                //remove all with the animal
                foreach (var relationse in db.Relations)
                {
                    if (relationse.ParentId == animalId || relationse.ParentId == animalId)
                    {
                        db.Entry(relationse).State = EntityState.Deleted;
                    }
                }

                db.SaveChanges();

                Animal animal = db.Animal.SingleOrDefault(a => a.Id == animalId);
                //db.Animal.Attach(animal);
                //db.Animal.Remove(animal);
                db.Entry(animal).State = EntityState.Deleted;

                db.SaveChanges();

                deletedAnimal = true;
            }

            return deletedAnimal;
        }

        public BindingList<VetrinaryInfo> GetVetrinariesInfo()
        {
            BindingList<VetrinaryInfo> infos = null;

            using (var db = new ZooContext())
            {
                var vetrinaries = from vet in db.Veterinary
                    select new VetrinaryInfo()
                    {
                        Id = vet.Id,
                        Name = vet.PersonName
                    };

                infos = new BindingList<VetrinaryInfo>(vetrinaries.ToList());
            }

            return infos;
        }

        public BindingList<Booking> GetBookingsForAnimal(int animalId)
        {
            BindingList<Booking> bookings = null;

            using (var db = new ZooContext())
            {
                var bookedTimes = db.Booking.Where(b => b.AnimalId == animalId);
                
                bookings = new BindingList<Booking>(bookedTimes.ToList());
            }

            return bookings;
        }

        public BindingList<Booking> GetBookingsForVeterinary(int veterinary)
        {
            BindingList<Booking> bookings = null;

            using (var db = new ZooContext())
            {
                var bookedTimes = db.Booking.Where(b => b.VeterinaryId == veterinary);

                bookings = new BindingList<Booking>(bookedTimes.ToList());
            }

            return bookings;
        }

        public bool AddBooking(int animalId, int veterinaryId, DateTime startDate, DateTime endDate)
        {
            bool booked = false;

            using (var db = new ZooContext())
            {
                Animal animal = db.Animal.SingleOrDefault(a => a.Id == animalId);

                Veterinary vet = db.Veterinary.SingleOrDefault(v => v.Id == veterinaryId);

                Booking booking = new Booking()
                {
                    Animal = animal,
                    Veterinary = vet,
                    StartDate = startDate,
                    EndDate = endDate,
                };

                db.Booking.Add(booking);

                db.SaveChanges();

                booked = true;
            }

            return booked;
        }

        public bool DeleteBooking(int bookingId)
        {
            bool removed = false;

            using (var db = new ZooContext())
            {
                //Get all diagnosies for the booking
                var diagnosies = db.Diagnosis.Where(d => d.BookingId == bookingId).ToList();

                //Get and remove all connections between medicine and diagonsis, remove all related diagnosis
                for (int i = diagnosies.Count - 1; i >= 0; i--)
                {
                    Diagnosis diagnois = diagnosies[i];

                    var medecineDiagonsis = db.MedicineDiagnosisRelation
                        .Where(r => r.DiagnosisId == diagnois.Id)
                        .ToList();

                    for (int x = medecineDiagonsis.Count-1; x >= 0; x--)
                    {
                        MedicineDiagnosisRelation md = medecineDiagonsis[x];
                        db.Entry(md).State = EntityState.Deleted;
                    }

                    db.Entry(diagnois).State = EntityState.Deleted;
                }

                //save changes
                //db.SaveChanges();

                //remove booking
                Booking booking = db.Booking.SingleOrDefault(b => b.Id == bookingId);
                db.Booking.Attach(booking);
                db.Booking.Remove(booking);

                //save changes
                db.SaveChanges();

                removed = true;
            }

            return removed;
        }
    }
    
}
