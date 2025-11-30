using Microsoft.AspNetCore.Mvc;
using WebFamilyAspApi.Data;
using WebFamilyAspApi.Models;

namespace WebFamilyAspApi.Controllers
{
    [ApiController]
    [Route("groups")]
    public class GroupsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public GroupsController(AppDbContext db) => _db = db;

        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            var group = new Group { Name = name };
            _db.Groups.Add(group);
            await _db.SaveChangesAsync();
            return Ok(group);
        }

        [HttpGet]
        public IActionResult List() => Ok(_db.Groups.ToList());

        [HttpPost("{id}/members")]
        public async Task<IActionResult> AddMember(int id, int userId)
        {
            var member = new GroupMember { GroupId = id, UserId = userId };
            _db.GroupMembers.Add(member);
            await _db.SaveChangesAsync();
            return Ok(member);
        }
    }
}
