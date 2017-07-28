﻿using System;
using System.Collections.Generic;
using System.Linq;//LINQ
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Taeho Kim
/// Date: July, 25, 2017
/// Description: This is the
/// Version: 0.4 - Tested the new Deck class
/// </summary>
namespace COMP123_S2017_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            Console.WriteLine();
            Console.WriteLine(deck.ToString());

            Console.WriteLine();
            hand = deck.Deal5(); // moves the top 5 cards from the deck to the hand object
            Console.WriteLine(hand.ToString());

            Console.WriteLine();

            hand.HighestCards();
        }
    }
}
