namespace Övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Loop(10));
        }

        static int Loop(int num)
        {

            Console.WriteLine(num);

            num--;

            if (num == 1)
            {
                return num;
            }

            return Loop(num);
        }

    }
}