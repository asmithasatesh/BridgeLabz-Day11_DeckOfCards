using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class ShuffleDeck : InitialDeck
    {
        public static void ShufflingDeck()
        {
            int i;
            Random random = new Random();
            for (i = 0; i < totalCards; i++)
            {
                int temp = random.Next(0, totalCards);
                deck = SwapCharacters(deck, temp, i);

            }

            //Console.WriteLine("\n  ***************DISPLAYING DECK AFTER SHUFFLE***************");
            //string[,] distributeDeck = new string[9, 4];
            //for (i = 0; i < 9; i++)
            //{

            //    for (j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine("PLAYER -> {0}", j + 1);
            //        distributeDeck[i, j] = deck[index];
            //        Console.WriteLine("CARD -> Card {0}", distributeDeck[i, j]);
            //        index++;
            //    }
            //    Console.WriteLine("\n");


            //}
        }
        static string[] SwapCharacters(string[] array, int position1, int position2)
        {

            string temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
            return (array);
        }

    }
}
