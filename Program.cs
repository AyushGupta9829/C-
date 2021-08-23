using System;
namespace btod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, n;
            Console.WriteLine("Enter any Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial is : " + fact);
            

            int n1 = 0, n2 = 1, n3, j, x;
            Console.Write("Enter the number of elements: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (j = 2; j < x; ++j)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }




            
    }
}