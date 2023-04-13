using FigureLibrary.Constants;
using FigureLibrary.DataValidations;

namespace FigureLibrary.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>Число Пи</summary>
        private  double PI { get; init; }

        /// <summary>Радиус круга</summary>
        private double Radius { get; init; }

        /// <summary>
        /// Конструктор 
        /// <b>Круга</b>
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <param name="calculationError">Погрешность вычислений</param>
        /// <param name="roundingDigit">Разряд округления выходных значений</param>
        /// <param name="determineErrorByRoundingDigit">Определение погрешности вычислений по разряду округления</param>
        public Circle(double radius, double? calculationError = null, int? roundingDigit = null, bool determineErrorByRoundingDigit = false)
            : base(calculationError, roundingDigit, determineErrorByRoundingDigit)
        {
            PI = ValuePI.PI;
            Radius = radius;
            Check();
        }

        /// <summary>
        /// Конструктор 
        /// <b>Круга</b>
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <param name="roundingDigit">Разряд округления выходных значений</param>
        /// <param name="determineErrorByRoundingDigit">Определение погрешности вычислений по разряду округления</param>
        public Circle(double radius, int roundingDigit, bool determineErrorByRoundingDigit = true)
            : this(radius, null, roundingDigit, determineErrorByRoundingDigit)
        {
        }

        #region Data

        /// <summary>
        /// <inheritdoc/>
        /// <b>Круга</b>
        /// </summary>
        /// <param name="func"><inheritdoc/></param>
        public override void Data(Action<string> func)
        {
            func($"Радиус круга: {Radius}.");
        }

        #endregion

        #region Area

        /// <summary>
        /// <inheritdoc/>
        /// <b>Круга</b>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override double Area()
        {
            return Math.Round(PI * Math.Pow(Radius, 2), RoundingDigit);
        }

        #endregion

        #region DataValidation

        /// <summary>
        /// Проверка данных 
        /// <b>Круга</b>
        /// </summary>
        private void Check()
        {
            if (!CircleDataValidation.CheckRadiusAboveZero(Radius))
                throw new ArgumentException("Радиус круга должна быть больше нуля.");
        }
        #endregion
    }
}
