using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WhoAmI.UWP.viewmodels
{
    class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public ICommand NewCharacterCommand
        {
            get; private set;
        }
        public ICommand CharactersCommand
        {
            get; private set;
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NewCharacterCommand = new RelayCommand(() => ShowNewCharacterView());
            CharactersCommand = new RelayCommand(() => ShowCharactersView());
        }

        private void ShowNewCharacterView()
        {
            _navigationService.NavigateTo("NewCharacterView");
        }

        private void ShowCharactersView()
        {
            _navigationService.NavigateTo("CharactersView");
        }
    }
}
