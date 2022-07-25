using Microsoft.AspNetCore.Mvc;
using ShopApp.BusinessLogic.Services;
using ShopApp.Common.Models;

namespace ShopApp.Controllers;

[ApiController]
[Route("api/[user-controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    public IEnumerable<User> GetAllUser()
    {
        return _userService.GetUsers();
    }
    
    [HttpGet]
    public User GetUser(string email, string password)
    {
        return _userService.Get(email, password);
    }
    
    [HttpPost]
    public void CreateNewUser(User user)
    {
        _userService.Create(user);
    }
    
    [HttpDelete]
    public void DeleteRecord(int id)
    {
        _userService.Delete(id);
    }
}