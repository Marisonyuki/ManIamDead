using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Texton
    {
        public void Textik(string a, bool GameFinished, char j, int k, string m, int u, Thread Timestop)
        {
            Stopwatch stopwatch = new Stopwatch();
            long ts = 0;
            char[] g = a.ToCharArray();
            Console.ForegroundColor = ConsoleColor.Blue;
            while (GameFinished == false)
            {
                for (int i = 0; i < g.Length; i++)
                {
                    while (j != g[i])
                    {
                        stopwatch.Start();
                        j = Console.ReadKey(true).KeyChar;
                        if (u == 119)
                        {
                            if (j == g[i])
                            {
                                Console.SetCursorPosition(u, k);
                                u = 0;
                                k++;
                            }
                            else
                            {
                                Console.SetCursorPosition(u, k);
                            }
                            stopwatch.Stop();
                        }
                        else
                        {
                            if (j == g[i])
                            {
                                Console.SetCursorPosition(u, k);
                                u++;
                            }
                            else
                            {
                                Console.SetCursorPosition(u, k);
                            }
                            stopwatch.Stop();
                        }
                    }
                    Console.Write(j);
                    m = m + j;
                    j = 'L';
                    ts = ts + stopwatch.ElapsedMilliseconds;
                    if (ts >= 60000)
                    {
                        GameFinished = true;
                        break;
                    }
                    if (m == a) 
                    {
                        GameFinished = true;
                        break;
                    }
                }
            }
        }
    }
}
