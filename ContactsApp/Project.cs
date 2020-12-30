using System;
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
        public static Project SortArr(Project project)
        {
            for (int j = 1; j < project.ArrContacts.Count; j++)
                for (int i = 0; i < project.ArrContacts.Count - 1; i++)
                    if (project.ArrContacts[i].Surname[0] > project.ArrContacts[i+1].Surname[0])
                            {
                        PhoneContact x = project.ArrContacts[i];
                        project.ArrContacts[i] = project.ArrContacts[i+1];
                        project.ArrContacts[i+1] = x;
                            }
            return project;
        }
        public static Project FindArr(Project project, string str)
        {
            Project FindArr = new Project();
            int count = 0;
            for (int i = 0; i<project.ArrContacts.Count;i++)
            {
                bool current = true;
                for (int j=0; j<str.Length;j++)
                {
                    if (str[j] != project.ArrContacts[i].Surname[j])
                    {
                        current = false;
                    }
                }
                if (current == true)
                {
                    FindArr.ArrContacts.Add(new PhoneContact());
                    FindArr.ArrContacts[count] = project.ArrContacts[i];
                    count++;
                }
            }
            return FindArr;
        }
        public static Project FindBirthDay(Project project, DateTime date)
        {
            Project FindBirthArr = new Project();
            int count=0;
            for (int i = 0; i < project.ArrContacts.Count; i++)
            {
                if (project.ArrContacts[i].BirthDate.Month == date.Month && project.ArrContacts[i].BirthDate.Day == date.Day)
                {
                    FindBirthArr.ArrContacts.Add(new PhoneContact());
                    FindBirthArr.ArrContacts[count] = project.ArrContacts[i];
                    count++;
                }
            }
            return FindBirthArr;
        }
    }
}
