﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAmI.services
{
    interface ICharacterService
    {
        bool SaveCharacter(string firstname, string lastname);
    }
}
