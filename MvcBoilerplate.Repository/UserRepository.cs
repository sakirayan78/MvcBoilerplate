using MvcBoilerplate.Model;
using MvcBoilerplate.Repository.Common;
using System.Data.Entity;
using System.Linq;

namespace MvcBoilerplate.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context)
            : base(context)
        {
        }


        public IPagedList<User> GetAllUserPaged(int pageIndex, int pageSize)
        {
            var users = new PagedList<User>(
                _entities.Set<User>().AsQueryable().OrderBy(m => m.Id)
               , pageIndex, pageSize);


            return users;

        }

        public string GetRoleByUser(User usr)
        {
            string userroleName = "";

            var firstOrDefault = _entities.Set<User>().FirstOrDefault(m => m.UserName == usr.UserName &&
                m.Password == usr.Password);
            if (firstOrDefault != null)
            {
                userroleName = firstOrDefault.Role.Rolename;
            }
            return userroleName;
        }


        public bool IsRegisteredUser(User usrUser)
        {
            var firstOrDefault = _entities.Set<User>().FirstOrDefault(m => m.UserName == usrUser.UserName 
                && m.Password == usrUser.Password);
            return firstOrDefault != null;
        }
    }
}
