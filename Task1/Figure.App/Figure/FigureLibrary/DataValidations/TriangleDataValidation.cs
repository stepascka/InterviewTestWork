using FigureLabrary.Items;

namespace FigureLibrary.DataValidations
{
    /// <summary>
    /// Проверка данных 
    /// <b>Треугольника</b>
    /// </summary>
    internal static class TriangleDataValidation
    {
        /// <summary>
        /// Проверка треугольника на соответствие: значение сторон больше нуля
        /// </summary>
        /// <param name="triangleParams">Параметры треугольника</param>
        /// <returns>Признак проверки</returns>
        internal static bool CheckSidesAboveZero(TriangleParams triangleParams)
        {
            foreach(var side in triangleParams.Sides)
                if (side <= 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Проверка треугольника на соответствие: сторона меньше суммы двух остальных
        /// </summary>
        /// <param name="triangleParams">Параметры треугольника</param>
        /// <returns>Признак проверки</returns>
        internal static bool CheckSidesSumm(TriangleParams triangleParams)
        {
            return (
                triangleParams.Sides[0] < triangleParams.Sides[1] + triangleParams.Sides[2]
                && triangleParams.Sides[1] < triangleParams.Sides[0] + triangleParams.Sides[2]
                && triangleParams.Sides[2] < triangleParams.Sides[0] + triangleParams.Sides[1]
            );
        }
    }
}
