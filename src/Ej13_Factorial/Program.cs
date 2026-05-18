// Ejercicio 13: Factorial de un Número
//Crear una aplicación que calcule el factorial ($n!$) de un número ingresado (el producto de todos los enteros desde 1 hasta $n$).
namespace Ej13_Factorial;

public class Program
{
    public static void Main(string[] args)
    {
        int operando = FnValidadores.ValidaEnteroPositivo("Ingrese un valor entero para devolver su factorial: ");
        Console.WriteLine(Logica.DevuelveFactorial(operando));
    }
}