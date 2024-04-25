namespace POO_Clase2.Ejercicio_3
{
    internal class Rectangulo : FiguraGeometrica
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        public override decimal CalcularPerimetro(object rectangulo)
        {
            return 2 * (Base + Altura);
        }
        public override decimal CalcularArea(object rectangulo)
        {
            return Base * Altura;
        }
    }
}
