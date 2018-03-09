using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Poker
    {
        public Player player1 = new Player("Player1");
        public Player player2 = new Player("Player2");
        public Kortlek kortlek = new Kortlek();

        //delar ut korten till 2 spelare
        public Poker()
        {
           


        }
        public void  NewGame(Kortlek nyKortlek)
        {
            kortlek = nyKortlek;
            kortlek.Shuffle();
        }
        public void DealCards()
        {
            Kort[] halkort1 = new Kort[2];
            Kort[] halkort2 = new Kort[2];
            halkort1[0] = new Kort();
            halkort1[1] = new Kort();

            halkort1[0] = kortlek.GetNextCardInDeck();
            halkort1[1] = kortlek.GetNextCardInDeck();
            player1.Halkort = halkort1;

            halkort2[0] = kortlek.GetNextCardInDeck();
            halkort2[1] = kortlek.GetNextCardInDeck();
            player2.Halkort = halkort2;
        }
    }
    class Player
    {
        private string name;
        Kort[] halkort = new Kort[2];
        public Player(string Name)
        {
            this.Name = Name;
            Halkort[0] = new Kort();
            Halkort[1] = new Kort();

        }
        public string GetHoldings()
        {
            return halkort[0].GetCardShortName() + halkort[1].GetCardShortName();
        }

        public string Name { get => name; set => name = value; }
        internal Kort[] Halkort { get => halkort; set => halkort = value; }
    }
}
