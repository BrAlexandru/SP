using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Sectiune:AbstractElement
    {
        private string _titlu;
        private List<Element> _continutSectiune = new List<Element>();

        public Sectiune(string titlu)
        {
            _titlu = titlu;
        }
        public new void Add(Element a)
        {
            _continutSectiune.Add(a);
        }
        public new void Remove(Element a)
        {
            _continutSectiune.Remove(a);
        }
        public new Element GetElement(int index)
        {
            return _continutSectiune[index];
        }
        public List<Element> GetElements()
        {
            return _continutSectiune;
        }
        public override void Print()
        {
            Console.WriteLine("Sectiunea " + _titlu);
            foreach (var element in _continutSectiune)
                element.Print();
        }

        public override void AcceptVisitor(Visitor v)
        {
            v.VisitSectiune(this);
        }
    }
}
