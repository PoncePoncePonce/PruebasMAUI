using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasMAUI.Models.ViewModels
{
    internal partial class EmployeeDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private Employee employee;
    }
}
