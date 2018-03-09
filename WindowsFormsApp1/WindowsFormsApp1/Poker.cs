using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Poker
    {
       
        public List<Player> players = new List<Player>();
        public Kortlek kortlek = new Kortlek();

       
        //Konstruktor
        public Poker(int noOfPlayers)
        {
            for (int i = 0; i < noOfPlayers; i++)
            {
                Player player = new Player("Player" + (i + 1).ToString());
                players.Add(player);
            }
        }
        public void NewGame(Kortlek nyKortlek)
        {
            kortlek = nyKortlek;
            kortlek.Shuffle();
        }

        public void DealCardsToAllPlayers()
        {
            //tar reda på hur många spelare som finns
            for (int i = 0; i < players.Count(); i++)
            {
                DealCards(i);
            }
        }
        private void DealCards(int toPlayer)
        {
            Kort[] halkort = new Kort[2];
            halkort[0] = new Kort();
            halkort[1] = new Kort();
            halkort[0] = kortlek.GetNextCardInDeck();
            halkort[1] = kortlek.GetNextCardInDeck();

            players.ElementAt(toPlayer).Halkort = halkort;
        }
       
    }
    class Player
    {
        private string name;
        Kort[] halkort = new Kort[2];
        public Player()
        {

        }
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
