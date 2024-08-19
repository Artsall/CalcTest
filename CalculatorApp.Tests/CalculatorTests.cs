using Xunit; // подключаю фреймворк для тестирования
using CalculatorApp; // подключаю основной проект, чтобы использовать класс Calculator

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        // тест для сложения двух положительных чисел
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // создаю экземпляр калькулятора
            var calculator = new Calculator();
            
            // задаю два числа для сложения
            int a = 5;
            int b = 3;
            
            // суммирую числа с помощью метода Add
            int result = calculator.Add(a, b);
            
            // проверяю, что результат равен ожидаемому значению 8
            Assert.Equal(8, result);
        }

        // тест для сложения отрицательного и положительного числа
        [Fact]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            // опять создаю калькулятор
            var calculator = new Calculator();
            
            // снова задаб два числа, одно из которых отрицательное
            int a = -5;
            int b = 3;
            
            // суммируем числа
            int result = calculator.Add(a, b);
            
            // проверяю, что результат равен ожидаемому значению -2
            Assert.Equal(-2, result);
        }

        // тест для сложения двух отрицательных чисел
        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // тоже создаем кальк
            var calculator = new Calculator();
            
            // в этот раз задаем два отрицательных числа
            int a = -5;
            int b = -3;
            
            // сумма чисел
            int result = calculator.Add(a, b);
            
            // проверяем, что результат равен ожидаемому значению -8
            Assert.Equal(-8, result);
        }
    }
}
