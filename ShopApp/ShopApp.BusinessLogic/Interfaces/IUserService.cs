using ShopApp.Common.Models;

namespace ShopApp.BusinessLogic.Interfaces;

public interface IUserService
{
    IEnumerable<User> GetUsers();

    User Get(string email, string password);

    void Delete(int id);

    void Create(User user);
}