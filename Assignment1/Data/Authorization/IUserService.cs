using Assignment1.Models.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Data.Authorization
{
    public interface IUserService
    {
        User ValidateUser(string userName, string passWord);
    }
}
