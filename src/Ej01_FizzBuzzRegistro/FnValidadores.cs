namespace Ej01_FizzBuzzRegistro;
public static class FnValidadores
{
    public static int PedirValorEnteroRango(string mensaje, int valorMin, int valorMax)
    {
        int valorIngresado;
        bool valida = false;

        do
        {
            Console.Write(mensaje);
            valida = int.TryParse(Console.ReadLine(), out valorIngresado);
            if (!valida)
            {
                Console.WriteLine("Ingrese un valor entero positivo");
            }
            else if(valorIngresado< valorMin || valorIngresado > valorMax)
            {
                Console.WriteLine($"Ingrese un valor entero entre {valorMin} y {valorMax}");
                valida = false;
            }
        } while (!valida);
        return valorIngresado;
    }
}
