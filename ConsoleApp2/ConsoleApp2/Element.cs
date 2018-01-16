using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface Element
    {
        void Add(Element x);
        void Remove(Element x);
        Element GetElement(int index);
        void Print();

        void AcceptVisitor(Visitor v);

    }
}
