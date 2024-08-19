using Xunit; // Подключаем библиотеку для тестирования
using CalculatorApp; // Подключаем наш основной проект, чтобы использовать класс Calculator

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        // Тест для сложения двух положительных чисел
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Создаем экземпляр калькулятора
            var calculator = new Calculator();
            
            // Задаем два числа для сложения
            int a = 5;
            int b = 3;
            
            // Суммируем числа с помощью метода Add
            int result = calculator.Add(a, b);
            
            // Проверяем, что результат равен ожидаемому значению 8
            Assert.Equal(8, result);
        }

        // Тест для сложения отрицательного и положительного числа
        [Fact]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            // Опять создаем калькулятор
            var calculator = new Calculator();
            
            // Снова задаем два числа, одно из которых отрицательное
            int a = -5;
            int b = 3;
            
            // Суммируем числа
            int result = calculator.Add(a, b);
            
            // Проверяем, что результат равен ожидаемому значению -2
            Assert.Equal(-2, result);
        }

        // Тест для сложения двух отрицательных чисел
        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // И снова создаем калькулятор
            var calculator = new Calculator();
            
            // В этот раз задаем два отрицательных числа
            int a = -5;
            int b = -3;
            
            // Суммируем числа
            int result = calculator.Add(a, b);
            
            // Проверяем, что результат равен ожидаемому значению -8
            Assert.Equal(-8, result);
        }
    }
}
