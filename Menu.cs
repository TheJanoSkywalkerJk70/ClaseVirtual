using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVirtual
{
    class Menu
    {
        public void Ejecutar()
        {
            Calculadora();
        }

        public void Calculadora()
        {
            while (true)
            {
                int n1;

                Console.WriteLine("Ingrese el primer numero de la Operacion");

                n1 = int.Parse(Console.ReadLine());

                int n2;

                Console.WriteLine("Ingrese el segundo numero de la Operacion");

                n2 = int.Parse(Console.ReadLine());

                string Calculo;

                Console.WriteLine("Si vas a Sumar aprieta +, Si vas a Restar aprieta -, Si vas a Multiplicar aprieta * y Si vas a Dividir aprieta /");

                Calculo = Console.ReadLine();

                switch (Calculo)
                {
                    case ("+"):
                        Console.WriteLine("La Suma de " + n1 + " + " + n2 + " es igual a " + (n1 + n2));
                        break;
                    case ("-"):
                        Console.WriteLine("La Resta de " + n1 + " - " + n2 + " es igual a " + (n1 - n2));
                        break;
                    case ("*"):
                        Console.WriteLine("La Multiplicacion de " + n1 + " * " + n2 + " es igual a " + (n1 * n2));
                        break;
                    case ("/"):
                        Console.WriteLine("La Division de " + n1 + " / " + n2 + " es igual a " + (n1 / n2));
                        break;
                    default:
                        Console.WriteLine("No apretaste ninguno de los botones");
                        break;

                }
            }
        }
    }
}
