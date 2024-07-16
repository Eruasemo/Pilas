using System;

namespace ListasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila test = new Pila("Prueba");

            Console.WriteLine(test.Peek());
            
            test.Push("Hola");
            test.Push(12);
            test.Push(true);
            test.Push('b');
            test.Push(12.5f);

            Console.WriteLine( test.Peek());

            while (!test.PilaVacia())
            {
                Console.WriteLine(test.Pop());
            }

            test.Push('b');
            Console.WriteLine(test.Pop());
            test.Push(12);
            test.Push(true);
            Console.WriteLine(test.Pop());
        }
       
    }
}
