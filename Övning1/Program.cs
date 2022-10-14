namespace Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How meny item do you wana input?: ");
            string[] items = new string[int.Parse(Console.ReadLine())];

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{i+1} - Item: ");
                items[i] = Console.ReadLine();
            }

            Array.Sort(items);

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}