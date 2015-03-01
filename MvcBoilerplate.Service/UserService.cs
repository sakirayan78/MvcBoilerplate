
using MvcBoilerplate.Model;
using MvcBoilerplate.Repository;
using MvcBoilerplate.Repository.Common;
using ByX.Service.Common;


namespace MvcBoilerplate.Service
{
    public class UserService :EntityService<User>, IUserService
    {

        IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
            : base(unitOfWork, userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public IPagedList<User> GetAllUserPaged(int pageIndex, int pageSize)
        {
            var users = _userRepository.GetAllUserPaged(pageIndex, pageSize);
            return users;
        }


        public string GetRoleByUser(User usr)
        {
          return  _userRepository.GetRoleByUser(usr);
        }




        public bool IsRegisteredUser(User usrUser)
        {
            return _userRepository.IsRegisteredUser(usrUser);
        }
    }
}
