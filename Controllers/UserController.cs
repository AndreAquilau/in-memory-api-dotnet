using InMemoryAPIDonet.Database;
using InMemoryAPIDonet.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InMemoryAPIDonet.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ApplicationContextDb _context;

    public UserController(ApplicationContextDb context)
    {
        _context = context;
    }

    // GET: api/<UserController>
    [HttpGet]
    public IEnumerable<User> Get()
    {
        var users = _context.users.ToList();

        return users;
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public User? GetById(int id)
    {
        var user = _context.users.FirstOrDefault(user => user.Id == id);
        return user;
    }

    // POST api/<UserController>
    [HttpPost]
    public ActionResult<User?> Post([FromBody] User user)
    {
        _context.users.Add(user);

        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new { user.Id }, user);
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public ActionResult<User?> Put(int id, [FromBody] User user)
    {
        var data = _context.users.FirstOrDefault(user => user.Id == id);

        if (data == null)
            return NotFound();

        data.Name = user.Name;
        data.Email = user.Email;

        _context.users.Update(data);

        _context.SaveChanges();

        return Ok(data);
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public ActionResult<User?> Delete(int id)
    {
        var user = _context.users.FirstOrDefault(user => user.Id == id);

        if (user == null)
            return NotFound();

        _context.users.Remove(user);

        _context.SaveChanges();

        return Ok(user);
    }
}
