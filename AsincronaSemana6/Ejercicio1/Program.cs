using System.Reflection.Metadata.Ecma335;

namespace Ejercicio1
{
    public class Program
    {
        static string[] nombres = { "Bryan", "Fernando", "Luz", "Marisol", "Oscar", "Marta", "Ruben"};
        static void Main(string[] args)
        {
            Console.WriteLine("Nombres que contienen la letra A");
            FuncionFiltrarNombreA();
        }

        static void FuncionFiltrarNombreA()
        {

            Console.WriteLine("Expresion LINQ\n");
            var filtar = from nombre in nombres
                         where nombre.Contains('a')
                         select nombre;
            
            foreach (var nombre in filtar)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("\nExpresion LAMBDA\n");
            var filtar2 = nombres.Where(x => x.Contains('a'));
            foreach (var nombre in filtar2)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
