using Ejerciciopolimorfismo2024;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>
        {
            new Circulo(5),
            new Rectangulo(4, 6),
            new Triangulo(3, 7)
        };

        foreach (Figura figura in figuras)
        {
            Console.WriteLine($"El área de la figura es: {figura.CalcularArea()}");
        }
    }
}