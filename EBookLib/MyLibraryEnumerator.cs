using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib
{
    public class MyLibraryEnumerator<U> : IEnumerator<U>
    {
        List<U> libs;
        int position = -1;
        public U Current
        {
            get
            {
                if (position == -1 || position >= libs.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return libs[position];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (position < libs.Count - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
