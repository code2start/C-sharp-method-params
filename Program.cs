using System;

namespace methodparams
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 9 };
            //PrintArray("Mohamed");
            //Foo("Mohamed", 20, 'C', true);
            Foo();
        }
        static void PrintArray(string x, params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"items = {array[i]}");
            }
        }
        static void Foo(params object[] items)
        {
            foreach (object item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
