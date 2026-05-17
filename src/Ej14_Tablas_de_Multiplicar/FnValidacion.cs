namespace Ej14_TablasMultiplicar;
public static class FnValidacion
{
    public static int PedirEntero(string mensaje)
    {
        bool pudeConvertir = false;
        int numero;
        do
        {
            Console.Write(mensaje);
            pudeConvertir = int.TryParse(Console.ReadLine(), out numero);
            if (!pudeConvertir)
            {
                Console.WriteLine("Debe ingresar un valor numérico entero");
            }
        } while (!pudeConvertir);
        return numero;
    }

}