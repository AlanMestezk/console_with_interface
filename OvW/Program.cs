
using OvW.Models.Entities;
using OvW.Models.Enums;

namespace OvW
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape circulo = new Circle()
            {
                Color = Color.Branco,
                Radius = 3.9
            };

            IShape retangulo = new Rectangle()
            {
                Color = Color.Preto,
                Width = 6.8,
                Height = 9.1
            };

            Console.WriteLine();
            Console.WriteLine(circulo);
            Console.WriteLine();
            Console.WriteLine(retangulo);
            Console.WriteLine();
            Console.WriteLine("Developer by AlanMestezk");
        }
    }
}
