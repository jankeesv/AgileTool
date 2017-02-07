using System.Linq;
using VelthovenConsultancy.AgileTool.EntityFramework;
using VelthovenConsultancy.AgileTool.MultiTenancy;

namespace VelthovenConsultancy.AgileTool.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AgileToolDbContext _context;

        public DefaultTenantCreator(AgileToolDbContext context)
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

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
