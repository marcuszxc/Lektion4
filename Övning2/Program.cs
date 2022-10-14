namespace Övning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input list lenght: ");
            int[] intArray = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"{i+1} - Int: ");
                intArray[i] = int.Parse(Console.ReadLine()); 
            }

            Array.Sort(intArray);

            foreach (int sint in intArray)
            {
                Console.Write($"{sint} ");
            }
            
            Console.WriteLine();

            Array.Reverse(intArray);

            foreach(int rint in intArray)
            {
                Console.Write($"{rint} ");
            }
        }
    }
}