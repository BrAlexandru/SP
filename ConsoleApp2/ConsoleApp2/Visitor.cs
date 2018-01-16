using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface Visitor
    {
        void VisitImageProxy(ImageProxy img);
        void VisitImage(Image img);
        void VisitParagraf(Paragraf par);
        void VisitTabel(Tabel tab);
        void VisitSectiune(Sectiune sec);
        void VisitTextSpecial(TextSpecial txt);
        
    }
}
