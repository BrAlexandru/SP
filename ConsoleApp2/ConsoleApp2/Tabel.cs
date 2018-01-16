using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tabel:AbstractElement
    {
        private string _text;

        public Tabel(string text)
        {
            _text = text;
        }
        public override void Print()
        {
            Console.WriteLine("Tabel " + _text);
        }
        public override void AcceptVisitor(Visitor v)
        {
            v.VisitTabel(this);
        }
    }
}
