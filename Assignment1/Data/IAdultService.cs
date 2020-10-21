using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void EditAdult(Adult adult);
        Adult GetById(int Id);
        void UpdateAdult(Adult adultToUpdate);
        void RemoveAdult(int id);
    }
}