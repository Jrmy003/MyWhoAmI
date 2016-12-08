using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.business;

namespace WhoAmI.game.AIs
{
    interface IAI
    {
        CriterionType AskQuestion();
        IAnswer AnswerQuestion();
        string GiveATry();
        bool AnswerTry(string atry);
        void ChooseCharacter();
    }
}
