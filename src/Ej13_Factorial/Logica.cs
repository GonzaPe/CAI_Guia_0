namespace Ej13_Factorial
{
    internal class Logica
    {
        public static int DevuelveFactorial(int valor)
        {
            int factorial = 1;
            for (int i = valor; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
