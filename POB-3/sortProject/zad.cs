using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string[] colors = { "Pik", "Kier", "Karo", "Trefl" };
        string[] numbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        var cards = new List<string>();


        foreach (var color in colors)
        {
            foreach (var number in numbers)
            {
                cards.Add($"{color} {number}");
            }
                
        }
            

        var random = new Random();
        for (int i = 0; i < cards.Count; i++)
        {
            int j = random.Next(cards.Count);
            var tmp = cards[i];
            cards[i] = cards[j];
            cards[j] = tmp;
        }


        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }

        var hand1 = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            hand1.Add(cards[i]);
        }

        var hand2 = new List<string>();
        for (int i = 5; i < 10; i++)
        {
            hand2.Add(cards[i]);
        }

        InsertionSort(hand1);
        hand2 = MergeSort(hand2);

        Console.WriteLine("Ręka 1: " + string.Join(", ", hand1));
        Console.WriteLine("Układ: " + Pairs(hand1));

        Console.WriteLine("\nRęka 2: " + string.Join(", ", hand2));
        Console.WriteLine("Układ: " + Pairs(hand2));



        var sortedDeck = MergeSort(cards);
        string targetCard = "Pik A";

        int linearSearch = LinearSearch(sortedDeck, targetCard);
        int binarySearch = BinarySearch(sortedDeck, targetCard);

        Console.WriteLine($"Liniowe wyszukiwanie: {linearSearch}");
        Console.WriteLine($"Binarne wyszukiwanie: {binarySearch}");


    }
        static void SelectionSort(List<string> hand)
        {
            for (int i = 0; i < hand.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < hand.Count; j++)
                {
                    if (hand[j].CompareTo(hand[min]) < 0)
                        min = j;
                }

                (hand[i], hand[min]) = (hand[min], hand[i]);
        }
        }

        static void InsertionSort(List<string> hand)
        {
            for (int i = 1; i < hand.Count; i++)
            {
                string temp = hand[i];
                int j = i - 1;

                while (j >= 0 && hand[j].CompareTo(temp) > 0)
                {
                    hand[j + 1] = hand[j];
                    j--;
                }

                hand[j + 1] = temp;
            }
        }

        static List<string> MergeSort(List<string> hand)
        {
            if (hand.Count <= 1)
                return hand;
            int m = hand.Count / 2;
            var left = MergeSort(hand.GetRange(0, m));
            var right = MergeSort(hand.GetRange(m, hand.Count - m));

            var result = new List<string>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].CompareTo(right[j]) < 0)
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;
        }

        static int LinearSearch(List<string> hand, string card)
        {
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i] == card)
                    return i;
            }
            return -1;
        }

        static int BinarySearch(List<string> hand, string card)
        {
            int left = 0;
            int right = hand.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int compare = hand[mid].CompareTo(card);

                if (compare == 0)
                    return mid;
                else if (compare < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
        static string Pairs(List<string> hand)
        {
            var count = new Dictionary<string, int>();

            foreach (var card in hand)
            {
                string value = card.Split(' ')[1];
                if (!count.ContainsKey(value))
                    count[value] = 0;
                count[value]++;
            }

            int pairs = 0;

            foreach (var v in count.Values)
                if (v == 2) pairs++;

            if (pairs == 2) return "Dwie pary";
            if (pairs == 1) return "Para";
            return "Brak";
        }
}
