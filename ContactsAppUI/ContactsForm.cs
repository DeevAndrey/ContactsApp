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
    public partial class ContactsForm : Form
    {
        
        private List<PhoneContact> _contacts = new List<PhoneContact>();
        public ContactsForm()
        {
            InitializeComponent();
            this.Text = "ContactApp";
            this.Size = new Size(800, 600);
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm aboutForm = new EditForm();
            aboutForm.ShowDialog();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditForm aboutForm = new EditForm();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1 )
            {
                AboutForm aboutForm = new AboutForm();
                aboutForm.ShowDialog();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PhoneContact newContact = new PhoneContact();
            newContact.Name = SurnameTextBox.Text;
            newContact.Number = new PhoneNumber(); 
            newContact.Number.SetNumber = Convert.ToInt64(PhoneTextBox.Text);
            newContact.Emal = EmailTextBox.Text;
            _contacts.Add(newContact);
            ContactsListBox.Items.Add(newContact.Name);

        }
    }
}
    /*        DateTime BirthDate = new DateTime(1999, 12, 16);
            var contactsList = new Project();

            contactsList.ArrContacts = new PhoneContact[5];
            for (int i=0; i < 5; i++)
            {
                contactsList.ArrContacts[i] = new PhoneContact("Deev", "Andrey", "deev.andre@mail.ru", "112334", BirthDate, 79521544043);
            }

            string fileName = @"C:\R.G. Catalyst\json.txt";
            MenegProject MakeClass = new MenegProject();
            contactsList = MenegProject.Load(fileName);
            contactsList.ArrContacts[0].Surname = "YelkiIgolki";
            MenegProject.SaveToFile(contactsList, fileName);*/