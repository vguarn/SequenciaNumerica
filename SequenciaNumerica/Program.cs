using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaNumerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i<=9; i++)
            {
                Console.WriteLine(i);
                for (int j =1; j<=9; j++)
                {
                    if(i !=j)
                    {
                        Console.Write(j);
                    }

                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
      
        }

    }
 
