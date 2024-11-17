using DBA.EFCore.Repositories;
using DBA.Identity.Domain.Users;
using DBA.Identity.Infrastructure.EntityFrameworkCore;

namespace DBA.Identity.Infrastructure.Repositories.Users;

public interface IUserRepository : IBaseRepository<User, Guid>;

public class UserRepository(IdentityDbContext dbContext): BaseRepository<IdentityDbContext, User, Guid>(dbContext),IUserRepository;