using SQLite.Net.Attributes;
using System.Collections.Generic;

namespace WhoAmI.business
{
    [Table("CriterionType")]
    class CriterionType
    {
        private long _id;
        private string _name;
        private List<IAnswer> _possibleAnswers;

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

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        internal List<IAnswer> PossibleAnswers
        {
            get
            {
                return _possibleAnswers;
            }

            set
            {
                _possibleAnswers = value;
            }
        }
    }
}
