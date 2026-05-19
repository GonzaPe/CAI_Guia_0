namespace Ej19_LongitudPalabras
{
    internal class FnValidadores
    {
        public static int EnteroPositivo(string mensaje)
        {
            bool valida = false;
            int valor;
            do
            {
                Console.Write(mensaje);
                valida = int.TryParse(Console.ReadLine(), out valor);
                if (!valida)
                {
                    Console.WriteLine("Ingrese un número entero mayor a cero.");
                }
                else if (valor <= 0)
                {
                    Console.WriteLine("Ingrese un número entero mayor a cero.");
                    valida = false;
                }
            } while (!valida);
            return valor;
        }

        public static string StringNoVacio(string mensaje)
        {
            bool invalida = false;
            string palabra = null;

            do
            {
                Console.Write(mensaje);
                palabra = Console.ReadLine();
                invalida = string.IsNullOrEmpty(palabra);
                if (invalida)
                {
                    Console.WriteLine("Debe ingresar una palabra.");
                }
            } while (invalida);

            return palabra;
        }
    }
}
