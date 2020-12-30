using System;
using System.Collections.Generic;
using System.Text;
using ContactsApp;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    class MenegProjectTest
    {
        private Project actualproject = new Project();
        private Project expectedproject = new Project();


        [Test(Description = "Тест метода SaveToFile")]
        public void TestSaveToFile_CorrectValue()
        {
            var _path = @"C:\R.G. Catalyst\json.txt";
            PhoneNumber expectedphone = new PhoneNumber();
            expectedphone.SetNumber = 79998887766;

            PhoneContact expectedcontact = new PhoneContact();
            expectedcontact.Name = "petysdaa";
            expectedcontact.Surname = "pEtRoasdVS";
            expectedcontact.Number = expectedphone;
            expectedcontact.idVK = "12456";
            expectedcontact.BirthDate = new DateTime(2000, 12, 3);
            expectedcontact.Emal = "mail@mafffil.ru";
            PhoneContact actualphone = new PhoneContact();
           

            PhoneContact actualcontact = new PhoneContact();
            actualcontact.Name = "petya";
            actualcontact.Surname = "pEtRoVS";
            actualcontact.idVK = "12456";
            actualcontact.BirthDate = new DateTime(2000, 12, 3);
            actualcontact.Emal = "mail@mail.ru";


            actualproject.ArrContacts.Add(actualcontact);
            MenegProject.SaveToFile(actualproject, _path);
            expectedproject = null;
            expectedproject = MenegProject.Load(_path);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedproject.ArrContacts[0].Name, actualproject.ArrContacts[0].Name, "Метод SaveToFile неправильно сохраняет проект(имя)");
                Assert.AreEqual(expectedproject.ArrContacts[0].Surname, actualproject.ArrContacts[0].Surname, "Метод SaveToFile неправильно сохраняет проект(фамилия)");
                Assert.AreEqual(expectedproject.ArrContacts[0].idVK, actualproject.ArrContacts[0].idVK, "Метод SaveToFile неправильно сохраняет проект(айди-вк)");
                Assert.AreEqual(expectedproject.ArrContacts[0].Emal, actualproject.ArrContacts[0].Emal, "Метод SaveToFile неправильно сохраняет проект(почта)");
                Assert.AreEqual(expectedproject.ArrContacts[0].BirthDate, actualproject.ArrContacts[0].BirthDate, "Метод SaveToFile неправильно сохраняет проект(дата рождения)");
            });

        }

    }
}