namespace FigureLibrary
{
    /// <summary>
    /// Интерфейс для фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double Area();

        /// <summary>
        /// Данные
        /// </summary>
        /// <param name="func">Метод для работы с данными</param>
        public void Data(Action<string> func);

    }
}
