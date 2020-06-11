using System;
using System.Collections.Generic;

namespace examination_3
{

  public class Game
    {
    private int _limit;
    DeckofCards deck = new DeckofCards();
    private int _player;
      
  public Game (int AmountOfPlayer)
    {
    deck.FillDeck();
		  
    _player = AmountOfPlayer;

    }

  public int Stop () {
    Random random = new Random();
    _limit = random.Next(5, 20); 
    return _limit;
    }
  public void NewGame () {
    for (var i = 0; i < _player; i++) {
    var Player = new Player(Stop(), "Player " + i);
    var dealer = new Dealer(Stop(), "Dealer");
    
     GameResult(Player, dealer);
    }
    }


public void GameResult(Player player, Dealer dealer) {
    player.NameOfPlayer();
    player.GetCard(deck);
    if(player.hand.Count == 1) 
    {
    player.GetCard(deck);
    } 
    
    Console.WriteLine(string.Join(", ", player.hand));
    Console.WriteLine("Total Value" + " " + player.HandValue() );
    deck.ThrowCards(player);

    if (player.HandValue() > 21) 
    {
    Console.WriteLine("Player got busted");
    } 
    else if (player.HandValue() == 21) 
    {
    Console.WriteLine("Player wins");
    } 
    else if (player.HandValue() <= 21 && player.NumberOfCards() == 5) 
    {
    Console.WriteLine("Player wins");
    } 
    else if (player.HandValue() < 21 && player.NumberOfCards() < 5) 
    {
    Console.WriteLine("");

    dealer.NameOfPlayer();

    dealer.GetCard(deck);

    if(dealer.hand.Count == 1) 
    {
    dealer.GetCard(deck);
    } 

    Console.WriteLine(string.Join(", ", dealer.hand));
    Console.WriteLine("Total Value" + " " + dealer.HandValue());
    deck.ThrowCards(dealer);


    if (dealer.HandValue() > 21) 
    {
      Console.WriteLine( "Dealer got busted");
    } 
    else if (dealer.HandValue() == 21) 
    {
      Console.WriteLine ("Dealer wins");
    } 
    else if (player.HandValue() > dealer.HandValue()) 
    {
      Console.WriteLine("player wins");
    } 
    else if (player.HandValue() == dealer.HandValue()) 
    {
      Console.WriteLine ("Dealer wins");
    } 
    else if (dealer.HandValue() <= 21 && dealer.NumberOfCards() == 5) 
    {
      Console.WriteLine ("Dealer wins");
    } 
    else if (dealer.HandValue() > player.HandValue()) 
    {
      Console.WriteLine("Dealer wins");
    }
    
    }
    Console.WriteLine("");
    }

  }
}