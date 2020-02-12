using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {

  // DEBUG FOR CHECKING DECK
  // for (var i = 0; i < newDeck.Count; i++) {
  //          Console.WriteLine(newDeck[i]); }
    
    // once deck shuffled, display top card
    // give user option to see next card or quit
    static void Main(string[] args)
    {
     // program starts, create a new deck
    var deck =
      new List<string> {};
    // there are thirteen ranks
    var newRank =
      new List<string> {"Ace", "2", "3", "4", "5", "6",
      "7", "8", "9", "10", "Jack", "Queen", "King"};
    // there are four suits
    var newSuit =
      new List<string> {"Clubs", "Diamonds", "Hearts", "Spades"};
    // the deck must contain 52 cards
    // represent each card with a suit and a rank
    for (var i = 0; i < newRank.Count; i++){
      var currentRank = newRank[i];
        for (var n = 0; n < newSuit.Count; n++){
          var currentSuit = newSuit[n];
          deck.Add($"{currentRank} of {currentSuit}");
        }
    }
    // after deck is created, shuffled deck
    for (int shuffleDeck = deck.Count - 1; shuffleDeck >= 0; shuffleDeck--){  
        var random = new Random().Next(shuffleDeck);

        var swap = (deck[random]);
        deck[random] = (deck[shuffleDeck]);
        deck[shuffleDeck] = swap;  
    }
    var topCard = deck[0];
    var currentCard = 0;

    // display top card
    Console.WriteLine($"Your card is {topCard}");

    while (true){
      Console.WriteLine("Would you like to see the (NEXT) card or (QUIT)?");
      var userAnswer = Console.ReadLine().ToLower();
      if (userAnswer == "next"){
        currentCard++;
        Console.WriteLine($"Your next card is {deck[currentCard]}");
      }
      else {
      break;
      }
      }
    }
  }
}