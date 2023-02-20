using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib
{
    public abstract class PrintEdition : IPrinting
    {
        public string Name { get; set; }
        public int Pages { get; set; }

        public event IPrinting.PrintHandler onPrint;

        public void Print() => onPrint?.Invoke();

        public PrintEdition(string name, int pages)
        {
            this.Name = name;
            this.Pages = pages;
        }

        public override string ToString()
        {
            return $"name={Name}; pages={Pages}";
        }
    }
}
