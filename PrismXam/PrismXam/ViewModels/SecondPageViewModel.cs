using System;
using Prism.Navigation;
using Prism.Services;

namespace PrismXam.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _dialogService;

        public SecondPageViewModel(INavigationService navigationService,
            IPageDialogService dialogService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;

            _dialogService.DisplayAlertAsync("Title", "Hello, from Second Page", "Okay");

        }

        private string _pageHeading = "Second Page";
        public string PageHeading
        {
            get
            {
                return _pageHeading;
            }
            set
            {
                SetProperty(ref _pageHeading, value);
            }
        }
    }
}
