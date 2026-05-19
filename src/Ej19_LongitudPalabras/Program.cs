//Ejercicio 19: Longitud de Palabras
//Crear una aplicación que pida la cantidad de palabras a ingresar y, tras cargarlas, muestre cada una junto con su cantidad de caracteres.

namespace Ej19_LongitudPalabras;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> listado = FnLogicas.ListaPalabras();

        foreach(string palabra in listado)
        {
            Console.WriteLine($"{palabra} tiene {palabra.Length} letras");
        }
    }
}