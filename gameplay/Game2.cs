using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameplay
{
    public class Game2 : IGame
    {

        int input = -1;
        int guess = 55;
        public void Setup()
        {
            Console.WriteLine("===============歡迎遊玩猜數字===============");
            guess = new Random().Next(5);
            Console.WriteLine("請輸入數字(0~100):");

        }

        public void Paly()
        {
            while (true)  //game loop 
            {
                //決定輸入內容
                string input_str = Console.ReadLine();  //input  string 
                input = int.Parse(input_str);

                //離開條件 
                if (input == guess)
                {
                    Console.WriteLine("恭喜你答對了!");
                    break;
                }
                //提示
                Console.WriteLine("猜錯了，再來一次！");
            }

            Console.WriteLine("是否在玩一次? <Y/N>");
            Exit();


        }
        public void Exit()
        {
            try
            {
                string input = Console.ReadLine();
                string x = input;
                if (x == "Y" || x == "y")
                {
                    Setup();
                    Paly();
                }
                else if (x == "N" || x == "n")
                {
                    Console.WriteLine("================感謝你的遊玩================");                  
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("輸入錯誤，請重新輸入");
                Exit();
            }
        }
    }
}
