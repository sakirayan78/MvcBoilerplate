
using MvcBoilerplate.Model;
using MvcBoilerplate.Repository.Common;


namespace MvcBoilerplate.Service
{
 public   interface IUserService
    {
   
     IPagedList<User> GetAllUserPaged(int pageIndex, int pageSize);

     string GetRoleByUser(User usr);


     bool IsRegisteredUser(User usrUser);
   
    }
}
