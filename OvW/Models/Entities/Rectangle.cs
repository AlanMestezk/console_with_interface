using System.Globalization;

namespace OvW.Models.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            Console.WriteLine($"Cor do triangulo: {Color}");
            Console.WriteLine($"Largura do quadrado: {Width.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Altura do quadrado: {Height.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"Area do quadrado: {Area().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            return "-.";
        }
    }
}
