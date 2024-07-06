using employee_crud.Models;
using employee_crud.Utils;

namespace employee_crud.Services
{
    internal class EmployeeService : CrudGeneric<EmployeeModel>
    {
        private List<EmployeeModel> _employees;

        public List<EmployeeModel> Employees
        {
            get => _employees;
            set => _employees = InitEmployeesList(value);
        }

        public EmployeeService()
        {
            _employees = new List<EmployeeModel>();
        }

        public EmployeeService(List<EmployeeModel> list)
        {
            _employees = InitEmployeesList(list);
        }

        private List<EmployeeModel> InitEmployeesList(List<EmployeeModel>? list)
        {
            return list ?? new List<EmployeeModel>();
        }

        public EmployeeModel InitBlankEmployee()
        {
            return new EmployeeModel();
        }
    }
}
