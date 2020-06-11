using System;
using System.Collections.Generic;

namespace examination_3
{

  public class DeckofCards
  {

  private List<Cards> _oldCards = new List<Cards>(); 
	private List<Cards> _cards = new List<Cards>();

  static Random _random = new Random();

	public List <Cards> FillDeck()
	  {
    for (int i = 0; i < Enum.GetNames(typeof(suit)).Length; i++) 
    {
    for (int x = 2; x < Enum.GetNames(typeof(CardValue)).Length + 2; x++) 
		_cards.Add(new Cards((suit)i, (CardValue)x));
    } 
    return _cards;
    }


  public Cards Shuffle()
    {
    GetOldCard();
    int n = _cards.Count;
    for (int i = 0; i < (n - 1); i++)
    {
    int r = i + _random.Next(n - i);
    Cards t = _cards[r];
    _cards[r] = _cards[i];
    _cards[i] = t;
    }   
    return _cards[0];
    }


  public void GetOldCard () {
    if (_cards.Count <= 1) 
    {
      foreach(Cards card in _oldCards)  
    {
      _cards.Add(card);
    }
      _oldCards.Clear();
    }
    
  }

  public void RemoveUsedCards () 
  {
    _cards.RemoveAt(0);

  }
  public void ThrowCards(Player player) {

    foreach(Cards card in player.hand)  
    {
      _oldCards.Add(card);
    };
    // Console.WriteLine("");
    // Console.WriteLine(_oldCards.Count + " " + "UsedCards");
    // Console.WriteLine(_cards.Count + " " +  "InDeck");
    }
  }
}