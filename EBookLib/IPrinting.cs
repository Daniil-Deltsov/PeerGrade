using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib
{
    public interface IPrinting
    {
        public delegate void PrintHandler();
        public event PrintHandler onPrint;
        public void Print();
    }
}
