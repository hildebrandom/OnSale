using OnSale.Prism.Helpers;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Prism.ViewModels
{
    public class ModifyUserPageViewModel : ViewModelBase
    {
        public ModifyUserPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = Languages.ModifyUser;
        }
    }
}
