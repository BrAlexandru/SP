using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class AbstractElement : Element
    {

        public void Add(Element x)
        {
            try
            {
                throw new Exception("AbstractElement");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Remove(Element x)
        {
            try
            {
                throw new Exception("AbstractElement");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Element GetElement(int index)
        {
            try
            {
                throw new Exception("AbstractElement");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;

        }

        public abstract void Print();
        public abstract void AcceptVisitor(Visitor v);

    }
}
