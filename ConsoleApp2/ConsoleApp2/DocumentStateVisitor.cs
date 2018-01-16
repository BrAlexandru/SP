using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DocumentStateVisitor:Visitor
    {
        private static int _imageCount = 0;
        private static int _paragrafCount = 0;
        private static int _tabelCount = 0;
        private static int _sectiuneCount = 0;
        private static int _textSpecialCount = 0;

        public void PrintStatistics()
        {
            Console.WriteLine("Exista: ");
            Console.WriteLine(_sectiuneCount + " sectiuni");
            Console.WriteLine(_imageCount + " imagini");
            Console.WriteLine(_paragrafCount + " paragrafe");
            Console.WriteLine(_tabelCount + " tabele");
            Console.WriteLine(_textSpecialCount + " texte speciale");
        }

        public void VisitImageProxy(ImageProxy image)
        {
            _imageCount++;
        }
        public void VisitImage(Image img)
        {
            _imageCount++;
        }
        public void VisitParagraf(Paragraf par)
        {
            _paragrafCount++;
        }
        public void VisitTabel(Tabel tab)
        {
            _tabelCount++;
        }
        public void VisitTextSpecial(TextSpecial txt)
        {
            _textSpecialCount++;
        }
        public void VisitSectiune(Sectiune sec)
        {
            _sectiuneCount++;

            foreach (var element in sec.GetElements())
                element.AcceptVisitor(this);
        }
    }
}
