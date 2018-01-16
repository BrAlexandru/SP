using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AlignLeft:AlignStrategy
    {
        public AlignLeft(string text) : base(text)
        {

        }
        public override void printAlign(string text)
        {
            Console.WriteLine($"***{text}");
        }
    }
}
