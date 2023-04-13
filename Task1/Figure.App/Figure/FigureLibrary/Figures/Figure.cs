using FigureLibrary.DataValidations;
using CalculationErrorConstant = FigureLibrary.Constants.CalculationError;

namespace FigureLibrary.Figures
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Figure : IFigure
    {
        /// <summary>Погрешность вычислений</summary>
        public double CalculationError { get; set; }

        /// <summary>Разряд округления выходных значений</summary>
        public int RoundingDigit { get; set; }

        /// <summary>Конструктор</summary>
        /// <param name="calculationError">Погрешность вычислений</param>
        /// <param name="roundingDigit">Разряд округления выходных значений</param>
        /// <param name="determineErrorByRoundingDigit">Определение погрешности вычислений по разряду округления</param>
        public Figure(double? calculationError = null, int? roundingDigit = 0, bool determineErrorByRoundingDigit = false)
        {
            CalculationError = (determineErrorByRoundingDigit && roundingDigit != null) 
                ? Math.Round(Math.Pow(0.1, (int)roundingDigit), (int)roundingDigit)
                : calculationError ?? CalculationErrorConstant.CALCULATION_ERROR;
            RoundingDigit = roundingDigit ?? (int)Math.Round(Math.Abs(Math.Log10(CalculationError)), MidpointRounding.ToPositiveInfinity);
            Check();
        }

        #region Data

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="func"><inheritdoc/></param>
        public abstract void Data(Action<string> func);

        #endregion

        #region Area

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public abstract double Area();

        #endregion

        #region DataValidation

        /// <summary>
        /// Проверка данных 
        /// <b>Фигуры</b>
        /// </summary>
        private void Check()
        {
            if (!CalculationErrorDataValidation.CheckCalculationErrorAboveZero(CalculationError))
                throw new ArgumentException("Погрешность вычислений должна быть больше нуля.");

            if (!CalculationErrorDataValidation.CheckRoundingDigitAboveZero(RoundingDigit))
                throw new ArgumentException("Разряд округления выходных значений должен быть больше нуля.");
        }

        #endregion
    }
}