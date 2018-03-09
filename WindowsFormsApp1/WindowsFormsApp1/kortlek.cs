using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Kortlek
    {
        private int[] hej = new int[10];
        private Kort[] korten;
        //skapar valörer
        private Valor hjarter = new Valor("Hjärter", "h", 1);
        private Valor klover = new Valor("Klöver", "c", 2);
        private Valor ruter = new Valor("Ruter", "d", 3);
        private Valor spader = new Valor("Spader", "s", 4);

        public Kortlek()
        {
            korten = new Kort[52];




            //stoppar in korten hjärter
            for (int i = 0; i < 13; i++)
            {
                korten[i] = new Kort();
                if (!((i + 1) > 9) && (i + 1) != 1) //0-9
                {
                    Korten[i].Valor = hjarter;
                    Korten[i].Namn = (i + 1).ToString();
                    Korten[i].Value = i + 1;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            Korten[i].Valor = hjarter;
                            Korten[i].Namn = "A";
                            Korten[i].Value = i + 1;
                            break;
                        case 9:
                            Korten[i].Valor = hjarter;
                            Korten[i].Namn = "T";
                            Korten[i].Value = i + 1;
                            break;

                        case 10:
                            Korten[i].Valor = hjarter;
                            Korten[i].Namn = "J";
                            Korten[i].Value = i + 1;
                            break;
                        case 11:
                            Korten[i].Valor = hjarter;
                            Korten[i].Namn = "Q";
                            Korten[i].Value = i + 1;
                            break;
                        case 12:
                            Korten[i].Valor = hjarter;
                            Korten[i].Namn = "K";
                            Korten[i].Value = i + 1;
                            break;

                    }
                }
            }
            //Klöver
            int j = 0;
            for (int i = 0; i < 13; i++)
            {
                j = 13 + i;

                korten[j] = new Kort();

                if (!((i + 1) > 9) && (i + 1) != 1) //0-9
                {
                    Korten[j].Valor = klover;
                    Korten[j].Namn = (i + 1).ToString();
                    Korten[j].Value = i + 1;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            Korten[j].Valor = klover;
                            Korten[j].Namn = "A";
                            Korten[j].Value = i + 1;
                            break;
                        case 9:
                            Korten[j].Valor = klover;
                            Korten[j].Namn = "T";
                            Korten[j].Value = i + 1;
                            break;

                        case 10:
                            Korten[j].Valor = klover;
                            Korten[j].Namn = "J";
                            Korten[j].Value = i + 1;
                            break;
                        case 11:
                            Korten[j].Valor = klover;
                            Korten[j].Namn = "Q";
                            Korten[j].Value = i + 1;
                            break;
                        case 12:
                            Korten[j].Valor = klover;
                            Korten[j].Namn = "K";
                            Korten[j].Value = i + 1;
                            break;

                    }
                }
            }
            //Ruter
            j = 0;
            for (int i = 0; i < 13; i++)
            {
                j = 26 + i;

                korten[j] = new Kort();

                if (!((i + 1) > 9) && (i + 1) != 1) //0-9
                {
                    Korten[j].Valor = ruter;
                    Korten[j].Namn = (i + 1).ToString();
                    Korten[j].Value = i + 1;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            Korten[j].Valor = ruter;
                            Korten[j].Namn = "A";
                            Korten[j].Value = i + 1;
                            break;
                        case 9:
                            Korten[j].Valor = ruter;
                            Korten[j].Namn = "T";
                            Korten[j].Value = i + 1;
                            break;

                        case 10:
                            Korten[j].Valor = ruter;
                            Korten[j].Namn = "J";
                            Korten[j].Value = i + 1;
                            break;
                        case 11:
                            Korten[j].Valor = ruter;
                            Korten[j].Namn = "Q";
                            Korten[j].Value = i + 1;
                            break;
                        case 12:
                            Korten[j].Valor = ruter;
                            Korten[j].Namn = "K";
                            Korten[j].Value = i + 1;
                            break;

                    }
                }
            }
            //spader
            j = 0;
            for (int i = 0; i < 13; i++)
            {
                j = 39 + i;

                korten[j] = new Kort();

                if (!((i + 1) > 9) && (i + 1) != 1) //0-9
                {
                    Korten[j].Valor = spader;
                    Korten[j].Namn = (i + 1).ToString();
                    Korten[j].Value = i + 1;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            Korten[j].Valor = spader;
                            Korten[j].Namn = "A";
                            Korten[j].Value = i + 1;
                            break;
                        case 9:
                            Korten[j].Valor = spader;
                            Korten[j].Namn = "T";
                            Korten[j].Value = i + 1;
                            break;

                        case 10:
                            Korten[j].Valor = spader;
                            Korten[j].Namn = "J";
                            Korten[j].Value = i + 1;
                            break;
                        case 11:
                            Korten[j].Valor = spader;
                            Korten[j].Namn = "Q";
                            Korten[j].Value = i + 1;
                            break;
                        case 12:
                            Korten[j].Valor = spader;
                            Korten[j].Namn = "K";
                            Korten[j].Value = i + 1;
                            break;

                    }
                }
            }

        }

        public void Shuffle()
        {
            Kort kort1 = new Kort();
            Kort kort2 = new Kort();
            Random r = new Random();
            int plats1 = 0;
            int plats2 = 0;

            for (int i = 0; i < 800; i++)
            {
                plats1 = r.Next(51);
                plats2 = r.Next(51);
                //byter plats på korten;
                kort1 = korten[plats1];
                kort2 = korten[plats2];
                korten[plats1] = kort2;
                korten[plats2] = kort1;
            }

        }

        public string GetCardsInDeck()
        {
            string wtf = "";
            for (int i = 0; i < 52; i++)
            {
                if (this.Korten[i].Status == "in deck")
                {
                    wtf += this.Korten[i].Namn + this.Korten[i].Valor.Namnshort;
                }
            }
            return wtf;
        }
        public Kort GetNextCardInDeck()
        {
            Kort korttoreturn = new Kort();

            for (int i = 0; i < 52; i++)
            {
                if (this.Korten[i].Status == "in deck")
                {
                    korttoreturn = korten[i];
                    korten[i].Status = "in play";
                    Console.WriteLine("Got next card"+korten[i].GetCardShortName());
                    break;
                }
            }
            return korttoreturn;
        }

        internal Kort[] Korten { get => korten; set => korten = value; }
        internal Valor Hjarter { get => hjarter; set => hjarter = value; }
    }


    class Valor
    {
        private string namn;
        private int value;
        private string namnshort;
        public Valor(string Namn, string NamnShort, int Value)
        {
            namn = Namn;
            Namnshort = NamnShort;
            value = Value;
        }
        public string Namn { get => namn; set => namn = value; }
        public int Value { get => value; set => this.value = value; }
        public string Namnshort { get => namnshort; set => namnshort = value; }
    }
    class Kort
    {
        private Valor valor = new Valor("Default", "vdef", 0);
        private int value;
        private string namn;
        private string status;
        public Kort()
        {
            value = -1;
            namn = "def";
            status = "in deck";
        }
        public int Value { get => value; set => this.value = value; }
        public string Namn { get => namn; set => namn = value; }
        public string Status { get => status; set => status = value; }
        internal Valor Valor { get => valor; set => valor = value; }
        public string GetCardShortName()
        {
            return this.Namn + this.Valor.Namnshort;
        }

    }

}
