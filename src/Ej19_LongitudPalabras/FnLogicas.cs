namespace Ej19_LongitudPalabras
{
    internal class FnLogicas
    {
        public static List<string> ListaPalabras()
        {
            List<string> listaPalabras = new List<string>();
            int cantidad;

            cantidad = FnValidadores.EnteroPositivo("Ingrese la cantidad de palabras a cargar: ");

            for (int i = 1; i <= cantidad; i++)
            {
                listaPalabras.Add(FnValidadores.StringNoVacio($"Ingrese la palabra {i}: "));
            }
            return listaPalabras;
        }
    }
}
