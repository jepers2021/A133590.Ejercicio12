using System;

namespace A133590.Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 12");
            Console.WriteLine("Dadas dos frases, determina si son iguales. (Es sensible a mayúsculas y minúsculas)");
            Console.Write("Ingrese una frase: ");
            string unaFrase = Console.ReadLine();
            Console.Write("Ingrese otra frase: ");
            string otraFrase = Console.ReadLine();

            if (unaFrase.Equals(otraFrase))
            {
                Console.WriteLine("Las frases son iguales.");
            }
            else
            {
                Console.WriteLine("Las frases no son iguales.");
            }


            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
