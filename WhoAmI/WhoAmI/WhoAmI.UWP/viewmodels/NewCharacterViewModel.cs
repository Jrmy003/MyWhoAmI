using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Diagnostics;
using WhoAmI.services;
using WhoAmI.helpers;

namespace WhoAmI.UWP.viewmodels
{
    class NewCharacterViewModel : ViewModelBase
    {
        private string _firstname;
        private string _lastname;

        public string Firstname
        {
            get
            {
                return _firstname;
            }

            set
            {
                Set(() => Firstname, ref _firstname, value);
            }
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }

            set
            {
                Set(() => Lastname, ref _lastname, value);
            }
        }

        public ICommand SaveCharacterCommand
        {
            get;
            private set;
        }

        public ICommand ResetCharacterCommand
        {
            get;
            private set;
        }

        public NewCharacterViewModel()
        {
            Firstname = string.Empty;
            Lastname = string.Empty;
            SaveCharacterCommand = new RelayCommand(SaveCharacter);
            ResetCharacterCommand = new RelayCommand(Reset);
        }

        private void SaveCharacter()
        {
            var service = ServiceContainer.Resolve<ICharacterService>();
            service.SaveCharacter(_firstname, _lastname);
            Reset();
        }

        private void Reset()
        {
            Firstname = string.Empty;
            Lastname = string.Empty;
        }
    }
}
