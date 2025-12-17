using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var colors = new string[] { "Pik", "Kier", "Karo", "Trefl" };
        var numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        var cards = new List<string>();
        var rnd = new Random();

        foreach (var color in colors)
        {
            foreach (var number in numbers)
            {
                cards.Add($"{color} {number}");
            }
        }

        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            string tmp = cards[i];
            cards[i] = cards[j];
            cards[j] = tmp;
        }

        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
}
