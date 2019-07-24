using AspVue2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspVue2.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly MyDbContext _context;

        public UserController(MyDbContext context)
        {
            _context = context;
        }

        // GET api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        // GET api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST api/User
        [HttpPost]
        public async Task<ActionResult<User>> Post(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest();
            }

            var addResult = _context.Users.Add(new User { Name = name });
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { Id = addResult.Entity.Id}, addResult.Entity);
        }

        // // PUT api/User/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // DELETE api/User/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null) {
                return BadRequest();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent(); 
        }
    }
}
