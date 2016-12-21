using SQLite.Net.Attributes;
using System.Collections.Generic;

namespace WhoAmI.business
{
    [Table("Character")]
    public class Character
    {
        private long _id;
        private string _firstname;
        private string _lastname;

        List<Criterion> _citerions;

        [PrimaryKey, AutoIncrement]
        public long Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        [Column("Firstname")]
        public string Firstname
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }

        [Column("Lastname")]
        public string Lastname
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
            }
        }
    }
}
