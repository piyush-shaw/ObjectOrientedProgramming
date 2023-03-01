using System;
namespace ObjectOrientedUsingJson.Json
{
    public class Players : InitialDeck
    {
        //Store player cards in queue
        public Queue<string> playarray = new Queue<string>();
        public static LinkedList<Players> playersLinkedList = new LinkedList<Players>();

        //Method to sort Array
        public void SortArray(Queue<string> playarray)
        {
            Console.WriteLine(" ----------DISPLAYING DECK FOR PLAYER AFTER SORTING----------");
            //Calling Swap method
            Queue<string> q2 = Swapping(playarray);
            foreach (var i in q2)
            {
                Console.WriteLine(i);

            }
        }

        public Queue<string> Swapping(Queue<string> playarray)
        {
            Char[] arr = { '2', '3', '4', '5', '6', '7', '8', '9' };
            Queue<string> q2 = new Queue<string>();
            var a = new List<string>();

            foreach (string i in playarray.OrderBy(x => x))
            {
                if (arr.Contains(i[0]))
                {
                    q2.Enqueue(i);
                }
                else
                {
                    a.Add(i);
                }
            }
            a = a.OrderBy(i => i).ToList();
            //Sort array a containing Ranks in alphabet
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if ((a[i][0] == 'K' && a[j][0] == 'Q') || (a[i][0] == 'A' && a[j][0] == 'Q') || (a[i][0] == 'A' && a[j][0] == 'J') || (a[i][0] == 'A' && a[j][0] == 'K'))
                    {
                        string tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }

            }
            foreach (var i in a)
            {
                q2.Enqueue(i);
            }
            return q2;
        }

        //Store cards for player 1
        public void player1()
        {
            int index = 1;
            Console.WriteLine("\n  ******DISPLAYING DECK FOR PLAYER 1 AFTER SHUFFLE******");
            int i = 0;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 0; j < 49; j = j + 4)
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
            Console.WriteLine("\n  ******DISPLAYING DECK FOR PLAYER 2 AFTER SHUFFLE******");
            int i = 1;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 1; j < 50; j = j + 4)
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
            Console.WriteLine("\n  ******DISPLAYING DECK FOR PLAYER 3 AFTER SHUFFLE******");
            int i = 2;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 2; j < 51; j = j + 4)
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
            Console.WriteLine("\n  ******DISPLAYING DECK FOR PLAYER 4 AFTER SHUFFLE******");
            int i = 3;
            Console.WriteLine("\n---------Player {0} Cards----------", i + 1);
            for (int j = 2; j < 52; j = j + 4)
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
        //TO PRINT CONTENT OF LIST
        public static void PlayerLinkedlist()
        {
            Console.WriteLine("\n  ******LINKED LIST CONTAINING LIST OF PLAYERS******");
            foreach (var i in playersLinkedList)
            {
                Console.WriteLine(i);
            }
        }
        //Method that creates objects for 4 players
        public static void MaintainPlayers()
        {
            Players players1 = new Players();
            players1.player1();
            players1.SortArray(players1.playarray);
            playersLinkedList.AddLast(players1);

            Players players2 = new Players();
            players2.player2();
            players2.SortArray(players2.playarray);
            playersLinkedList.AddLast(players1);


            Players players3 = new Players();
            players3.player3();
            players3.SortArray(players3.playarray);
            playersLinkedList.AddLast(players1);


            Players players4 = new Players();
            players4.player4();
            players4.SortArray(players4.playarray);
            playersLinkedList.AddLast(players1);
            PlayerLinkedlist();

        }
    }

}