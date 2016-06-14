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
            Deck deck = new Deck();

            deck.Display(); 

            deck.Shuffle();
            deck.Display();

            Card cardDealt = deck.Deal();
            Console.WriteLine("Card dealt is {0} of {1}", cardDealt.Face, cardDealt.Suit);
            }
        }
    }
