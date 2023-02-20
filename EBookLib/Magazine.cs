using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib
{
    public class Magazine : PrintEdition
    {
        private int period;
        public Magazine(string name, int pages, int period) : base(name, pages)
        {
            this.period = period;
        }

        public int Period
        {
            get { return this.period; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}; period={period}";
        }
    }
}
