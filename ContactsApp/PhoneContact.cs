using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, хранящий информацию об одном контакте
    /// </summary>
    public class PhoneContact
    {
        private string _surname;
        /// <summary>
        /// метод с использование свойств set/get для фамилии
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Фамилия не может быть больше 50 символов");
                }
                else
                {
                    value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                    _surname = value;
                }
            }
        }
        private string _name;
        /// <summary>
        /// метод с использование свойств set/get для имени
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя не может быть больше 50 символов");
                }
                else
                {
                    value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                    _name = value;
                }
            }
        }
        private string _email;
        /// <summary>
        /// метод с использование свойств set/get для почты
        /// </summary>
        public string Emal
        {
            get { return _email; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Почта не может быть больше 50 символов");
                }
                else
                {
                    _email = value;
                }
            }
        }
        private string _idVK;
        /// <summary>
        /// метод с использование свойств set/get для idVk
        /// </summary>
        public string idVK
        {
            get { return _idVK; }
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("id в VK не может быть больше 15 символов");
                }
                else
                {
                    _idVK = value;
                }
            }
        }
        private DateTime _birthDate;
        private PhoneNumber _number;
        /// <summary>
        /// метод с использование свойств set/get для телефона
        /// </summary>
        public PhoneNumber Number
            {
            get {return _number;}
            set
            {
                _number = value;
            }
            }
        /// <summary>
        /// метод с использование свойств set/get для даты рождения
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                DateTime curDate = DateTime.Now;
                if (value.Year < 1900 && value > curDate)
                {
                    throw new ArgumentException("Год рождение не может быть меньше 1900");
                }
                else
                {            this.Number = new PhoneNumber();
                    _birthDate = value;
                }
            }
        }
     public PhoneContact()
        {

        }
        /// <summary>
        /// конструктор со всеми полями класса
        /// </summary>
        public PhoneContact(string Name, string surname, string email, string idVK, DateTime birthDate, long number)
        {
            this.BirthDate = birthDate;
            this.Emal = email;
            this.idVK = idVK;
            this.Name = Name;
            this.Surname = surname;
            this.Number = new PhoneNumber();
            this.Number.SetNumber = number;
        }
    }
}
