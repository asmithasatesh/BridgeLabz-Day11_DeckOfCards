using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckOfCards
{
    class Players : InitialDeck
    {
        //Store player cards in queue
        public Queue<string> playarray = new Queue<string>();

        //Method to sort Array
        public void SortArray(Queue<string> playarray)
        {
            Console.WriteLine(" ----------DISPLAYING DECK FOR PLAYER AFTER SORTING----------");

            Queue<string> orderedQueue = new Queue<string>(playarray.OrderBy(z => z));
            foreach (var i in orderedQueue)
            {
                Console.WriteLine(i);
            }

        }

        //Store cards for player 1
        public void player1()
        {
            int index = 1;
            Console.WriteLine("\n  ***************DISPLAYING DECK FOR PLAYER 1 AFTER SHUFFLE***************");
            int i = 0;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 0; j < 45; j = j + 4)
            {
                if (index != 10)
                {
                    Console.WriteLine("CARD ->  {0}", index);
                    playarray.Enqueue(deck[j]);
                    Console.WriteLine("{0}", deck[j]);
                    index++;
                }

            }
            Console.WriteLine("\n");

        }
        //Store cards for player 2
        void player2()
        {
            int index = 1;
            Console.WriteLine("\n  ***************DISPLAYING DECK FOR PLAYER 2 AFTER SHUFFLE***************");
            int i = 1;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 1; j < 46; j = j + 4)
            {
                if (index != 10)
                {
                    Console.WriteLine("CARD -> {0}", index);
                    playarray.Enqueue(deck[j]);
                    Console.WriteLine("{0}", deck[j]);
                    index++;
                }

            }
            Console.WriteLine("\n");

        }
        //Store cards for player 3
        void player3()
        {
            int index = 1;
            Console.WriteLine("\n  ***************DISPLAYING DECK FOR PLAYER 3 AFTER SHUFFLE***************");
            int i = 2;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 2; j < 47; j = j + 4)
            {
                if (index != 10)
                {
                    Console.WriteLine("CARD -> {0}", index);
                    playarray.Enqueue(deck[j]);
                    Console.WriteLine("{0}", deck[j]);
                    index++;
                }


            }
            Console.WriteLine("\n");

        }
        //Store cards for player 4
        void player4()
        {
            int index = 1;
            Console.WriteLine("\n  ***************DISPLAYING DECK FOR PLAYER 4 AFTER SHUFFLE***************");
            int i = 3;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 2; j < 48; j = j + 4)
            {
                if (index != 10)
                {
                    Console.WriteLine("CARD -> {0}", index);
                    playarray.Enqueue(deck[j]);
                    Console.WriteLine("{0}", deck[j]);
                    index++;
                }

            }
            Console.WriteLine("\n");

        }
        //Method that creates objects for 4 players
        public static void MaintainPlayers()
        {
            Players players1 = new Players();
            players1.player1();
            players1.SortArray(players1.playarray);

            Players players2 = new Players();
            players2.player2();
            players2.SortArray(players2.playarray);

            Players players3 = new Players();
            players3.player3();
            players3.SortArray(players3.playarray);

            Players players4 = new Players();
            players4.player4();
            players4.SortArray(players4.playarray);
        }
    }
}
