/*************************EuchreDeck*********************************
*Programmers: Christine Jordan 
*Purpose: Holds all info for the euchre decks
*Inherits: Deck.cs
*Date Created: [4/25/17]
*Date Modified: [4/25/17]
*********************************************************************/
using System;
using System.Collections.Generic;
using UnityEngine;

public class EuchreDeck : Deck
{
    //The minimum rank that a card needs to be for Euchre.
    const int EUCHRE_RANK = 7;

    /************************EuchreDeck()****************************
    *In:
    *Out:
    *Description: Takes the traditional 52 card deck and makes a 
    *             Euchre deck from it by putting just the 9, 10, J,
    *             K, Q, A into the card list to be shuffled.
    ****************************************************************/
    public EuchreDeck() : base()
    {

        List<Card> temp = new List<Card>();

        temp.AddRange(cardList);
        cardList.Clear();
        deck.Clear();
        //pull the cards 9, 10 J, K, Q, A into a new list.
        foreach (Card c in temp)
        {
            if ((int)c.GetRank() >= EUCHRE_RANK)
            {
                cardList.Add(c);
            }
        }

        Shuffle(cardList);
    }
}
