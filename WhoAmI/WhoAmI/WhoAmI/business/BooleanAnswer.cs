using SQLite.Net.Attributes;

namespace WhoAmI.business
{
    [Table("Answer")]
    class BooleanAnswer : IAnswer
    {
        private long _id;
        private bool _value;

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

        [Column("BoolValue")]
        public bool Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public bool CheckAnswer(IAnswer answerToCheck)
        {
            BooleanAnswer toCheck = answerToCheck as BooleanAnswer;
            if (toCheck == null)
                return false;

            return Value == toCheck.Value;
        }
    }
}
