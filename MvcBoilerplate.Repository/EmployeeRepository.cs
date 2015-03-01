
using MvcBoilerplate.Model;
using MvcBoilerplate.Repository.Common;
using System.Data.Entity;
namespace MvcBoilerplate.Repository
{
    class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(DbContext context)
            : base(context)
        {

        }

    }
}
