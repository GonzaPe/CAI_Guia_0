namespace Ej14_TablasMultiplicar;

public static class FnOperativas
{
    public static List<int> GenerarTabla(int numero)
    {
        List<int> tabla = new List<int>();

        for (int i = 1; i < 11; i++)
        {
            tabla.Add(numero * i);
        }
        return tabla;
    }
}
