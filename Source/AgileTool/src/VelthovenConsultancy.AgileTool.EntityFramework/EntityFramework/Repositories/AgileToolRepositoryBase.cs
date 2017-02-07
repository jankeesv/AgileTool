using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace VelthovenConsultancy.AgileTool.EntityFramework.Repositories
{
    public abstract class AgileToolRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AgileToolDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AgileToolRepositoryBase(IDbContextProvider<AgileToolDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AgileToolRepositoryBase<TEntity> : AgileToolRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AgileToolRepositoryBase(IDbContextProvider<AgileToolDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
