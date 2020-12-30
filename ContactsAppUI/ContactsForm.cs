using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
namespace ContactsAppUI
{
    public partial class ContactsForm : Form
    {
        private int _countContacts = 0; // количеств
        private int index; // индекс к которому обращаемся при вызове окне edit/add
        string fileName = @"C:\R.G. Catalyst\json.txt"; // куда сохраняем данные
        private Project _allContacts = new Project(); // контакты которые мы сохраняем 
        private BindingList<PhoneContact> _formList;  //обновляющийся список

        public ContactsForm()
        {
            InitializeComponent();
            this.Text = "ContactApp";
            this.Size = new Size(800, 600);
            
            if (File.Exists(fileName)) // проверяем существует ли файл с данными 
            {
               _allContacts = MenegProject.Load(fileName);
                _countContacts = _allContacts.ArrContacts.Count;
            }
            DateTime curDate = DateTime.Now;
            BirthLabel.Text = "У них сегодня день рождение: ";
            for (int i=0; i<Project.FindBirthDay(_allContacts, curDate).ArrContacts.Count; i++)
            {
                BirthLabel.Text += Project.FindBirthDay(_allContacts, curDate).ArrContacts[i].Surname+", ";
            }
           
            textBoxCountAcc.Text = _countContacts.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                        EditForm editForm = new EditForm(); //создаем окно
                       
                        editForm.ShowDialog(); // открываем 

            if (editForm.Contact != null)
            {
                _allContacts.ArrContacts.Add(new PhoneContact()); // выделяем память под новую запись
                _allContacts.ArrContacts[_countContacts] = editForm.Contact;
                _countContacts++;
                UpdateListBox();
                textBoxCountAcc.Text = _countContacts.ToString();
            }
        }



        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex >= 0 && ContactsListBox.SelectedIndex < _countContacts)
            {
                index = ContactsListBox.SelectedIndex;
                EditForm editForm = new EditForm();
                editForm.Contact = _allContacts.ArrContacts[ContactsListBox.SelectedIndex];
                editForm.ShowDialog();
                if (editForm.Contact != null)
                {
                    _allContacts.ArrContacts[ContactsListBox.SelectedIndex] = editForm.Contact;
                    UpdateListBox();
                }
            }
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
            if (e.KeyValue == (char)Keys.Delete)
            {
                if (ContactsListBox.SelectedIndex >= 0 && ContactsListBox.SelectedIndex < _countContacts)
                {
                    ContactsListBox.Items.Remove(ContactsListBox.SelectedItem);
                    _allContacts.ArrContacts.Remove(_allContacts.ArrContacts[ContactsListBox.SelectedIndex]);
                    _countContacts--;
                    textBoxCountAcc.Text = _countContacts.ToString();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(); //создаем окно

            editForm.ShowDialog(); // открываем 

            if (editForm.Contact != null)
            {
                _allContacts.ArrContacts.Add(new PhoneContact()); // выделяем память под новую запись
                _allContacts.ArrContacts[_countContacts] = editForm.Contact;
                _countContacts++;
                UpdateListBox();
                textBoxCountAcc.Text = _countContacts.ToString();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ContactsListBox.Items.Remove(ContactsListBox.SelectedItem);
            _allContacts.ArrContacts.Remove(_allContacts.ArrContacts[ContactsListBox.SelectedIndex]);
            _countContacts--;
            textBoxCountAcc.Text = _countContacts.ToString();
        }

        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenegProject.SaveToFile(_allContacts, fileName);
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
                _allContacts = Project.SortArr(_allContacts);
                _formList = new BindingList<PhoneContact>(_allContacts.ArrContacts);
                for (int i=0;i<_formList.Count;i++)
                {
                    ContactsListBox.Items.Add(_allContacts.ArrContacts[i].Surname);
                }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ContactsListBox.SelectedIndex == -1) { ContactsListBox.SelectedIndex = index; }
            NameTextBox.Text = _allContacts.ArrContacts[ContactsListBox.SelectedIndex].Name;
            SurnameTextBox.Text = _allContacts.ArrContacts[ContactsListBox.SelectedIndex].Surname;
            dateBirthDay.Value = _allContacts.ArrContacts[ContactsListBox.SelectedIndex].BirthDate;
            EmailTextBox.Text = _allContacts.ArrContacts[ContactsListBox.SelectedIndex].Emal;
            VKtextBox.Text = _allContacts.ArrContacts[ContactsListBox.SelectedIndex].idVK;
            PhoneTextBox.Text = _allContacts.ArrContacts[ContactsListBox.SelectedIndex].Number.SetNumber.ToString();

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex >= 0 && ContactsListBox.SelectedIndex < _countContacts)
            {
                ContactsListBox.Items.Remove(ContactsListBox.SelectedItem);
                _allContacts.ArrContacts.Remove(_allContacts.ArrContacts[ContactsListBox.SelectedIndex]);
                _countContacts--;
                textBoxCountAcc.Text = _countContacts.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex >= 0 && ContactsListBox.SelectedIndex < _countContacts)
            {
                index = ContactsListBox.SelectedIndex;
                EditForm editForm = new EditForm();
                editForm.Contact = _allContacts.ArrContacts[ContactsListBox.SelectedIndex];
                editForm.ShowDialog();
                if (editForm.Contact != null)
                {
                    _allContacts.ArrContacts[ContactsListBox.SelectedIndex] = editForm.Contact;
                    UpdateListBox();

                }
            }
        }
        private void UpdateListBox()
        {
            _allContacts = Project.SortArr(_allContacts);
            ContactsListBox.Items.Clear();
            for (int i = 0; i < _allContacts.ArrContacts.Count; i++)
            {
                ContactsListBox.Items.Add(_allContacts.ArrContacts[i].Surname);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            
            ContactsListBox.Items.Clear();
            for (int i = 0; i < Project.FindArr(_allContacts,FindTextBox.Text).ArrContacts.Count; i++)
            {
                ContactsListBox.Items.Add(Project.FindArr(_allContacts, FindTextBox.Text).ArrContacts[i].Surname);
            }
        }


    }
}
