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
	public string NamedValue
	{
		get
		{
			string name = string.Empty;
			switch ((int)CardValue)
			{
				case (14):
					name = "Ace";
					break;
				case (13):
					name = "King";
					break;
				case (12):
					name = "Queen";
					break;
				case (11):
					name = "Jack";
					break;
				default:
					name = CardValue.ToString();
					break;
			}

			return name;
		}
	}

	public override string ToString()
	{
		
			return NamedValue + " of " + Suit.ToString();
		
	}
  }
}





 