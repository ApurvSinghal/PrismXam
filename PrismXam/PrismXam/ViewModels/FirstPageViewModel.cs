using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismXam.ViewModels
{
    public class FirstPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public FirstPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "First Page";
            _navigationService = navigationService;
        }

        private DelegateCommand _back;
        public DelegateCommand BackCommand =>
            _back ?? (_back = new DelegateCommand(ExecuteBackCommand, CanExecuteBackCommand));

        void ExecuteBackCommand()
        {
            _navigationService.NavigateAsync("/NavigationPage/MainPage");
        }

        bool CanExecuteBackCommand()
        {
            return true;
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            //base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

            Title = parameters.GetValue<string>("FirstName");
            //base.OnNavigatedTo(parameters);
        }
    }
}
