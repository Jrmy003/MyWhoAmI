using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.business;

namespace WhoAmI.game.AIs
{
    class EasyAI : IAI
    {
        private Character _choosenOne;
        private Dictionary<CriterionType, IAnswer> questionAnswers;
        public IAnswer AnswerQuestion()
        {
            throw new NotImplementedException();
        }

        public bool AnswerTry(string atry)
        {
            throw new NotImplementedException();
        }

        public CriterionType AskQuestion()
        {
            throw new NotImplementedException();
        }

        public void ChooseCharacter()
        {
            throw new NotImplementedException();
        }

        public string GiveATry()
        {
            throw new NotImplementedException();
        }
    }
}
