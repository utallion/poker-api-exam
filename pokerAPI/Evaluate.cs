﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{
    public class Evaluate
    {
        Player player;

        int hightcard;
        int diamond=0;
        int spade=0;
        int heart=0;
        int clover=0;


        public Evaluate(Player p) {
            player = p;
            getSuitCount();
            FourOfAKind();
            FullHouse();
            Straight();
            Flush();
        }

        public void getSuitCount() {
            for (int i = 0; i < 5; i++) {
                if (player.playerCard[i]._suit == "D")
                {
                    diamond++;
                }
                else if (player.playerCard[i]._suit == "S")
                {
                    spade++;
                }
                else if (player.playerCard[i]._suit == "H")
                {
                    heart++;
                }
                else {
                    clover++;
                }
            }
        }

        //Four Of A Kind
        public bool FourOfAKind() {

            if (player.playerCard[0]._rank == player.playerCard[1]._rank && player.playerCard[1]._rank == player.playerCard[2]._rank
                && player.playerCard[2]._rank == player.playerCard[3]._rank)
            {
                Console.WriteLine(player.playerName + ": {0} {1} {2} {3} {4} (Four Of A Kind)",
                        player.playerCard[0]._rank + player.playerCard[0]._suit,
                        player.playerCard[1]._rank + player.playerCard[1]._suit,
                        player.playerCard[2]._rank + player.playerCard[2]._suit,
                        player.playerCard[3]._rank + player.playerCard[3]._suit,
                        player.playerCard[4]._rank + player.playerCard[4]._suit
                        );

                hightcard = player.playerCard[4]._rank;

                return true;
            }
            else if (player.playerCard[1]._rank == player.playerCard[2]._rank && player.playerCard[2]._rank == player.playerCard[3]._rank
                && player.playerCard[3]._rank == player.playerCard[4]._rank) {

                Console.WriteLine(player.playerName + ": {0} {1} {2} {3} {4} (Four Of A Kind)",
                     player.playerCard[0]._rank + player.playerCard[0]._suit,
                     player.playerCard[1]._rank + player.playerCard[1]._suit,
                     player.playerCard[2]._rank + player.playerCard[2]._suit,
                     player.playerCard[3]._rank + player.playerCard[3]._suit,
                     player.playerCard[4]._rank + player.playerCard[4]._suit
                     );
                hightcard = player.playerCard[0]._rank;
                return true;

            }
            else {
                return false;
            }
        }


        //Full House
        public bool FullHouse() {

            if ((player.playerCard[0]._rank == player.playerCard[1]._rank &&
                player.playerCard[1]._rank == player.playerCard[2]._rank &&
                player.playerCard[3]._rank == player.playerCard[4]._rank)
                ||
                (player.playerCard[0]._rank == player.playerCard[1]._rank &&
                player.playerCard[2]._rank == player.playerCard[3]._rank &&
                player.playerCard[3]._rank == player.playerCard[4]._rank)
                )
            {

                Console.WriteLine(player.playerName + ": {0} {1} {2} {3} {4} (Full House)",
                     player.playerCard[0]._rank + player.playerCard[0]._suit,
                     player.playerCard[1]._rank + player.playerCard[1]._suit,
                     player.playerCard[2]._rank + player.playerCard[2]._suit,
                     player.playerCard[3]._rank + player.playerCard[3]._suit,
                     player.playerCard[4]._rank + player.playerCard[4]._suit
                     );

                return true;
            }
            else {
                return false;
            }

           

        }


        //Stringht
        public bool Straight() {
            int _root = player.playerCard[0]._rank;
            int i;
            for (i = 1; i < 4; i++) {
                _root++;
                if (player.playerCard[i]._rank == _root)
                {

                }
                else {  
                    return false;
                }

            }

            if (i == 4)
            {

                Console.WriteLine(player.playerName + ": {0} {1} {2} {3} {4} (Straight)",
                   player.playerCard[0]._rank + player.playerCard[0]._suit,
                   player.playerCard[1]._rank + player.playerCard[1]._suit,
                   player.playerCard[2]._rank + player.playerCard[2]._suit,
                   player.playerCard[3]._rank + player.playerCard[3]._suit,
                   player.playerCard[4]._rank + player.playerCard[4]._suit
                   );

                return true;
            }
            else {
                return false;
            }

           
        }


        //Flush
        public bool Flush() {
            if (diamond == 5 || heart == 5 || spade == 5 || clover == 5)
            {
                Console.WriteLine(player.playerName + ": {0} {1} {2} {3} {4} (Flush)",
                 player.playerCard[0]._rank + player.playerCard[0]._suit,
                 player.playerCard[1]._rank + player.playerCard[1]._suit,
                 player.playerCard[2]._rank + player.playerCard[2]._suit,
                 player.playerCard[3]._rank + player.playerCard[3]._suit,
                 player.playerCard[4]._rank + player.playerCard[4]._suit
                 );
                return true;
            }
            else {
                return false;
            }
           

        }



    }
}
