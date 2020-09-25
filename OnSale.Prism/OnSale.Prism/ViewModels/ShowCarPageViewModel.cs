using OnSale.Prism.Helpers;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Prism.ViewModels
{
    public class ShowCarPageViewModel : ViewModelBase
    {
        public ShowCarPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Title = Languages.ShowShoppingCar;
        }                 
    }
}
