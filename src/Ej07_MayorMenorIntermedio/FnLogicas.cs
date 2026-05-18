namespace Ej07_MayorMenorIntermedio;
internal class FnLogicas
{
    public static void MayMenInt()
    {
        int valorIngresado = FnValidaciones.ValidaNumEntero("Ingrese el valor n°1: ");
        int valorBase = valorIngresado;
        int valorMaximo = valorBase;
        int valorSubMax = valorBase;
        int valorIntermedio = valorBase;
        int valorSubMin = valorBase;
        int valorMinimo = valorBase;

        for (int i = 2; i <= 5; i++)
        {
            valorIngresado = FnValidaciones.ValidaNumEntero($"Ingrese el valor n°{i}: ");
            if (valorIngresado > valorIntermedio)
            {
                if (valorIngresado > valorSubMax)
                {
                    if(valorIngresado > valorMaximo)
                    {
                        valorIntermedio = valorSubMax;
                        valorSubMax = valorMaximo;
                        valorMaximo = valorIngresado;
                    } else if(valorIngresado == valorMaximo)
                    {
                        //No hacer nada
                    }
                    else
                    {
                        valorIntermedio = valorSubMax;
                        valorSubMax = valorIngresado;
                    }
                }
                else if (valorIngresado == valorSubMax)
                {
                    //no hacer nada
                }
            }
            else if (valorIngresado < valorSubMin)
            {
                if (valorIngresado < valorMinimo)
                {
                    valorIntermedio = valorSubMin;
                    valorSubMin = valorMinimo;
                    valorMinimo = valorIngresado;
                } else if (valorIngresado == valorMinimo)
                {
                    //No hacer nada
                }
                else
                {
                    valorIntermedio = valorSubMin;
                    valorSubMin = valorIngresado;
                }
            }
            else if (valorIngresado == valorSubMin)
            {
                //No hacer nada
            }
            else
            {
                valorIntermedio = valorIngresado;
            }
        }

        Console.WriteLine("El valor máximo es " + valorMaximo);
        Console.WriteLine("El valor mínimo es " + valorMinimo);
        Console.WriteLine("El valor intermedio es " + valorIntermedio);
    }
}
