namespace FibonnaciChallenge
{
    public class FibonnaciService : IFibonnaciService
    {
        public double ObtenerNumeroFibonnaciEnPosicion(int posicion)    // La solución clásica es una función recursiva
        {
            if (posicion <= 1)  // Casos especiales: n = 0 y n = 1
            {
                return posicion;
            }
            return ObtenerNumeroFibonnaciEnPosicion(posicion - 1) + ObtenerNumeroFibonnaciEnPosicion(posicion - 2); 
        }

        public int[] ObtenerSecuenciaFibonnaci(int numeroElementos)
        {
            int[] secuencia = new int[numeroElementos];
            if (numeroElementos == 0) return new int[] { };  // Casos especiales: n = 0 
            if (numeroElementos == 1) return new int[]{ 0};  // Casos especiales: n = 1
            secuencia[0] = 0;
            secuencia[1] = 1;
            for (int i = 2; i < numeroElementos; i++)
            {
                secuencia[i] = secuencia[i - 1] + secuencia[i - 2];
            }
            return secuencia;
        }

        //  Solución inicial: Considero que esta función es más bonita de leer
        //  pero escala peor en cuanto consumo de recursos conforme crece n.
        //
        //  public double[] ObtenerSecuenciaFibonnaci(int numeroElementos)
        //  {
        //      double[] secuencia = new double[numeroElementos];
        //
        //      for (int i = 0; i < numeroElementos; i++)
        //      {
        //       secuencia[i] = ObtenerNumeroFibonnaciEnPosicion(i);
        //      }
        //      return secuencia;
        //  }


    }
}