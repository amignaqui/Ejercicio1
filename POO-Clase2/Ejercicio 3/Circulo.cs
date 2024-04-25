namespace POO_Clase2.Ejercicio_3
{
    internal class Circulo : FiguraGeometrica
    {
        public decimal Radio { get; set; }
        const decimal PI = 3.141m;

        public override decimal CalcularPerimetro(object circulo)
        {
            return 2 * Radio * PI;
        }
        public override decimal CalcularArea(object circulo)
        {
            return PI * Radio * Radio;
        }
    }
}
