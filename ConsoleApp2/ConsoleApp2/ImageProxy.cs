using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ImageProxy:AbstractElement
    {
        private string _fileName;
        private Image _realImage = null;

        public ImageProxy(string fileName)
        {
            _fileName = fileName;
        }
        public override void Print()
        {
            _realImage = new Image(_fileName);
            _realImage.Print();
        }

        public override void AcceptVisitor(Visitor v)
        {
            v.VisitImageProxy(this);
        }

    }
}
