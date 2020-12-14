using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime BirthDate = new DateTime(1999, 12, 16);
            var contactsList = new Project();

            contactsList.ArrContacts = new PhoneContact[5];
            for (int i=0; i < 5; i++)
            {
                contactsList.ArrContacts[i] = new PhoneContact("Deev", "Andrey", "deev.andre@mail.ru", "112334", BirthDate, 79521544043);
            }


            MenegProject MakeClass = new MenegProject();
            contactsList = MakeClass.Load();
            contactsList.ArrContacts[0].Surname = "YelkiIgolki";
            MakeClass.Save(contactsList);
        }
    }
}
