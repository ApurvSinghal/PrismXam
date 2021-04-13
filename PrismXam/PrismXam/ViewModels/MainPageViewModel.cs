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
            _navigationService.NavigateAsync("FirstPage");
        }

        bool CanExecuteCommandName(string parameter)
        {
            return true;
        }
    }
}
