using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class AlignStrategy
    {
        protected string text;

        public AlignStrategy(string txt)
        {
            text = txt;
        }

        public abstract void printAlign(String text);
    }
}
