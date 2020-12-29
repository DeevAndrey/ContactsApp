using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;
using NUnit.Framework;
namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class PhoneContactTest
    {

        private PhoneContact TestContact;
        [SetUp]
        public void SetUp()
        {
            TestContact = new PhoneContact();
        }
        [Test(Description = "Позитивный тест геттера Surname")]
         public void TestSurnameGet_CorrectValue()
        {
            var expected = "Смирнов";
            
            TestContact.Surname = expected;
            var actual = TestContact.Surname;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Позитивный тест сеттера Surname")]
        public void TestSurnameSet_CorrectValue()
        {
            TestContact.Surname = "Смирнов";
            var actual = TestContact.Surname;
            Assert.AreEqual(actual, TestContact.Surname, "Сеттер неправильно заполнил фамилию");
        }
        [Test(Description = "негативный тест сеттера Surname")]

        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
                                TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если фамилия длиннее 40 символов",
                                TestName = "Присвоение неправильной фамилии больше 40 символов")]
        public void TestSurnameSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { TestContact.Surname = wrongSurname; },
            message);
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Иванов";

            TestContact.Name = expected;
            var actual = TestContact.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }
        [Test(Description = "Позитивный тест сеттера Name")]
        public void TestNameSet_CorrectValue()
        {
            TestContact.Name = "Иван";
            var actual = TestContact.Name;
            Assert.AreEqual(actual, TestContact.Name, "Сеттер неправильно заполнил имя");
        }
        [Test(Description = "негативный тест сеттера Name")]

        [TestCase("", "Должно возникать исключение, если имя - пустая строка",
                                TestName = "Присвоение пустой строки в качестве имени")]
        [TestCase("Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван", "Должно возникать исключение, если имя длиннее 40 символов",
                                TestName = "Присвоение неправильного имени больше 40 символов")]
        public void TestNameSet_ArgumentException(string wrongName, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { TestContact.Name = wrongName; },
            message);
        }

        [Test(Description = "Позитивный тест геттера Email")]
        public void TestMailGet_CorrectValue()
        {
            var expected = "deev.andre@mail.ru";

            TestContact.Emal = expected;
            var actual = TestContact.Emal;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильную почту");
        }
        [Test(Description = "Позитивный тест сеттера Email")]
        public void TestMailSet_CorrectValue()
        {
            TestContact.Emal = "deev.andre@mail.ru";
            var actual = TestContact.Emal;
            Assert.AreEqual(actual, TestContact.Emal, "Сеттер неправильно заполнил почту");
        }

        [Test(Description = "Присвоение неправильной почты больше 40 символов")]
        public void TestMailSet_ArgumentException()
        {
            var wrongSurname = "looooooooooooooooooooooooooooooooooooooooooooongmail.ru";
            Assert.Throws<ArgumentException>(
            () => { TestContact.Emal = wrongSurname; },
            "Должно возникать исключение, если почта больше 40 символов");
        }

        [Test(Description = "Позитивный тест геттера idVk")]
        public void TestIDVKGet_CorrectValue()
        {
            var expected = "vk.com/id221138";

            TestContact.idVK = expected;
            var actual = TestContact.idVK;
            Assert.AreEqual(expected, actual, "Геттер IdVk возвращает неправильный  vkid");
        }
        [Test(Description = "Позитивный тест сеттера VkId")]
        public void TestIdVkSet_CorrectValue()
        {
            TestContact.idVK = "vk.com/id221138";
            var actual = TestContact.idVK;
            Assert.AreEqual(actual, TestContact.idVK, "Сеттер неправильно заполнил idVk");
        }

        [Test(Description = "Присвоение неправильного id больше 15 символов")]
        public void TestIdVkSet_ArgumentException()
        {
            var wrongVkId = "vk.com/112233445566";
            Assert.Throws<ArgumentException>(
            () => { TestContact.idVK = wrongVkId; },
            "Должно возникать исключение, если id больше 15 символов");
        }
        
        [Test(Description = "Позитивный тест геттера birthday")]
        public void TestDateGet_CorrectValue()
        {
           DateTime expected = new DateTime(1999,1,1);

            TestContact.BirthDate = expected;
            var actual = TestContact.BirthDate;
            Assert.AreEqual(expected.Year, actual.Year, "Геттер BirthDay возвращает неправильную дату");
        }
        [Test(Description = "Позитивный тест сеттера BirthDate")]
        public void TestDateSet_CorrectValue()
        {
           var RightDate = new DateTime(1999,5,5);
            TestContact.BirthDate = RightDate;
            DateTime actual = new DateTime(1999, 5, 5); ;
            Assert.AreEqual(actual, TestContact.BirthDate, "Сеттер неправильно заполнил дату");
        }
        [Test(Description = "негативный тест сеттера BirthDate, когда null")]
        
        public void TestDateSet_null()
        {
            var wrongDate = new DateTime(); 
            Assert.Throws<ArgumentException>(
            () => { TestContact.BirthDate = wrongDate; },
            "Должно возникать исключение, если записываем пустое значение");
        }

        [Test(Description = "негативный тест сеттера BirthDate, когда год меньше 1700")]

        public void TestDateSet_minValue()
        {
            var wrongDate = new DateTime(1/1/1699);
            Assert.Throws<ArgumentException>(
            () => { TestContact.BirthDate = wrongDate; },
            "Должно возникать исключение, если записываем год меньше 1700");
        }
        [Test(Description = "негативный тест сеттера BirthDate, когда год больше нынешнего")]

        public void TestDateSet_maxValue()
        {
            var wrongDate = new DateTime(1 / 1 / 2050);
            Assert.Throws<ArgumentException>(
            () => { TestContact.BirthDate = wrongDate; },
            "Должно возникать исключение, если записываем год больше нынешнего");
        }


    }
}
