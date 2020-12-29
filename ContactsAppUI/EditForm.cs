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
using System.IO;
namespace ContactsAppUI
{
   
    public partial class EditForm : Form
    {
        bool GlobalCheck;
        string incorrectSymbols = @"123456789!@#$%^&*()_+|-=\.,<>";
        private PhoneContact _contact;
        public PhoneContact Contact
        {
            get 
            {
                return _contact;
            }
            set 
            {
                _contact = value;
                if (_contact != null)
                {
                    NameTextBox.Text = _contact.Name;
                    SurnameTextBox.Text = _contact.Surname;
                    EmailTextBox.Text = _contact.Emal;
                    MaskPhoneBox.Text = _contact.Number.SetNumber.ToString();
                    VkTextBox.Text = _contact.idVK;
                    DateTimePicker.Value = _contact.BirthDate;
                }
            }
        }
        public EditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SurnameTextBox.BackColor == Color.Red || NameTextBox.BackColor == Color.Red || MaskPhoneBox.BackColor == Color.Red)
            {
                GlobalCheck = true;
            }
            else
            {
                GlobalCheck = false;
            }
            if (NameTextBox.Text != null && SurnameTextBox.Text != null && MaskPhoneBox.Text.Length == 12 && GlobalCheck == false
                && NameTextBox.Text != string.Empty && SurnameTextBox.Text != string.Empty)
            {
                _contact = new PhoneContact();
                _contact.Number = new PhoneNumber();
                _contact.Name = NameTextBox.Text;
                _contact.Surname = SurnameTextBox.Text;
                _contact.Emal = EmailTextBox.Text;
                _contact.Number.SetNumber = Convert.ToInt64(MaskPhoneBox.Text);
                _contact.idVK = VkTextBox.Text;
                _contact.BirthDate = DateTimePicker.Value;
                EditForm editForm = new EditForm();
                this.Close();
            }
            else
            {
                SurnameTextBox.BackColor = Color.Red;
                NameTextBox.BackColor = Color.Red;
                MaskPhoneBox.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _contact = null;
            this.Close();
        }



        private void SurnameTextBox_Leave(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i<SurnameTextBox.TextLength;i++)
            {
                for (int j = 0; j<incorrectSymbols.Length;j++)
                {
                    if (SurnameTextBox.Text[i] == incorrectSymbols[j])
                    {
                        check = true;
                    }
                }
            }
            if (check == true)
            {
                SurnameTextBox.BackColor = Color.Red;
            }
            else
            {
                SurnameTextBox.BackColor = Color.White;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < NameTextBox.TextLength; i++)
            {
                for (int j = 0; j < incorrectSymbols.Length; j++)
                {
                    if (NameTextBox.Text[i] == incorrectSymbols[j])
                    {
                        check = true;
                    }
                }
            }
            if (check == true)
            {
               NameTextBox.BackColor = Color.Red;
            }
            else
            {
               NameTextBox.BackColor = Color.White;
            }
        }

        private void MaskPhoneBox_Leave(object sender, EventArgs e)
        {
            if (MaskPhoneBox.Text.Length != 12)
            {
                MaskPhoneBox.BackColor = Color.Red;
            }
            else
            {
                MaskPhoneBox.BackColor = Color.White;
            }
        }
    }
}
