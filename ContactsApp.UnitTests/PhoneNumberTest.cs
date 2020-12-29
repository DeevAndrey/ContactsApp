using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    class PhoneNumberTest
    {
        private PhoneNumber TestNumber;
        [SetUp]
        public void SetUp()
        {
            TestNumber = new PhoneNumber();
        }
        [Test(Description = "Позитивный тест геттера SetNumber")]
        public void TestNumberGet_CorrectValue()
        {
            var expected = 79998887766;

            TestNumber.SetNumber = expected;
            var actual = TestNumber.SetNumber;
            Assert.AreEqual(expected, actual, "Геттер SetNumber возвращает неправильный номер");
        }
        [Test(Description = "Позитивный тест сеттера SetNumber")]
        public void TestSurnameSet_CorrectValue()
        {
            TestNumber.SetNumber = 79997776655;
            var actual = TestNumber.SetNumber;
            Assert.AreEqual(actual, TestNumber.SetNumber, "Сеттер неправильно заполнил номер");
        }
        [Test(Description = "негативный тест сеттера SetNumber")]

        [TestCase(null, "Должно возникать исключение, если телефон - пустая строка",
                                TestName = "Присвоение пустой строки в качестве номера")]
        [TestCase(789, "Должно возникать исключение, если фамилия короче 11 символов",
                                TestName = "Присвоение неправильной фамилии короче 11 символов")]
        [TestCase(789878978788, "Должно возникать исключение, если фамилия длинее 12 символов",
                                TestName = "Присвоение неправильной фамилии длинее 12 символов")]
        public void TestSurnameSet_ArgumentException(long wrongNumber, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { TestNumber.SetNumber = wrongNumber; },
            message);
        }

    }
}
