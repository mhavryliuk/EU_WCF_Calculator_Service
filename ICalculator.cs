using System.ServiceModel;

namespace _20180412_WCF_Calculator_Service
{
    [ServiceContract]
    public interface ICalculator
    {
        #region Common Methods

        /// <summary>
        /// Проверка соединения.
        /// </summary>
        /// <returns>OK</returns>
        [OperationContract]
        string TestConnection();

        #endregion

        #region Arithmetic

        /// <summary>
        /// Метод AddNumber() складывает два числа.
        /// </summary>
        /// <param name="number1">Слагаемое 1.</param>
        /// <param name="number2">Слагаемое 2.</param>
        /// <returns>Сумма двух чисел.</returns>
        [OperationContract]
        double AddNumber(double number1, double number2);

        /// <summary>
        /// Метод SubNumber() вычитает второе число из первого.
        /// </summary>
        /// <param name="number1">Уменьшаемое число.</param>
        /// <param name="number2">Вычитаемое число.</param>
        /// <returns>Разность.</returns>
        [OperationContract]
        double SubNumber(double number1, double number2);

        /// <summary>
        /// Метод MultNumber() умножает два числа.
        /// </summary>
        /// <param name="number1">Множитель 1.</param>
        /// <param name="number2">Множитель 2.</param>
        /// <returns>Произведение двух чисел.</returns>
        [OperationContract]
        double MultNumber(double number1, double number2);

        /// <summary>
        /// Метод DivNumber() делит первое число на второе.
        /// </summary>
        /// <param name="number1">Делимое.</param>
        /// <param name="number2">Делитель.</param>
        /// <returns>Частное.</returns>
        [OperationContract]
        double DivNumber(double number1, double number2);

        #endregion
    }
}