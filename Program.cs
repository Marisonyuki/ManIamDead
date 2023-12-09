using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите своё имя");
            string PlayerName = Console.ReadLine();
            GameStart();
        }

        static void GameStart()
        {
            string a = "Несмотря на то, что в воображении легко представить, как слон гигантских размеров несется на большой скорости вперед и прыгает на несколько метров, в реальности эти животные не способны выполнять такие маневры. Это связано с особенностью строения тела. Лапы животного могут сгибаться только вперед. Из-за этой особенности ему трудно отталкиваться от поверхности так, чтобы все четыре конечности оказались в воздухе. Это исключает возможность бегать и прыгать. Также существенную роль играет и вес слона. Масса взрослой особи может варьироваться от 2,5 до 6 тонн, и если бы животное могло бегать и прыгать, его суставы быстро приходили в негодность из-за высоких нагрузок";
            bool GameFinished = false;
            Thread Timer = new Thread(() => {
                int Time = 60;
                do 
                {
                    string TimeZero = null;
                    if (Time < 10)
                    {
                        TimeZero = "0";
                    }
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("Таймер: " + TimeZero + Time);
                    Thread.Sleep(1000);
                    Time--;
                } while (Time >= 0);
            });
            Console.Clear();
            Console.WriteLine(a);
            Console.WriteLine("----------------------");
            Console.WriteLine("Как только будете готовы, нажмите enter");
            ConsoleKeyInfo Key = Console.ReadKey(true);
            while (Key.Key != ConsoleKey.Enter)
            {
                Key = Console.ReadKey(true);
            }
            if (Key.Key == ConsoleKey.Enter)
            {
                string m = null;
                char j = ' ';
                int k = 0;
                int u = 0;
                Timer.Start();
                while (GameFinished == false) 
                { 
                    Texton Text = new Texton();
                    Text.Textik(a, GameFinished, j, k, m, u, Timer);
                    if (GameFinished == true)
                    {
                        break;
                    }
                }
                Console.SetCursorPosition(0, 21);
                Console.WriteLine("Завершение");
                
            }
        }
    }
}