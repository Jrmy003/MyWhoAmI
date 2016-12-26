using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
        public ICommand NewCharacterCommand
        {
            get; private set;
        }
        public ICommand CharactersCommand
        {
            get; private set;
        }

        public MainPageViewModel()
        {
            NewCharacterCommand = new RelayCommand(() => ShowNewCharacterView());
            CharactersCommand = new RelayCommand(() => ShowCharactersView());
        }

        private void ShowNewCharacterView()
        {

        }

        private void ShowCharactersView()
        {

        }
    }
}
