namespace EspcacioCalculadora
{

    public class Calculadora
    {
        public double dato = 0;
        public double resultado
        {
            get => dato;
            set => dato = value;
        }
        public void sumar(double termino)
        {
            dato += termino;
        }
        public void resta(double termino)
        {
            dato -= termino;
        }
        public void multiplicar(double termino)
        {
            dato *= termino;
        }

        public void dividir(double termino)
        {
            dato /= termino;
        }
        public void limpiar()
        {
            dato = 0;
        }
    }
}