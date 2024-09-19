using PrestonWebsiteLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestonWebsiteLibrary.Models
{
    public class CardModel : ShuffleModel
    {
        public CardSuitEnum Suit { get; set; }
        public CardValueEnum Value { get; set; }
    }
}
