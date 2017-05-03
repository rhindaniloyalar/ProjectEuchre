/****************************Deck.cs********************************
*Programmers: Christine Jordan
*Purpose: Houses the deck of cards and all funtions pertaining to
*Inherits: 
*Date Created: [4/24/17]
*Date Modified: [4/24/17] 
*********************************************************************/
using System.Collections.Generic;
using UnityEngine;


public class Deck
{
    protected const int NUM_CARDS = 52;
    protected Stack<Card> deck = new Stack<Card>();
    //can't shuffle a stack, so we need a list.
    protected List<Card> cardList = new List<Card>();
	
    /****************************Deck()*****************************
    *In:
    *Out:
    *Description
    ****************************************************************/
    public Deck ()
    {
        Card newCard;
       
        for (int i = 0; i < NUM_CARDS; ++i)
        {
            newCard = new Card(i);
            cardList.Add(newCard);
        }

        Shuffle(cardList);
    }


    /****************************Deck()*****************************
    *In:
    *Out:
    *Description
    ****************************************************************/
    protected void Shuffle(List<Card> l)
    {
        for (int i = 0; i < l.Count; ++i)
        {
            int rand = Random.Range(i, l.Count);
            Card temp = l[rand];
            l[rand] = l[i];
            l[i] = temp;
        }
        
        //we'll push the deck onto the stack from the last
        //element of the array to the first so that the first
        //card delt is that of the 0th array index
        for(int i = l.Count-1; i <=0; --i)
        {
            deck.Push(l[i]);
        }
    }

    public void DebugDeck()
    {
        for (int i = 0; i < deck.Count; ++i)
        {
            Card card = deck.Pop();
            Debug.Log(card);
        }
    }
}
