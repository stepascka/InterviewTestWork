namespace FigureLibrary.DataValidations
{
    /// <summary>
    /// Проверка данных 
    /// <b>Погрешности вычислений</b>
    /// </summary>
    internal static class CalculationErrorDataValidation
    {
        /// <summary>
        /// Проверка погрешности вычислений на соответствие: значение больше нуля
        /// </summary>
        /// <param name="calculationError">Погрешность вычислений</param>
        /// <returns>Признак проверки</returns>
        internal static bool CheckCalculationErrorAboveZero(double calculationError)
        {
            return calculationError > 0;
        }

        /// <summary>
        /// Проверка разрядя округления выходных значений на соответствие: значение больше нуля
        /// </summary>
        /// <param name="roundingDigit">Разряд округления выходных значений</param>
        /// <returns>Признак проверки</returns>
        internal static bool CheckRoundingDigitAboveZero(int roundingDigit)
        {
            return roundingDigit > 0;
        }
    }
}
