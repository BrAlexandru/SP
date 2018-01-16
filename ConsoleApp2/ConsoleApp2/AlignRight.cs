using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AlignRight:AlignStrategy
    {
        public AlignRight(String text) : base(text)
        {

        }
        public override void printAlign(string text)
        {
            Console.WriteLine($"{text}***");
        }
    }
}
