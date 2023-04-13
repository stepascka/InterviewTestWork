namespace FigureLibrary.DataValidations
{
    /// <summary>
    /// Проверка данных 
    /// <b>Круга</b>
    /// </summary>
    internal static class CircleDataValidation
    {
        /// <summary>
        /// Проверка круга на соответствие: значение радиуса больше нуля
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Признак проверки</returns>
        internal static bool CheckRadiusAboveZero(double radius)
        {
            return radius > 0;
        }
    }
}
