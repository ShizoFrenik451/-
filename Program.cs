using System;

namespace Исключения
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleMethod(null);
            }
            catch (ArgumentNullException ex) { Console.WriteLine(ex.Message); }

            SimpleMethod(1, 0);

            int[] array = new int[2];
            Console.WriteLine(array[3]);
        }
        static void SimpleMethod(int x, int y)
        {
            try
            {
                x = x / y;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SimpleMethod(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
        }
    
        
    }
}
