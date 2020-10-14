using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Models;

namespace Assignment1.Data
{
    public class AdultService : IAdultService
    {
        private string adultFile = "persons.json";
        private IList<Adult> adults;

        public AdultService()
        {
            if (!File.Exists(adultFile))
            {
                Seed();
                WritePersonsToFile();
            }
            else
            {
                var content = File.ReadAllText(adultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> tmp2 = new List<Adult>(adults);
            return tmp2;
        }

        public void AddAdult(Adult adult)
        {
            var max = adults.Max(adult => adult.Id);
            adult.Id = ++max;
            adults.Add(adult);
            WritePersonsToFile();
        }

        private void adultsFile()
        {
            var productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, productsAsJson);
        }

        private void Seed()
        {
            Adult[] ps =
            {
                new Adult

                {
                    JobTitle = "Ninja",
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
                new Adult
                {
                    JobTitle = "Ninja",
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
            adults = ps.ToList();
        }

        private void WritePersonsToFile()
        {
            var productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, productsAsJson);
        }
    }
}
