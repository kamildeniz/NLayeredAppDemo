using Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public interface EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
    {

    }
}
