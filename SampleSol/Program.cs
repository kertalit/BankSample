using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SampleSol
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_USERS = 50000;
            string[] names = new string[MAX_USERS];


            for( int i = 0; i < 4; ++i)
            {
                names[i] = "user" + (i+1);
            }
            int freeIndex = 4;

            while (true)
            {
                string data = Console.ReadLine();

                if (data == "q")
                    break;
                else
                {
                    names[freeIndex] = data;
                    freeIndex++;
                }
            }

            for (int i = 0; i < freeIndex; ++i)
            {
                Console.WriteLine("user: " + names[i]);                
            }
        }   
     }
}


