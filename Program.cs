using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasicaComValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Olá, bem vindo a Calculadora Básica!\n" + "Escolha o tipo de operação desejada utilizando o Menu e em seguida os operandos: ");
            Console.WriteLine();
            
            Console.WriteLine( "Menu:");
            Console.WriteLine( "1 - adição; 2 - subtração; 3 - Multiplicação; 4 - Divisão; 5 - Saír.");

            var Calculadora = new Calculadora();
            var entrada = Calculadora.Menu(1);
            



            Console.ReadKey();
        }
    }
}
