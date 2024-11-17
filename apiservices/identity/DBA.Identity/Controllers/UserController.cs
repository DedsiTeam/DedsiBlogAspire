using DBA.Identity.Domain.Users;
using DBA.Identity.Infrastructure.Repositories.Users;
using Microsoft.AspNetCore.Mvc;

namespace DBA.Identity.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController(IUserRepository userRepository) : ControllerBase
{
    [HttpGet("{id}")]
    public Task<User?> GetAsync(Guid id) => userRepository.GetAsync(a => a.Id == id);
}