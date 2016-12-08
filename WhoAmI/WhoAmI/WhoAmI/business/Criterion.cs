using SQLite.Net.Attributes;

namespace WhoAmI.business
{
    [Table("Criterion")]
    class Criterion
    {
        private long _id;
        private CriterionType _type;
        private IAnswer _answer;

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

        internal CriterionType Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        internal IAnswer Answer
        {
            get
            {
                return _answer;
            }

            set
            {
                _answer = value;
            }
        }
    }
}
