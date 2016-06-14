using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson5
    {

    /**<summary>
    * This class extends the List<Card> generic type.
    * </summary>
    *
    * @Class Deck
    * @extends List<Card>
    */
    class Deck : List<Card>
        {

        // PRIVATE INSTANCE VARIABLES ==================================================================

        // PUBLIC PROPERTIES ==================================================================

        // CONSTRUCTORS ==================================================================

            /** <summary>
            * This is the default constructor for the Deck class
            * </summary>
            *
            * @constructor Deck
            */
        public Deck()
            {
            // create my deck of cards
            this._create();
            }

        // PRIVATE METHODS ==================================================================

        /** <summary>
        * This method loads a list of cards with Card objects.
        * </summary>
        *
        * @private
        * @method _create
        * @returns {void}
        */
        public void _create()
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
                    this.Add(new Card(face, suit));
                    }
                }
            }

        // PUBLIC METHODS ==================================================================

        /** <summary>
        * This method displays a list of Card objects to the console.
        * </summary>
        *
        * @method Display
        * @returns {void}
        */
        public void Display()
            {
            Console.WriteLine("=============================================================================");
            Console.WriteLine("| Current Deck                                                              |");
            Console.WriteLine("=============================================================================");
            foreach (Card card in this)
                {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
                }
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            }

        /** <summary>
        * This method randomly shuffles a List of Card objects.
        * </summary>
        * 
        * @method Shuffle
        * @returns {void}
        */
        public void Shuffle()
            {
            // creates a pseudo-random number sequence and stores it in random
            Random random = new Random();
            // record the number of cards in the deck List
            int cardCount = this.Count;
            // iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
                {
                Card tempCard = this[currentCard]; // copy current card to temp location
                int randomCard = random.Next(0, cardCount); // get a random index
                this[currentCard] = this[randomCard]; // copy value from randomCard to currentCard
                this[randomCard] = tempCard; // copy current card to random card location
                }
            }
        }
    }
