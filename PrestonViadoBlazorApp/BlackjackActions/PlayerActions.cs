namespace PrestonViadoBlazorApp.BlackjackActions
{
    public class PlayerActions : Deck
    {
        bool outcome = true;

        public virtual string InitializeGame(PlayerActions dealer, string messageUI)
        {
            var rnd = new Random();

            // initialize dealer and player with a few cards
            dealer.AddCard(rnd);
            CreateDeck(rnd);

            messageUI += "DEALER DECK:\n" + dealer.ShowDeck() + "\n";
            messageUI += "PLAYER DECK:\n" + ShowDeck();
            return messageUI;
        }

        public virtual string HitAction(PlayerActions dealer)
        {
            var rnd = new Random();

            string newMessage = "";

            AddCard(rnd);

            newMessage += "DEALER DECK:\n" + dealer.ShowDeck() + "\n";
            newMessage += "PLAYER DECK:\n" + ShowDeck(); // show deck status after adding a card to player's deck
            return newMessage;
        }

        public virtual string StandAction(PlayerActions dealer)
        {
            var rnd = new Random();
            string newMessage = "";

            // Dealer's Turn 
            while (dealer.Total < 17)
            {
                dealer.AddCard(rnd);
            }

            newMessage += "DEALER DECK:\n" + dealer.ShowDeck() + "\n";
            newMessage += "PLAYER DECK:\n" + ShowDeck();
            return newMessage;
        }

        // method performed after a player adds a card
        public virtual int CheckDeck()
        {
            int endGameType = 2; // player will continue game with this value

            if (Total > 21) // player loses if over 21 
            {
                endGameType = 0;
            }
            else if (Total == 21) // player automatically wins for exact value of 21
            {
                endGameType = 1;
            }

            return endGameType;
        }

        // method to calculate and compare the decks to product a game outcome
        public virtual string CheckOutcome(PlayerActions dealer)
        {
            string resultString = "ERROR at CheckOutcome";

            // Lose: 
            if ((Total == 21 && dealer.Total == 21) || Total == dealer.Total || (Total > 21 && dealer.Total > 21))
            {
                resultString = "\n...DRAW...\nTo play again, select \"Start\"";
            }
            else if (Total > 21 || (Total < dealer.Total && dealer.Total <= 21))
            {
                resultString = "\nYou Lose...\nTo play again, select \"Start\"";
            }
            else if ((Total <= 21 && Total > dealer.Total) || Total == 21 || dealer.Total > 21)
            {
                resultString = "\nYou Win!!!\nTo play again, select \"Start\"";
            }

            return resultString;
        }

        // Testing from git push from new PC
        // Hello from the other side!!!
    }
}
