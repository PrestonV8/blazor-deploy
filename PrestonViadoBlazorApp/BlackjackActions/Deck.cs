using PrestonWebsiteLibrary.Models;

namespace PrestonViadoBlazorApp.BlackjackActions
{
    public abstract class Deck : CardModel
    {
        List<string> cards = new List<string>();
        public int Total { get; set; } = 0;
        public string? Name { get; set; }
        public void CreateDeck(Random rnd)
        {
            for (int i = 0; i < 2; i++)
            {
                Suit = GetRandomSuit(rnd);
                Value = GetRandomValue(rnd);
                cards.Add($"{Value} of {Suit}");
                Total = Total + (int)Value;
            }
        }

        public virtual string ShowDeck()
        {
            string deckMessage = "";

            // read each card in in the deck
            foreach (string card in cards)
            {
                deckMessage += $"{card}\n";
            }

            // calculate summary of player/dealer hand
            deckMessage += $"[{Name}'s Hand Total: {Total}]\n";

            return deckMessage;
        }

        public virtual void AddCard(Random rnd)
        {
            Suit = GetRandomSuit(rnd);
            Value = GetRandomValue(rnd);
            cards.Add($"+{Value} of {Suit} was added");
            Total = Total + (int)Value;
        }
    }
}
