using System;
using System.Collections.Generic;

namespace StructsAndEnums_PlayingCard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>
            {
                new Card(Suit.Spades, Rank.King),
                new Card(Suit.Hearts, Rank.Ten),
                new Card(Suit.Diamonds, Rank.Nine),
                new Card(Suit.Clubs, Rank.Seven),
                new Card(Suit.Hearts, Rank.Queen)
            };

            Console.WriteLine($"cards[0] (до изменения копии): {cards[0]}");

            Card copy = cards[0];
            copy.Rank = Rank.Ace;

            Console.WriteLine($"копия — \"{copy}\", cards[0] — без изменений ({cards[0]})");

            if (Enum.TryParse<Rank>("King", out var r1))
            {
                Console.WriteLine($"true, r == Rank.{r1}");
            }

            if (!Enum.TryParse<Rank>("Joker", out var r2))
            {
                Console.WriteLine("false, без исключения");
            }
        }
    }
}