using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson5
    {

    /** <summary>
    * This is class defines a card.
    * </summary>
    *
    * @class Card
    * @field {int} _face
    * @field {string} _suit
    */
    public class Card
        {

        // PRIVATE INSTANCE VARIABLES =============================================================================



        // PUBLIC PROPERTIES =============================================================================

        /** <summary>
        * This is a property for our _face field.
        * </summary>
        *
        * @property {string} Face
        */
        public int Face { get; set; }

        /** <summary>
        * This is a property for our _suit field.
        * </summary>
        *
        * @property {string} Suit
        */
        public string Suit { get; set; }

        // CONSTRUCTORS =============================================================================

        /** <summary>
        * This constructor takes two parameters: face and suit.
        * </summary>
        *
        * @constructor Card
        * @param {int} face
        * @param {string} suit
        */
        public Card(int face, string suit)
            {
            this.Face = face;
            this.Suit = suit;
            }

        // PRIVATE METHODS =============================================================================




        // PUBLIC METHODS =============================================================================

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
