using EmployeesXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

namespace EmployeesXamarin.Services
{
    public class EmlpoyeeService
    {
        private string getEmployees = "https://localhost:44316/api/Employee/GetAllEmployees";
        private string insertEmployee = "https://localhost:44316/api/Employee/CreateEmployee";
        private string deleteEmployee = "https://localhost:44316/api/Employee/DeleteEmployee/";
        private string updateEmployee = "https://localhost:44316/api/Employee/UpdateEmployee/";
        HttpClient cliente = new HttpClient();
        public ObservableCollection<Employee> employee { get; set; }

        public EmlpoyeeService()
        {
            if (employee == null)
            {
                employee = new ObservableCollection<Employee>();
            }
        }

        public ObservableCollection<Employee> GetEmployees()
        {
            return employee;
        }

        //public async Task<List<Employee>> GetEmployees()
        //{
        //    string contenido = await cliente.GetStringAsync(getEmployees);
        //    IEnumerable<Employee> employee = JsonConvert.DeserializeObject<IEnumerable<Employee>>(contenido);
        //    return (List<Employee>)employee;
        //}

        public async void InsertEmployee(Employee employeeModel)
        {
            string employeeJson = JsonConvert.SerializeObject(employeeModel);
            StringContent body = new StringContent(employeeJson, Encoding.UTF8, "application/json");
            var contenido = await cliente.PostAsync(insertEmployee, body);            
        }

        public async void UpdateEmployee(int employeeId, string userName)
        {
            string contenido = await cliente.GetStringAsync(updateEmployee+employeeId+"/"+userName);
            IEnumerable<Employee> lista = JsonConvert.DeserializeObject<IEnumerable<Employee>>(contenido);
        }

        public async void DeleteEmployee(int idEmployee)
        {
            string contenido = await cliente.GetStringAsync(deleteEmployee+idEmployee);
            IEnumerable<Employee> lista = JsonConvert.DeserializeObject<IEnumerable<Employee>>(contenido);    
        }
    }
}
