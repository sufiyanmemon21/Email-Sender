using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Role_base_Authentication.Areas.Identity.Data;

namespace Role_base_Authentication.Data;

public class Role_base_AuthenticationContext : IdentityDbContext<ApplicationUser>
{
    public Role_base_AuthenticationContext(DbContextOptions<Role_base_AuthenticationContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
