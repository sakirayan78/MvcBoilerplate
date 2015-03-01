using MvcBoilerplate.Model;
using MvcBoilerplate.Repository.Common;
using System.Data.Entity;

namespace MvcBoilerplate.Repository
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {

        public RoleRepository(DbContext context)
            : base(context)
        {

        }


    }
}
