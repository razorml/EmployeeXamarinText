using EmployeesXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EmployeesXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}