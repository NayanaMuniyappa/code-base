using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test1
{
    class Program
    {

        static void Main(string[] args)
        {
            //tast 1
            for (int i = 1; i < 3; i++)
            {
                WriteLine(" enter the input string: {0}",+i);
                string str = ReadLine();
                WriteLine(" enter the position {0} ",i);
                int t = Convert.ToInt32(ReadLine());
                string removed = str.Remove(t, 1);
                WriteLine($" { removed}");
            }


            // task 2
            Write(" enter the number table");
            int n = Convert.ToInt32(ReadLine());
            for(int i=1;i<=10;i++)
            {
                
                WriteLine($"{n } * { i }=  {n * i} \t");
            }
            Read();
          
        }
        
    }
}
