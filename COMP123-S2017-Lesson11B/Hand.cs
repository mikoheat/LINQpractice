using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
            // this method is empty
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        public void HighestCards()
        {
            var Cards = from card in this orderby card.Face descending select card;

            Console.WriteLine("Highest cards in your hands:");

            foreach(var card in Cards)
            {
                Console.WriteLine("The " + card.Face + " of " + card.Suit + "\n");
            }
        }
    }
}