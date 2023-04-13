namespace FigureLabrary.Items
{
    /// <summary>
    /// Параметры треугольника
    /// </summary>
    internal class TriangleParams
    {
        /// <summary>Стороны треугольника</summary>
        internal List<double> Sides { get; init; }

        /// <summary>Максимальная по значению сторона</summary>
        internal double MaxSide { get; init; }

        /// <summary>
        /// Конструктор
        /// <b>Параметров треугольника</b>
        /// </summary>
        /// <param name="side1">Сторона треугольника 1</param>
        /// <param name="side2">Сторона треугольника 2</param>
        /// <param name="side3">Сторона треугольника 3</param>
        internal TriangleParams(double side1, double side2, double side3)
        {
            Sides = new() { side1, side2, side3 };
            MaxSide = Sides.Max();
        }
    }
}
