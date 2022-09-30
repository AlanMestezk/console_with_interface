
using OvW.Models.Enums;

namespace OvW.Models.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();

    }
}
