using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.business;

namespace WhoAmI.services
{
    public interface ICharacterService
    {
        bool SaveCharacter(string firstname, string lastname);

        List<Character> GetCharacters();
    }
}
