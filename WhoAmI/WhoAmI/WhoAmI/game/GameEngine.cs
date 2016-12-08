using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.business;
using WhoAmI.game.AIs;

namespace WhoAmI
{
    class GameEngine
    {
        public void Play()
        {
            IAI p1 = new EasyAI();
            IAI p2 = new EasyAI();

            CriterionType height = new CriterionType() { Name = "" };
            CriterionType weight = new CriterionType() { Name = "" };
            CriterionType kind = new CriterionType() { Name = "" };
            CriterionType color = new CriterionType() { Name = "" };
            CriterionType sexe = new CriterionType() { Name = "" };
            CriterionType dead = new CriterionType() { Name = "" };
            CriterionType hero = new CriterionType() { Name = "" };
            CriterionType vilain = new CriterionType() { Name = "" };

        }
    }
}
