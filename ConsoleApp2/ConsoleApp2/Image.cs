using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Image : AbstractElement
    {
        private string _fileName;

        public Image(string fileName)
        {
            _fileName = fileName;
        }

        public override void Print()
        {
            Console.WriteLine("Image " + _fileName);
        }
        public override void AcceptVisitor(Visitor v)
        {
            v.VisitImage(this);
        }
    }
}
