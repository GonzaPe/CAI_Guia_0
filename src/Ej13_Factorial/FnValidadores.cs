namespace Ej13_Factorial
{
    internal class FnValidadores
    {
        public static int ValidaEnteroPositivo(string mensaje)
        {
            bool valida = false;
            int valor;

            do
            {
                Console.Write(mensaje);
                valida = int.TryParse(Console.ReadLine(), out valor);
                if (!valida || valor < 0)
                {
                    Console.WriteLine("Ingrese un entero positivo");
                    valida = false;
                }
            } while (!valida);
            return valor;
        }
    }
}
