using Assignment1.Models.Authorization;

namespace Assignment1.Data.Authorization
{
    public interface IUserService
    {
        User ValidateUser(string userName, string passWord);
    }
}
