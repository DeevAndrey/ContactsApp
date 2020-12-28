﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp 
{
    /// <summary>
    /// Класс, хранящий информацию о контактах
    /// </summary>
    public class Project
    {
        public List<PhoneContact> ArrContacts;
        public Project()
            {
            ArrContacts = new List<PhoneContact>(200);
            }
    }
}
