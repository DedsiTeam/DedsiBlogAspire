using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Scalar.AspNetCore;

namespace DBA.AspNetCore;

public static class DBAAspNetCoreExtensions
{
    public static void AddAspireSqlServerDbContext<TDbContext>(this IHostApplicationBuilder builder, string connectionName) where TDbContext : DbContext
    {
        builder.AddSqlServerDbContext<TDbContext>(connectionName);
    }
    
    /// <summary>
    /// 使用 Scalar
    /// </summary>
    /// <param name="endpoints"></param>
    public static void UseScalarUi(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapScalarApiReference();
    }
}
