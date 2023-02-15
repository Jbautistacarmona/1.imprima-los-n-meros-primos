using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.imprima_los_números_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Imprimir números primos"); //mensaje en pantalla, sobre los numeros primos.
            Console.WriteLine("-----------------------");

            Console.Write("Ingrese el número inicial: ");//para que el usuario introduzca el primer numero primo o inicio.
            int start = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número final: ");//para que el usuario introduzca el numero final.
            int end = int.Parse(Console.ReadLine());//Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.

            Console.WriteLine("\nLos números primos entre " + start + " y " + end + " son:");

            for (int i = start; i <= end; i++) 
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static bool IsPrime(int number) //Este método analiza el argumento de cadena como un valor booleano.
        {
            if (number <= 1) return false; ////la bifurcación condicional. El cuerpo de una instrucción if se ejecuta si el valor de la expresión es distinto de cero.
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));//variable local perimetro o los limites para realizar el calculo.

            for (int i = 3; i <= boundary; i += 2)//ecuta su cuerpo mientras una expresión booleana especificada se evalúe como true.
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}