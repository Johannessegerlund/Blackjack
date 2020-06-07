using System;
using System.Collections.Generic;

namespace examination_3
{

    public class Player
    {
      private int _limit;
     
      private string _name;
    public Player(int limit, string name)
      {  
      _limit = limit;
      _name = name;
      
      }

    public List<Cards> hand = new List<Cards>();

    public int HandValue() 
      {
      int totalHandValue = 0;

      for (int i = 0; i < hand.Count; i++) 
      {
      totalHandValue += (int)hand[i].CardValue;
      }
      for (var i = 0; i < hand.Count; i++) 
      {
      if ((int)hand[i].CardValue == 14 && totalHandValue > 21) 
      {
      totalHandValue -= 13;
      }
      }
      return totalHandValue;
      }

    public bool StopLimit ()
      {
        return HandValue() >= _limit || hand.Count == 5;

      }
     

    public int NumberOfCards () 
      {
      return hand.Count;
      }

    public void GiveCard (DeckofCards deck) 
      {
        hand.Add(deck.Shuffle());
      }


    public void GetCard (DeckofCards deck) 
      {
      do 
      {
      GiveCard(deck);
      deck.removeUsedCards();
      } 
      while(!StopLimit());
      }

    public void NameOfPlayer() 
      {
      Console.WriteLine(_name + ", " + _limit);
      }
	}

	}