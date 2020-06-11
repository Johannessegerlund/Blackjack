using System;

namespace examination_3
{
    public class Cards
    {

    public Cards(suit suit, CardValue cardValue)
      {
      CardValue = cardValue;
      Suit = suit;  
		        
      }
		public CardValue CardValue
			{
			get;
			set;
			}

		public suit Suit
			{
			get;
			set;
			}

		public override string ToString()
			{
			return CardValue + " of " + Suit.ToString();
			}
		}
	}





 