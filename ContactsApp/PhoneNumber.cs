using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContactsApp
{ 
    /// <summary>
    /// Класс хранящий информацию о номере телефона
    /// </summary>
    public class PhoneNumber
    {

        private long _number;
        /// <summary>
        /// Метод класса для заполнения или получения номера(set/get)
        /// </summary>
        public long SetNumber
        {
            get { return _number; }
            set
            {                
                if (value >= 70000000000 && value <= 79999999999)
                {
                    _number = value;
                }
                else
                {
                    throw new ArgumentException(" Номер должен начинается с 7 и состоять из 11 цифр");
                }
            }
        }


    }


 

}
    

