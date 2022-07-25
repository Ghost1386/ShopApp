using ShopApp.BusinessLogic.Interfaces;
using ShopApp.Common.Models;

namespace ShopApp.BusinessLogic.Services;

public class UserService : IUserService
{
    private readonly ShopAppContext _db;

    public UserService(ShopAppContext db)
    {
        _db = db;
    }
    
    public IEnumerable<User> GetUsers()
    {
        return _db.Users.ToList();
    }

    public User Get(string email, string password)
    {
        User user = _db.Users.FirstOrDefault(
            x => x.Email == email && x.Password == password);
        
        return user;
    }

    public void Delete(int id)
    {
        User user = _db.Users.FirstOrDefault(x => x.Id == id);
        
        _db.Users.Remove(user);
        _db.SaveChanges();
    }

    public void Create(User user)
    {
        _db.Users.Add(user);
        _db.SaveChanges();
    }
}