using EmployeesXamarin.Models;
using EmployeesXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmployeesXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeePage : ContentPage
    {
        EmployeeViewModel context = new EmployeeViewModel();

        public EmployeePage()
        {
            InitializeComponent();
            BindingContext = context;
            lvEmployee.ItemSelected += LvEmployee_ItemSelected;
        }

        private void LvEmployee_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) 
            {
                Employee model = (Employee)e.SelectedItem;
                context.Name = model.Name;
                context.Email = model.Email;
                context.Fax = model.Fax;
                context.Telephone = model.Telephone;
            }
        }
    }
}