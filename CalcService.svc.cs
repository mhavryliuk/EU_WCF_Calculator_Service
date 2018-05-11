namespace _20180412_WCF_Calculator_Service
{
    public class CalcService : ICalculator
    {
        #region Common Methods

        /// <inheritdoc />
        /// <summary>
        /// Проверка соединения.
        /// </summary>
        /// <returns>OK</returns>
        public string TestConnection()
        {
            return "OK";
        }

        #endregion

        #region Arithmetic

        /// <inheritdoc />
        /// <summary>
        /// Метод AddNumber() складывает два числа.
        /// </summary>
        /// <param name="number1">Слагаемое 1.</param>
        /// <param name="number2">Слагаемое 2.</param>
        /// <returns>Сумма двух чисел.</returns>
        public double AddNumber(double number1, double number2)
        {
            return number1 + number2;
        }

        /// <inheritdoc />
        /// <summary>
        /// Метод SubNumber() вычитает второе число из первого.
        /// </summary>
        /// <param name="number1">Уменьшаемое число.</param>
        /// <param name="number2">Вычитаемое число.</param>
        /// <returns>Разность.</returns>
        public double SubNumber(double number1, double number2)
        {
            return number1 - number2;
        }

        /// <inheritdoc />
        /// <summary>
        /// Метод MultNumber() умножает два числа.
        /// </summary>
        /// <param name="number1">Множитель 1.</param>
        /// <param name="number2">Множитель 2.</param>
        /// <returns>Произведение двух чисел.</returns>
        public double MultNumber(double number1, double number2)
        {
            return number1 * number2;
        }

        /// <inheritdoc />
        /// <summary>
        /// Метод DivNumber() делит первое число на второе.
        /// </summary>
        /// <param name="number1">Делимое.</param>
        /// <param name="number2">Делитель.</param>
        /// <returns>Частное.</returns>
        public double DivNumber(double number1, double number2)
        {
            return number1 / number2;
        }

        #endregion
    }
}