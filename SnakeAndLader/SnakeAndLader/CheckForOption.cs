using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLader
{
    internal class CheckForOption
    {
        public void Check()
        {
            int i=0;
            int temp=0;
            int zero=0;
            
            while (i <= 100)
            {
               Random random = new Random();
                int rnd =random.Next(1,6);

                if (rnd == zero)
                {
                    Console.WriteLine("player stay in same position");
                    i+=rnd;
                }
                else if(rnd!=0)
                {
                    Console.WriteLine($"player move to{i+rnd}");
                    
                    
                      if (i == 27)
                    {
                        Console.WriteLine($"you touch the snake move down {i - 24}");
                        i -= 24;
                    }
                    else if (i == 88)
                    {
                        Console.WriteLine($"you touch the snake move down {i - 45}");
                        i -= 45;
                    }
                      else if(i ==15)
                    {
                        Console.WriteLine($"you got laddr move to{i + 26}");
                        i += 26;
                    }
                      else if (i==64)
                    {
                        Console.WriteLine($"you got ladder move to {i + 28}");
                        i+=28;
                    }
                      else if(i==temp)
                    {
                        i += rnd;
                    }
                }

                i+=rnd;
             }
            Console.WriteLine("Game over");
        }
    }
}
