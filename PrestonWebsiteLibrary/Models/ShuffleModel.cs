using PrestonWebsiteLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestonWebsiteLibrary.Models
{
    public abstract class ShuffleModel
    {
        public CardSuitEnum GetRandomSuit(Random random)
        {
            int enumCount = Enum.GetValues(typeof(CardSuitEnum)).Length;
            int randomIndex = random.Next(0, enumCount);
            CardSuitEnum suitValue = (CardSuitEnum)randomIndex;
            return suitValue;
        }

        public CardValueEnum GetRandomValue(Random random)
        {
            int enumCount = Enum.GetValues(typeof(CardValueEnum)).Length;
            int randomIndex = random.Next(1, enumCount);
            CardValueEnum cardValue = (CardValueEnum)randomIndex;
            return cardValue;
        }
    }
}
