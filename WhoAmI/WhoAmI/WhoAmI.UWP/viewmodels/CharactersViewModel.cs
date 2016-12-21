using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.business;

namespace WhoAmI.UWP.viewmodels
{
    class CharactersViewModel : ViewModelBase
    {
        private List<Character> _characters;

        public List<Character> Characters
        {
            get
            {
                return _characters;
            }

            set
            {
                Set(() => Characters, ref _characters, value);
            }
        }
    }
}
