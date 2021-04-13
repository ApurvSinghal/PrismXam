using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismXam.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            _navigationService = navigationService;
        }

        private DelegateCommand<string> _fieldName;
        public DelegateCommand<string> CommandName =>
            _fieldName ?? (_fieldName = new DelegateCommand<string>(ExecuteCommandName, CanExecuteCommandName));

        void ExecuteCommandName(string parameter)
        {
            //One way of passing Navigation Parameters
            var p = new NavigationParameters();
            p.Add("FirstName", "Apurv");
            p.Add("LastName", "Singhal");

            //Another way of passing Navigation Parameters
            var p2 = new NavigationParameters("FirstName=Apurv&SecondName=Singhal");

            //Another way of passing Navigation Parameters
            //_navigationService.NavigateAsync("FirstPage?FirstName=Apurv&SecondName=Singhal");

            _navigationService.NavigateAsync("FirstPage", p);
        }

        bool CanExecuteCommandName(string parameter)
        {
            return true;
        }
    }
}
