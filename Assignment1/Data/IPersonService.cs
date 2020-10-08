using System.Collections.Generic;
using Models;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IPersonService
    {
        IList<Person> GetPersons();
        void AddPerson(Person newPerson);

    }
}