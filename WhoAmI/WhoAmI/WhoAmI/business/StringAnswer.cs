using SQLite.Net.Attributes;
using System;

namespace WhoAmI.business
{
    [Table("Answer")]
    class StringAnswer : IAnswer
    {
        private long _id;

        private string _value;

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

        [Column("StringValue")]
        public string Value
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
            StringAnswer toCheck = answerToCheck as StringAnswer;
            if (toCheck == null)
                return false;
            if (Value == null)
                throw new ArgumentNullException("StringAnswer.this._value");

            if (toCheck.Value == null)
                throw new ArgumentNullException("StringAnswer.toCheck._value");

            return Value.Trim().ToLower() == toCheck.Value.Trim().ToLower();
        }
    }
}
