using FigureLibrary.DataValidations;
using FigureLabrary.Items;

namespace FigureLibrary.Figures
{
    /// <summary>
    /// Трегольник
    /// </summary>
    public class Triangle : Figure, ITriangle
    {
        /// <summary>Параметры треугольника</summary>
        private TriangleParams Params { get; init; }

        /// <summary>
        /// Конструктор 
        /// <b>Треугольника</b>
        /// </summary>
        /// <param name="side1">Сторона треугольника 1</param>
        /// <param name="side2">Сторона треугольника 2</param>
        /// <param name="side3">Сторона треугольника 3</param>
        /// <param name="calculationError">Погрешность вычислений</param>
        /// <param name="roundingDigit">Разряд округления выходных значений</param>
        /// <param name="determineErrorByRoundingDigit">Определение погрешности вычислений по разряду округления</param>
        public Triangle(double side1, double side2, double side3, double? calculationError = null, int? roundingDigit = null, bool determineErrorByRoundingDigit = false)
            : base(calculationError, roundingDigit, determineErrorByRoundingDigit)
        { 
            Params = new (side1, side2, side3);
            Check();
        }

        /// <summary>
        /// Конструктор 
        /// <b>Треугольника</b>
        /// </summary>
        /// <param name="side1">Сторона треугольника 1</param>
        /// <param name="side2">Сторона треугольника 2</param>
        /// <param name="side3">Сторона треугольника 3</param>
        /// <param name="roundingDigit">Разряд округления выходных значений</param>
        /// <param name="determineErrorByRoundingDigit">Определение погрешности вычислений по разряду округления</param>
        public Triangle(double side1, double side2, double side3, int roundingDigit, bool determineErrorByRoundingDigit = true)
            : this(side1, side2, side3, null, roundingDigit, determineErrorByRoundingDigit)
        {
        }

        #region Data

        /// <summary>
        /// <inheritdoc/>
        /// <b>Треугольника</b>
        /// </summary>
        /// <param name="func"><inheritdoc/></param>
        public override void Data(Action<string> func)
        {
            func($"Стороны треугольника: {Params.Sides[0]}, {Params.Sides[1]}, {Params.Sides[2]}.");
        }

        #endregion

        #region Area

        /// <summary>
        /// <inheritdoc/>
        /// <b>Треугольника</b>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override double Area()
        {
            var semiPerimeter = SemiPerimeter();

            var temp = semiPerimeter;
            foreach(var side in Params.Sides)
                temp *= (semiPerimeter - side);

            return Math.Round(Math.Sqrt(temp), RoundingDigit);
        }

        /// <summary>
        /// Вычисление полу-периметра 
        /// <b>Треугольника</b>
        /// </summary>
        /// <returns>Полу-периметр треугольника</returns>
        private double SemiPerimeter()
        {
            return 0.5 * Params.Sides.Sum();
        }

        #endregion

        #region RightTriangle

        /// <inheritdoc/>
        public bool IsRightTriangle()
        {
            var firstMaxSideIndex = Params.Sides.IndexOf(Params.MaxSide);

            double sqrSum = 0;
            foreach (var side in Params.Sides)
                if (Params.Sides.IndexOf(side) != firstMaxSideIndex)
                    sqrSum += Math.Pow(side, 2);

            if (Math.Abs(sqrSum - Math.Pow(Params.MaxSide, 2)) < CalculationError)
                return true;

            return false;
        }

        #endregion

        #region DataValidation

        /// <summary>
        /// Проверка данных 
        /// <b>Треугольника</b>
        /// </summary>
        private void Check()
        {
            if (!TriangleDataValidation.CheckSidesAboveZero(Params))
                throw new ArgumentException("Сторона треугольника должна быть больше нуля.");

            if (!TriangleDataValidation.CheckSidesSumm(Params))
                throw new ArgumentException("Сторона треугольника должна быть меньше суммы оставшихся сторон.");
        }

        #endregion
    }
}
