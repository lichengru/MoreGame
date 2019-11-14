using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameplay
{
    public class Game2 : IGame
    {
        int max = 0;
        public void Paly()
        {
            Console.WriteLine("請輸入範圍:");
            String input = Console.ReadLine();
            max = int.Parse(input);
        }

        public void Setup()
        {
            Console.WriteLine($"你輸入的最大範圍是{max}");
        }
    }
}
