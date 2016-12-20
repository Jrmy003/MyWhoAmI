using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Diagnostics;

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

        public NewCharacterViewModel()
        {
            SaveCharacterCommand = new RelayCommand(SaveCharacter);
        }

        private void SaveCharacter()
        {
            Debug.WriteLine(string.Format("Character {0} {1} saved",_firstname, _lastname));
        }
    }
}
