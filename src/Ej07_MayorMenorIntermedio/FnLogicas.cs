namespace Ej07_MayorMenorIntermedio;
internal class FnLogicas
{
    public static void MayMenInt()
    {
        List<int> listaValores = new List<int>();

        for (int i = 1; i <= 5; i++)
        {
            listaValores.Add(FnValidaciones.ValidaNumEntero($"Ingrese el valor n°{i}: "));
        }
        listaValores.Sort();
        Console.WriteLine("El valor máximo es " + listaValores[4]);
        Console.WriteLine("El valor mínimo es " + listaValores[0]);
        Console.WriteLine("El valor intermedio es " + listaValores[2]);
    }
}
