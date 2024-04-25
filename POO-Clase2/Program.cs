﻿using POO_Clase2.Ejercicio_1;
using POO_Clase2.Ejercicio_2;
using POO_Clase2.Ejercicio_3;

namespace POO_Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Configurar el metodo Emitir sonido para que cada tipo de animal haga un sonido diferente
            // el metodo emitir sonido no devuelve nada (void), imprimir en consola el "sonido"

            Perro perro = new Perro() { Edad = 2, Nombre = "Buddy" };

            Gato gato = new Gato() { Edad = 5, Nombre = "Michi" };

            perro.EmitirSonido();

            gato.EmitirSonido();

            #endregion

            #region Ejercicio 2 
            // Agregar la propiedad "Peso" unicamente para las notebooks 
            // Agregar la propiedad "Refactorizada" que debe ser un booleano unicamente para las PcEscritorio
            // Instanciar una notebook y una pcEscritorio
            // Imprimir por pantalla las propiedades de cada uno
            #endregion

            Notebook miNotebook = new Notebook() { Peso = 2.5m };
            PcEscritorio miPcEscritorio = new PcEscritorio() { Refactorizada = false };

            Console.WriteLine("El peso de mi Notebook es: " + miNotebook.Peso);

            if (miPcEscritorio.Refactorizada)
                Console.WriteLine("Mi Pc de Escritorio es refactorizada");
            else
                Console.WriteLine("Mi Pc de Escritorio NO es refactorizada");

            #region Ejercicio 3

            // Crear la clase "FiguraGeometrica" la cual debe ser abstracta y tener 2 metodos, uno para calcular el area y el otro el perimetro
            // Crear dos clases "Circulo" y "Rectangulo" que deben heredar de "FiguraGeometrica"
            // Implementar los metodos para que cada figura calcule el area y el perimetro como corresponda
            // Instanciar las clases e imprimir los valores del area y el perimetro para cada figura
            // Mostrar los resultados por consola

            Rectangulo miRectangulo = new Rectangulo() { Base = 3m, Altura = 5m };
            Circulo miCirculo = new Circulo() { Radio = 2m };

            Console.WriteLine("El perímetro de mi rectángulo es: " + miRectangulo.CalcularPerimetro(miRectangulo) + " metros");
            Console.WriteLine("El perímetro de mi círculo es: " + miCirculo.CalcularPerimetro(miCirculo) + " metros");

            Console.WriteLine("El área de mi rectángulo es: " + miRectangulo.CalcularArea(miRectangulo) + " metros cuadrados");
            Console.WriteLine("El área de mi círculo es: " + miCirculo.CalcularArea(miCirculo) + " metros cuadrados");

            #endregion
        }
    }
}