namespace Ej07_MayorMenorIntermedio;
internal class FnValidaciones
{
    public static int ValidaNumEntero(string mensaje)
    {
        int valor;
        bool valida = false;

        do
        {
            Console.Write(mensaje);
            valida = int.TryParse(Console.ReadLine(), out valor);
            if (!valida)
            {
                Console.WriteLine("Ingrese un número entero.");
            }
        } while (!valida);

        return valor;
    }
}