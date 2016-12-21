using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.data;
using WhoAmI.helpers;
using WhoAmI.services;
using SQLite.Net;
using WhoAmI.business;

namespace WhoAmI.services
{
    public class CharacterService : ICharacterService
    {
        private SQLiteConnection db;
        public CharacterService()
        {
            db = ServiceContainer.Resolve<ISQLiteConnectionPovider>().GetConnection();
        }

        public bool SaveCharacter(string firstname, string lastname)
        {
            db.Insert(new Character { Firstname = firstname, Lastname = lastname });
            return true;
        }
    }
}
