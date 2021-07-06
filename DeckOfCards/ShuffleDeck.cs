using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    /// <summary>
    /// Day11- Program 8 and program 9 Executed using queue to shuffle a deck of cards and distribute 9 cards to 4 players
    /// </summary>
    /// <seealso cref="DeckOfCards.InitialDeck" />
    class ShuffleDeck : InitialDeck
    {
        public static void ShufflingDeck()
        {
            //Shuffling deck based on Random method
            int i;
            Random random = new Random();
            for (i = 0; i < totalCards; i++)
            {
                int temp = random.Next(0, totalCards);
                deck = SwapCharacters(deck, temp, i);

            }

        }
        static string[] SwapCharacters(string[] array, int position1, int position2)
        {
            //Swap two index in array
            string temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
            return (array);
        }

    }
}
