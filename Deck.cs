using System;
using System.Collections.Generic;

namespace examination_3
{


    public class DeckofCards
    {

  public List<Cards> oldCards = new List<Cards>();
	public List<Cards> cards = new List<Cards>();
	public List <Cards> FillDeck()
	{
    
    for (int i = 0; i < Enum.GetNames(typeof(suit)).Length; i++) {
      for (int x = 2; x < Enum.GetNames(typeof(CardValue)).Length + 2; x++) 
			cards.Add(new Cards((suit)i, (CardValue)x));
      } 
      return cards;
    }

     static Random _random = new Random();
    public Cards Shuffle()
    {
      GetCard();
        int n = cards.Count;
        for (int i = 0; i < (n - 1); i++)
        {
            int r = i + _random.Next(n - i);
            Cards t = cards[r];
            cards[r] = cards[i];
            cards[i] = t;
        }   
        return cards[0];
    }

public void GetCard () {
    if (cards.Count <= 1) {
      foreach(Cards card in oldCards)  
    {
      cards.Add(card);
    };
      oldCards.Clear();
    }
    
  }

  public void removeUsedCards () 
  {
    cards.RemoveAt(0);

  }
  public void throwCards(Player player) {

    foreach(Cards card in player.hand)  
    {
      oldCards.Add(card);
    };
    Console.WriteLine(oldCards.Count + "skräp");
    Console.WriteLine(cards.Count + "deck");
    }
  }
}