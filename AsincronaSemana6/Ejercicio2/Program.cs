namespace Ejercicio2
{
    public class Program
    {

        static int[] numeros = { 8, -3, 3, 4, 90, 9, 16, 100, 1, 2, 10, 7 };
        static void Main(string[] args)
        {
            Console.WriteLine("\nSuma de los numeros mayores que 5 definidos en un array.\n");
            SumaNumerosMayores5();
        }

        static void SumaNumerosMayores5()
        {

            Console.WriteLine("Expresion LINQ\n");
            var filtro = from numero in numeros
                         where numero > 5
                         select numero;

            var suma = 0;
            Console.WriteLine("Numeros mayores que 5\n");
            foreach (int numero in filtro)
            {
                suma += numero;
                Console.WriteLine(numero);
            }
            Console.WriteLine($"\nLa suma de los numeros mayores que 5 es: {suma}\n");

            Console.WriteLine("Expresion LAMBDA\n");
            var filtro2 = numeros.Where(y => y > 5);

            var suma2 = 0;
            Console.WriteLine("Numeros mayores que 5\n");
            foreach (int numero in filtro2)
            {
                suma2 += numero;
                Console.WriteLine(numero);
            }
            Console.WriteLine($"\nLa suma de los numeros mayores que 5 es: {suma2}\n");
        }
    }
}
