//Ejercicio 1: FizzBuzz de Registro
//Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos de tu propio número de registro (en caso de comenzar con 0, sumarle 100). Todos los números deben mostrarse por pantalla. Para los múltiplos de 3, agregar la palabra “Foo”; para los múltiplos de 5, “Bar”; y para los múltiplos de ambos, “FooBar”.
//•	Ejemplo: El número 15 mostrará “15 – FooBar”.
//Pedir ingreso de los 3 dígitos. For iterando while i<=numero. if numero%3 print foo

namespace Ej01_FizzBuzzRegistro;
public class Program
{
    public static void Main(string[] args)
    {
        int numeroRegistro;

        numeroRegistro = FnValidadores.PedirValorEnteroRango("Ingrese los tres últimos dígitos de su número de registro: ",0,999);
        if (numeroRegistro < 100) {
            numeroRegistro += 100;
        }

        for (int i = 1; i <= numeroRegistro; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{i} - FooBar");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} - Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"{i} - Bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}