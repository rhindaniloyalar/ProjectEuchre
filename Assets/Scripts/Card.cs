/***************************Card.cs***********************************
*Programmers: Christine Jordan
*Purpose: Creates a standard playing card based on an integer passed
          to the constructor.
*Inherits: None
*Date Created: [4/25/16]
*Date Modified: [4/25/16]
*********************************************************************/
using System.Collections;

public class Card
{
	private readonly Suit suit;
    private readonly Rank rank;
    
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    };

    public enum Rank
    {
       Two,
       Three,
       Four,
       Five,
       Six,
       Seven,
       Eight,
       Nine,
       Ten,
       Jack,
       King,
       Queen,
       Ace
    };

    /************************FunctionName()*************************
    *In: number to convert to suit/rank of card
    *Out:
    *Description: Takes a number and typecasts the division by 13 to
    *             the card's suit, and the num % 13 to the card's 
    *             rank.               
    ****************************************************************/
    public Card(int num)
    {
        suit = (Suit)(num / 13);
        rank = (Rank)(num % 13);
    }

	public Suit GetSuit()
	{
	    return suit;
	}

    public Rank GetRank()
    {
        return rank;
    }

    public int ToNumber()
    {
        return (int)suit * 13 + ((int)rank - 1);
    }
}
