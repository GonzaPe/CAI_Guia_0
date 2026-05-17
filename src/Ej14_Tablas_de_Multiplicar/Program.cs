//Ejercicio 14: Tablas de Multiplicar
//Crear una aplicación que, al ingresar un número, muestre su tabla de multiplicar del 1 al 10.
using Ej14_TablasMultiplicar;

int contador = 1;
int numeroIngresado = FnValidacion.PedirEntero("Ingrese un valor para devolver su tabla: ");
List<int> tabla = FnOperativas.GenerarTabla(numeroIngresado);
foreach (int valor in tabla)
{
    Console.WriteLine($"{numeroIngresado} x {contador} = {valor}");
    contador++;
}