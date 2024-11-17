using Microsoft.EntityFrameworkCore;

namespace DBA.EFCore.EntityFrameworkCore;

public class DbaEfCoreDbContext(DbContextOptions options) : DbContext(options)
{
}
