using System;

namespace Gun22
{
    internal class Program
    {
        static void Main()
        {
            int[] dailyOrders = { 2, 4, 3 };
            int total = 0;
            foreach (int count in dailyOrders) total += count;
            Console.WriteLine($"Üç günlük sipariş toplamı: {total}");
        }
    }
}
