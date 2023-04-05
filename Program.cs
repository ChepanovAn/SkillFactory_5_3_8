using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_3_8
{
    class Program
    {
        static int[] GetArrayFromConsole(ref int number)
        {
            var result = new int[number];
            Console.WriteLine(result.Length + 1);            
            return result;
        }
        static void Main(string[] args)
        {
            int number = 5;

            GetArrayFromConsole(ref number);
            Console.ReadKey();
        }
    }
}
