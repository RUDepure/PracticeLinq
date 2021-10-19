using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGames = new List<string>() {"Guilty Gear", "Super Smash Brothers", "Bloodborne", "Kirby's Superstar Saga", "Shin Megami Tensei 4" };

            var orderGames = myGames.OrderBy(x => x.Length).ToList();
            orderGames.ForEach(x => Console.WriteLine(x));
        }
    }
}
