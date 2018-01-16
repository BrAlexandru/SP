using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TextSpecial:AbstractElement
    {
        private string _text;

        public TextSpecial(string a)
        {
            _text = a;
        }
        public override void Print()
        {
            Console.WriteLine("Text Special: " + _text);
        }
        public void PrintSpecial(String txt)
        {
            Console.WriteLine("Teeeeext Special:" + _text);
        }
        public override void AcceptVisitor(Visitor v)
        {
            v.VisitTextSpecial(this);
        }
    }
}
