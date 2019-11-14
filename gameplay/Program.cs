using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameplay
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = null;
            Console.WriteLine("您想玩1)河內塔  or 2)猜數字:");
            string input = Console.ReadLine();
            int result = int.Parse(input);

            switch (result)
            {
                case 1:
                    game = new HanoIGame();
                    break;
                case 2:
                    game = new Game2();
                    break;
            }
            game.Setup();
            game.Paly();
            game.Exit();
            Console.ReadKey();

        }
    }
}
