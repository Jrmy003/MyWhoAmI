using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.services.interfaces;

namespace WhoAmI.services
{
    public class CharacterService : ICharacterService
    {
        public bool SaveCharacter(string firstname, string lastname)
        {
            return true;
        }
    }
}
