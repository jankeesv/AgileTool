using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using VelthovenConsultancy.AgileTool.Authorization.Roles;
using VelthovenConsultancy.AgileTool.Configuration;
using VelthovenConsultancy.AgileTool.MultiTenancy;
using VelthovenConsultancy.AgileTool.Users;
using VelthovenConsultancy.AgileTool.Web;

namespace VelthovenConsultancy.AgileTool.EntityFramework
{
    [DbConfigurationType(typeof(AgileToolDbConfiguration))]
    public class AgileToolDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public AgileToolDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                AgileToolConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of AgileToolDbContext since ABP automatically handles it.
         */
        public AgileToolDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public AgileToolDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public AgileToolDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class AgileToolDbConfiguration : DbConfiguration
    {
        public AgileToolDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
