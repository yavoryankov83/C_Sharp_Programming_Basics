using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine(); //read a card
            string[] faceCard = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; //declare an array foe all cards

            for (int i = 0; i < faceCard.Length - 1; i++) //take all the cards from 2 to A
            {
                if (card == faceCard[i]) //check if input card = current card and break if it is
                {
                    break;
                }
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", faceCard[i]); //print all cards from 2 to current without current
            }
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", card); //print current card outside the loop
        }
    }
}
