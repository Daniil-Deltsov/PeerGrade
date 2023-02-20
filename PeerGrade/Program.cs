using EBookLib;

namespace PeerGrade
{
    internal class Program
    {
        public static void PrintHandler()
        {
            Console.WriteLine("PRINTED!");
        }

        public static void TakeHandler(char start)
        {
            Console.WriteLine($"ATTENTION! Books starts with {start} were taken!");
        }
        static void Main(string[] args)
        {
            MyLibrary<PrintEdition> myLibrary = new MyLibrary<PrintEdition>();
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < N; i++)
            {
                string name = $"{chars[random.Next(26)]}{new String(Enumerable.Range(1, random.Next(2, 9)).Select(c => chars[random.Next(chars.Length)]).ToArray())}";
                if (random.Next(2) == 1)
                {
                    string author = new String(Enumerable.Range(1, random.Next(2, 10)).Select(c => chars[random.Next(chars.Length)]).ToArray());
                    myLibrary.Add(new Book(name, random.Next(-10, 101), author));
                }
                else
                {
                    myLibrary.Add(new Magazine(name, random.Next(-10, 101), random.Next(-10, 101)));
                }
                myLibrary.Last().onPrint += PrintHandler;
                myLibrary.Last().Print();
            }
            myLibrary.onTake += TakeHandler;
            Console.WriteLine(myLibrary);
        }
    }
}