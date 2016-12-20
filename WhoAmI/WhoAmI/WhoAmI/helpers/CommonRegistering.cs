using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.helpers;
using WhoAmI.services;

namespace WhoAmI.helpers
{
    public class CommonRegistering
    {
        public static void RegisterCommonDependencies()
        {
            ServiceContainer.Register<ICharacterService>(() => new CharacterService());
        }
    }
}
