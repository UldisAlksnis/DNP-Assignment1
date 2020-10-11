using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);

    }
}