using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Carte
    {
        private string _titlu;
        private List<Element> _continut = new List<Element>();
        private List<string> _autori = new List<string>();

        public Carte(string titlu,List<string> autori)
        {
            _titlu = titlu;
            _autori = autori;
        }
        public void Print()
        {
            Console.WriteLine("Titlu:" + _titlu);
            Console.WriteLine("Autori:");
            foreach (var autor in _autori)
                Console.WriteLine(autor);
            foreach (var element in _continut)
                element.Print();
        }
        public void AddAutor(string autor)
        {
            _autori.Add(autor);
        }
        public void AddContinut(Element element)
        {
            _continut.Add(element);
        }

        public void AcceptVisitor(Visitor v)
        {
            foreach (var element in _continut)
                element.AcceptVisitor(v);
        }
    }
}
