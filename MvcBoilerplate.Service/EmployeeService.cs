
using MvcBoilerplate.Model;
using MvcBoilerplate.Repository;
using MvcBoilerplate.Repository.Common;
using ByX.Service.Common;


namespace MvcBoilerplate.Service
{
    public class EmployeeService :EntityService<Employee>, IEmployeeService
    {

        IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IUnitOfWork unitOfWork, IEmployeeRepository employeeRepository)
            : base(unitOfWork, employeeRepository)
        {
            _unitOfWork = unitOfWork;
            _employeeRepository = employeeRepository;
        }

      

    }
}
