namespace CSharpLearning
{
    internal class Program
    {
        static IEnumerable<int> ProduceEvenNumbers(int upto)
        {
            for (int i = 0; i <= upto; i += 2)
            {
                yield return i;
            }
        }

        static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        static void Main(string[] args)
        {
            foreach (int i in ProduceEvenNumbers(9))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            // Output: 0 2 4 6 8

            foreach (int number in GetNumbers())
            {
                Console.WriteLine(number);
            }
        }
    }
}
