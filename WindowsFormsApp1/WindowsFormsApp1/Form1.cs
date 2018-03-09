﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        static int noOfPlayers = 3;
        Poker mygame = new Poker(noOfPlayers);

        public Form1()
        {
            InitializeComponent();
            label1.Text = "hejhej";

            label1.Text = mygame.kortlek.GetCardsInDeck();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            //nytt spel
            mygame.NewGame(new Kortlek());
            mygame.DealCardsToAllPlayers();
            label1.Text = mygame.kortlek.GetCardsInDeck();
            //visar players sina kort
            lblPlayer1.Text = mygame.players[0].GetHoldings();
            lblPlayer2.Text = mygame.players[1].GetHoldings();



        }
    }
}
