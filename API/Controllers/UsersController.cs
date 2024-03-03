using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // /api/users
public class UsersController : ControllerBase
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        _context = context;
    }

    // [HttpGet] // /api/users
    // public ActionResult<IEnumerable<AppUser>> GetUsers()
    // {
    //     var users = _context.Users.ToList();
    //     return users;
    // }

    [HttpGet] // /api/users
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }

    // [HttpGet("{id}")] // /api/users/2 
    // public ActionResult<AppUser> GetUserOnly(int id)
    // {
    //     return _context.Users.Find(id);
    // }

    [HttpGet("{id}")] // /api/users/2 
    public async Task<ActionResult<AppUser>> GetUserOnly(int id)
    {
        return await _context.Users.FindAsync(id);
    }



}
