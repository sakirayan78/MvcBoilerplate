using MvcBoilerplate.Model;
using MvcBoilerplate.Repository.Common;

namespace MvcBoilerplate.Repository
{

    public interface IUserRepository : IGenericRepository<User>
    {

        IPagedList<User> GetAllUserPaged(int pageIndex, int pageSize);

        string GetRoleByUser(User usr);


        bool IsRegisteredUser(User usrUser);
    }
}
