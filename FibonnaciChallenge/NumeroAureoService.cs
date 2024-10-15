namespace FibonnaciChallenge
{
    public class NumeroAureoService : INumeroAureoService
    {
        private readonly IFibonnaciService _fibonnaciService;

        public NumeroAureoService(IFibonnaciService fibonnaciService)
        {
            _fibonnaciService = fibonnaciService;

        }
        // Considero que estas dos funciones no se pueden refactorizar mucho más.
        // Lo que si que hice fue hacer que las de fibonaci devolvieran doubles en vez de enteros.
        public double ObtenerNumeroAureo()
        {
             return (1 + Math.Sqrt(5))/2;   
        }

        public double ObtenerNumeroAureoConFibonnaci(int posicion)
        {
            return _fibonnaciService.ObtenerNumeroFibonnaciEnPosicion(posicion + 1)/ _fibonnaciService.ObtenerNumeroFibonnaciEnPosicion(posicion);
        }

    }
}
