namespace FigureLibrary
{
    /// <summary>
    /// Интерфейс для треугольников
    /// </summary>
    public interface ITriangle : IFigure
    {
        /// <summary>
        /// Определение признака прямоугольности треугольника
        /// </summary>
        /// <returns>Признак прямоугольности треугольника</returns>
        public bool IsRightTriangle();
    }
}
