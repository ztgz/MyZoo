﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
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
        /*---------------------------------Methods Regarding animal---------------------------------*/
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

        public List<int> GetAnimalsIdOfType(string speciesName)
        {
            var info = GetAnimalInfos("", speciesName, "");

            return info.Select(s => s.Id).ToList();
        }

        public void AddAnimal(string speciesName, decimal? weight, int parent1, int parent2)
        {
            using (var db = new ZooContext())
            {
                //Animal is of species type
                Species species = db.Species.SingleOrDefault(s => s.SName == speciesName);

                //only add animal if species is correct
                if (species != null)
                {
                    Animal animal = new Animal()
                    {
                        Species = species,
                        AnimalWeight = weight
                    };
                
                    db.Animal.Add(animal);

                    db.SaveChanges();

                    //Add the animals parents
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
            }

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

        public bool DeleteAnimal(int animalId)
        {
            bool deletedAnimal = false;

             //All bookings with animal needs to be removed
            List<Booking> bookings = GetBookingsForAnimal(animalId).ToList();

            foreach (var booking in bookings)
            {
                DeleteBooking(booking.Id);
            }

            using (var db = new ZooContext())
            {
                //All relations with the animal needs to be removed
                foreach (var relationse in db.Relations)
                {
                    if (relationse.ParentId == animalId || relationse.ChildId == animalId)
                    {
                        db.Entry(relationse).State = EntityState.Deleted;
                    }
                }

                db.SaveChanges();
                
                //All records that animal depands on has been cleand, now animal can be removed
                Animal animal = db.Animal.SingleOrDefault(a => a.Id == animalId);

                db.Entry(animal).State = EntityState.Deleted;

                db.SaveChanges();

                deletedAnimal = true;
            }

            return deletedAnimal;
        }


        /*---------------------------------Methods regarding species---------------------------------*/
        public BindingList<Species> GetSpecieses()
        {
            BindingList<Species> specieses;

            using (var db = new ZooContext())
            {
                var species = from specie in db.Species select specie;

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

        public bool AddSpecies(string name, string enviorment, string foodType, string country)
        {
            //Get all species
            var listOfSpecies = GetSpecieses();

            //Specie should not be added if it already exist
            foreach (var speciese in listOfSpecies)
            {
                if (speciese.SName.ToLower() == name.ToLower())
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
            }

            return true;
        }

        public bool EditSpecies(string name, string enviorment, string foodType, string country)
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


        /*---------------------------------Methods regarding Enviorment---------------------------------*/
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


        /*---------------------------------Methods regarding food type---------------------------------*/
        public List<FoodType> GetFoodTypes()
        {
            List<FoodType> foodTypes;

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


        /*---------------------------------Methods regarding relations---------------------------------*/
        public bool EditParents(int animalId, int parent1Id, int parent2Id)
        {
            bool editedParents = false;

            using (var db = new ZooContext())
            {
                //Get animal
                Animal animal = db.Animal.SingleOrDefault(a => a.Id == animalId);

                //Get all relations
                List<Relations> relationships = db.Relations.ToList();

                //Remove the old parents
                for (int i = relationships.Count - 1; i >= 0; i--)
                {
                    if (relationships[i].ChildId == animalId)
                    {
                        db.Entry(relationships[i]).State = EntityState.Deleted;
                    }
                }

                db.SaveChanges();
                
                //Add new parents
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


        /*---------------------------------Methods regarding Vetrinaries---------------------------------*/
        public BindingList<VetrinaryInfo> GetVetrinariesInfo()
        {
            BindingList<VetrinaryInfo> infos;

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


        /*---------------------------------Methods regarding bookings---------------------------------*/
        public BindingList<Booking> GetBookingsForAnimal(int animalId)
        {
            BindingList<Booking> bookings;

            using (var db = new ZooContext())
            {
                var bookedTimes = db.Booking.Where(b => b.AnimalId == animalId);
                
                bookings = new BindingList<Booking>(bookedTimes.ToList());
            }

            return bookings;
        }

        public BindingList<Booking> GetBookingsForVeterinary(int veterinary)
        {
            BindingList<Booking> bookings;

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

                //Get and remove all connections between medicine and diagonsis
                //and remove all diagnosises
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

                //Remove booking
                Booking booking = db.Booking.SingleOrDefault(b => b.Id == bookingId);
                db.Booking.Attach(booking);
                db.Booking.Remove(booking);

                //save changes
                db.SaveChanges();

                removed = true;
            }

            return removed;
        }


        /*---------------------------------Methods regarding medicine---------------------------------*/
        public BindingList<MedecineInfo> GetMedicineNames()
        {
            BindingList<MedecineInfo> medicineList;

            using (var db = new ZooContext())
            {
                var meds = db.Medicine.Select(m => new MedecineInfo
                {
                    Name = m.MedicineName
                });

                medicineList = new BindingList<MedecineInfo>(meds.ToList());
            }

            return medicineList;
        }

        public BindingList<Medicine> GetMedicinesInDiagnosis(int diagnosisId)
        {
            BindingList<Medicine> medicineList;

            using (var db = new ZooContext())
            {
                var meds = db.MedicineDiagnosisRelation.Where(md => md.DiagnosisId == diagnosisId).Select(m => m.Medicine);

                medicineList = new BindingList<Medicine>(meds.ToList());
            }

            return medicineList;
        }

        public bool TryAddMedecine(string medicineName)
        {
            //Medicine needs to have an name
            if (string.IsNullOrEmpty(medicineName))
                return false;

            bool addedMedecine = false;

            using (var db = new ZooContext())
            {
                //Add medicine if it does not exist
                if (db.Medicine.SingleOrDefault(m => m.MedicineName.ToLower() == medicineName.ToLower()) == null)
                {
                    Medicine med = new Medicine
                    {
                        MedicineName = medicineName
                    };

                    db.Medicine.Add(med);

                    db.SaveChanges();

                    addedMedecine = true;
                }
            }

            return addedMedecine;
        }

        public void RemoveMedicineRelation(int diagnosisId, string medicineName)
        {
            if (string.IsNullOrEmpty(medicineName))
                return;

            using (var db = new ZooContext())
            {
                MedicineDiagnosisRelation medicineRelation = 
                    db.MedicineDiagnosisRelation.SingleOrDefault(m => m.Medicine.MedicineName == medicineName
                    && m.DiagnosisId == diagnosisId);

                db.Entry(medicineRelation).State = EntityState.Deleted;

                db.SaveChanges();
            }
        }


        /*---------------------------------Methods regarding diagnosis---------------------------------*/
        public int CreateAndGetDiagnosisId(int bookingId)
        {
            int id;

            using (var db = new ZooContext())
            {
                Diagnosis diagnosis = db.Diagnosis.SingleOrDefault(d => d.BookingId == bookingId);

                //if diagnosis dosn't exsist, create diagnosis
                if (diagnosis == null)
                {
                    //Get the booking related to the Id
                    Booking booking = db.Booking.SingleOrDefault(b => b.Id == bookingId);

                    diagnosis = new Diagnosis
                    {
                        Booking = booking
                    };

                    db.Diagnosis.Add(diagnosis);

                    db.SaveChanges();
                }

                //Id is the same as in the diagnosis
                id = diagnosis.Id;
            }

            return id;
        }

        public string GetDiagnosisJournal(int diagnosisId)
        {
            string journal = "";

            using (var db = new ZooContext())
            {
                //Get the diagnosis
                Diagnosis diagnosis = db.Diagnosis.SingleOrDefault(d => d.Id == diagnosisId);

                //And get return text if it's not null
                if (diagnosis != null)
                {
                    journal = diagnosis.Journal;
                }

            }

            return journal;
        }

        public void SetDiagnosisJournal(int diagnosisId, string journal)
        {
            using (var db = new ZooContext())
            {
                //Get the diagnosis
                Diagnosis diagnosis = db.Diagnosis.SingleOrDefault(d => d.Id == diagnosisId);

                //And set text if it's not null
                if (diagnosis != null)
                {
                    diagnosis.Journal = journal;

                    db.SaveChanges();
                }
            }
        }


        /*---------------------------------Methods regarding other---------------------------------*/
        public void AddMedicineDiagnosisRelation(int diagnosisId, string medicienname)
        {
            using (var db = new ZooContext())
            {
                Medicine medicine = db.Medicine.SingleOrDefault(m => m.MedicineName == medicienname);

                Diagnosis diagnosis = db.Diagnosis.SingleOrDefault(d => d.Id == diagnosisId);

                MedicineDiagnosisRelation mdr = new MedicineDiagnosisRelation()
                {
                    Medicine = medicine,
                    Diagnosis = diagnosis
                };

                db.MedicineDiagnosisRelation.Add(mdr);

                db.SaveChanges();
            }
        }

    }

}
