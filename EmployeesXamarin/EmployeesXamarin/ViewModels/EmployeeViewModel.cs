using EmployeesXamarin.Models;
using EmployeesXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmployeesXamarin.ViewModels
{
    public class EmployeeViewModel : Employee
    {
        public ObservableCollection<Employee> Employees { get; set; }
        EmlpoyeeService service = new EmlpoyeeService();
        Employee employeeModel;
        public EmployeeViewModel()
        {
            Employees = service.GetEmployees();
            InsertEmployeeCommand = new Command(async() => await InsertEmployee(),()=>!IsBusy);
            UpdateEmployeeCommand = new Command(async () => await UpadateEmployee(), () => !IsBusy);
            DeleteEmployeeCommand = new Command(async () => await DeleteEmployee(), () => !IsBusy);
            CleanCommand = new Command(Clear, () => !IsBusy);
        }

        public Command InsertEmployeeCommand { get; set; }
        public Command UpdateEmployeeCommand { get; set; }
        public Command DeleteEmployeeCommand { get; set; }
        public Command CleanCommand { get; set; }

        private async Task InsertEmployee()
        {
            IsBusy = true;
            employeeModel = new Employee()
            {
                CompanyId = 1,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow,
                Email = Email,
                Fax = Fax,
                Name = Name,
                Lastlogin = DateTime.UtcNow,
                Password = Password,
                PortalId = 1,
                RoleId = 1,
                StatusId = 1,
                Telephone = Telephone,
                UpdatedOn = DateTime.UtcNow,
                Username = Username
            };
            service.InsertEmployee(employeeModel);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private async Task UpadateEmployee()
        {
            IsBusy = true;
            service.UpdateEmployee(employeeId,username);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private async Task DeleteEmployee()
        {
            IsBusy = true;
            service.DeleteEmployee(employeeId);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private void Clear()
        {
            CompanyId = 0;
            CreatedOn = DateTime.Now;
            DeletedOn = DateTime.Now;
            Email = "";
            Fax = "";
            Name = "";
            Lastlogin = DateTime.Now;
            Password = "";
            PortalId = 1;
            RoleId = 1;
            StatusId = 1;
            Telephone = "";
            UpdatedOn = DateTime.Now;
            Username = "";
        }
    }
}


