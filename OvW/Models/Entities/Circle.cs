using System.Globalization;

namespace OvW.Models.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {

            Console.WriteLine($"Cor do circulo: {Color}");
            Console.WriteLine($"Tamanho do raio: {Radius.ToString("f2", CultureInfo.InstalledUICulture)}");
            Console.WriteLine();
            Console.WriteLine($"Tamanho da area: {Area().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            return "-.";
        }
    }
}
