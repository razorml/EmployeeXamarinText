using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeesXamarin.Models
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy = false; }
            set
            {
                isBusy = value;
                OnPropertyChange();
            }
        }
        public int employeeId;
        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                employeeId = value;
                OnPropertyChange();
            }
        }
        public int companyId;
        public int CompanyId
        {
            get { return companyId; }
            set
            {
                companyId = value;
                OnPropertyChange();
            }
        }
        public DateTime createdOn;
        public DateTime CreatedOn
        {
            get { return createdOn; }
            set
            {
                createdOn = value;
                OnPropertyChange();
            }
        }
        public DateTime deletedOn;
        public DateTime DeletedOn
        {
            get { return deletedOn; }
            set
            {
                deletedOn = value;
                OnPropertyChange();
            }
        }
        public string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChange();
            }
        }
        public string fax;
        public string Fax
        {
            get { return fax; }
            set
            {
                fax = value;
                OnPropertyChange();
            }
        }
        public string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChange();
            }
        }
        public DateTime lastlogin;
        public DateTime Lastlogin
        {
            get { return lastlogin; }
            set
            {
                lastlogin = value;
                OnPropertyChange();
            }
        }
        public string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChange();
            }
        }
        public int portalId { get; set; }
        public int PortalId
        {
            get { return portalId; }
            set
            {
                portalId = value;
                OnPropertyChange();
            }
        }
        public int roleId;
        public int RoleId
        {
            get { return roleId; }
            set
            {
                roleId = value;
                OnPropertyChange();
            }
        }
        public int statusId;
        public int StatusId
        {
            get { return statusId; }
            set
            {
                statusId = value;
                OnPropertyChange();
            }
        }
        public string telephone { get; set; }
        public string Telephone
        {
            get { return telephone; }
            set
            {
                telephone = value;
                OnPropertyChange();
            }
        }
        public DateTime updatedOn;
        public DateTime UpdatedOn
        {
            get { return updatedOn; }
            set
            {
                updatedOn = value;
                OnPropertyChange();
            }
        }
        public string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChange();
            }
        }       
    }
}
