using System.Linq;
using SimpleTaskSystem.EntityFramework;
using SimpleTaskSystem.MultiTenancy;

namespace SimpleTaskSystem.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SimpleTaskSystemDbContext _context;

        public DefaultTenantCreator(SimpleTaskSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == "Default");
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = "Default", Name = "Default"});
                _context.SaveChanges();
            }
        }
    }
}