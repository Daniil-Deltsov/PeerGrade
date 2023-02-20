using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib
{
    public class MyLibrary<T> : IEnumerable<T> where T : PrintEdition
    {
        private List<T> library = new List<T>();
        public delegate List<T> BookHandler(char c);
        public event BookHandler onTake;
        public List<T>? TakeBooks(char start) => onTake?.Invoke(start);

        public void Add(T printed)
        {
            library.Add(printed);
        }

        public IEnumerator<T> GetEnumerator() => library.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public double AverageBookPageCount
        {
            get => library.Where(o => o is Book).Average(o => o.Pages);
        }

        public double AverageMagazinePageCount
        {
            get => library.Where(o => o is Magazine).Average(o => o.Pages);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{library.Sum(o => o.Pages)}");
            foreach (PrintEdition item in library)
                stringBuilder.AppendLine(item.ToString());
            return stringBuilder.ToString();
        }
    }
}
