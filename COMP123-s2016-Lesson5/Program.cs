using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson5
    {
    /**
    * This class is the "driver" class for our Program
    *
    * @class Program
    */
    public class Program
        {
        /**
        * The main method for our driver class Program
        *
        * @method Main
        * @param {string[]} args
        */
        public static void Main(string[] args)
            {
            //create a list of cards
            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
            DisplayDeck(Deck);
            }

        /** <summary>
        * This method loads a list of cards with Card objects.
        * </summary>
        *
        * @method CreateDeck
        * @param {List<Card>} deck
        * @returns {void}
        */
        public static void CreateDeck(List<Card> deck)
            {
            string suit = "";
            for (int i = 0; i < 4; i++)
                {

                switch (i)
                    {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                    }
                for (int face = 0; face < 14; face++)
                    {
                    deck.Add(new Card(face, suit));
                    }
                }
            }

        /** <summary>
        * This method displays the cards in a deck.
        * </summary>
        *
        * @method DisplayDeck
        * @params {List<Card>} deck
        * @returns {void}
        */
        public static void DisplayDeck(List<Card> deck)
            {
            Console.WriteLine("=============================================================================");
            Console.WriteLine("| Current Deck                                                              |");
            Console.WriteLine("=============================================================================");
            foreach (Card card in deck)
                {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
                }
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            }
        }
    }
