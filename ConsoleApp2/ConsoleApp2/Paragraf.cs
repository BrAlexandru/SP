using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Paragraf:AbstractElement
    {
        private string _text;
        private TextSpecial _textSpecial = null;
        private AlignStrategy x = null;

        public Paragraf(string text)
        {
            _text = text;
        }
        public override void Print()
        {
            if (x == null)
                x = new AlignLeft(_text);
            x.printAlign(_text);
        }
        public void setText(String txt)
        {
            _textSpecial.PrintSpecial(txt);
        }
        public override void AcceptVisitor(Visitor v)
        {
            v.VisitParagraf(this);
        }
        public void SetAlign(String text)
        {
            if (text.Equals("center"))
                x = new AlignCenter(text);
            else if (text.Equals("left"))
                x = new AlignLeft(text);
            else
                x = new AlignRight(text);
        }
    }
}
