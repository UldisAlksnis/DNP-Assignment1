using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;
using Assignment1.Models;
using Assignment1.Data;

namespace Assignment1.Data
{
    public class PersonService : IPersonService
    {
        private string personFile = "persons.json";
        private IList<Person> persons;

        private IPersonService _personServiceImplementation;

        // private IList<Adult> Adults;
        public PersonService()
        {
            if (!File.Exists(personFile))
            {
                Seed();
                WritePersonsToFile();
            }
            else
            {
                var content = File.ReadAllText(personFile);
                persons = JsonSerializer.Deserialize<List<Person>>(content);
            }
        }

        public IList<Person> GetPersons()
        {
            List<Person> tmp2 = new List<Person>(persons);
            return tmp2;
        }

        public void AddPerson(Person newPerson)
        {
             var max = persons.Max(newPerson => newPerson.Id);
            newPerson.Id = ++max;
            persons.Add(newPerson);
            WritePersonsToFile();
        }

        private void personsFile()
        {
            var productsAsJson = JsonSerializer.Serialize(persons);
            File.WriteAllText(personFile, productsAsJson);
        }

        private void Seed()
        {
            Person[] ps =
            {
                new Person

                {
                    Id=  0,
                    FirstName= "Yeshua",
                    LastName= "Magana",
                    HairColor="Black",
                    EyeColor= "Blue",
                    Age= 44,
                    Weight= 61.4f,
                    Height= 166,
                    Sex= "M"
                },
                new Person
                {
                    Id = 1,
                    FirstName = "Jayden",
                    LastName = "Harrell",
                    HairColor = "Leverpostej",
                    EyeColor = "Brown",
                    Age = 43,
                    Weight = 76.6f,
                    Height = 145,
                    Sex = "F"
                }
            };
            persons = ps.ToList();
        }
        
        private void WritePersonsToFile()
        {
            var productsAsJson = JsonSerializer.Serialize(persons);
            File.WriteAllText(personFile, productsAsJson);
        }
        /*  public IList<Adult> GetAdults()
      {
          List<Adult> tmp = new List<Adult>(Adults);
          return tmp;
      }*/

            /*  public void AddAdult(Person adult)
              {
                  var max = Adults.Max(todo => Adults.Id);
                  Adults.AdultId = ++max;
                  Adults.Add(Adult);
                  WriteAdultsToFileContext();
              }*/

        }
    }
