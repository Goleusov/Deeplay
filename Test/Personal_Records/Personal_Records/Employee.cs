using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Records 
{
    public class Employee 
{
        public string firstName;// имя
        public string middledName;// фамилия
        public string lastName;// отчество
        public string dateOfBirth;// дата рождения
        public string gender;// пол
        public string jobTitle;// должность
        public string uniqueInform;// уникальная информация

        public void CopyData(Employee em)
        {
            this.firstName = em.firstName;
            this.middledName = em.middledName;
            this.lastName = em.lastName;
            this.dateOfBirth = em.dateOfBirth;
            this.gender = em.gender;
            this.jobTitle = em.jobTitle;
            this.uniqueInform = em.uniqueInform;
        }
        public Employee(string firstname, string middledname, string lastname, string dateOfBirth, string gender, string jobTitle, string uniqueInform)
        {
            this.firstName = firstname;
            this.middledName = middledname;
            this.lastName = lastname;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.jobTitle = jobTitle;
            this.uniqueInform = uniqueInform;
        }

        public string GetFullName()
        {
            return firstName + " " + middledName + " " + lastName;
        }

        public bool StringComparison(DataGridViewRow row)// сравнение объекта класса со строкой из таблицы 
        {
            string[] fullName = row.Cells[0].Value.ToString().Split(' ');
            if (fullName[0] == firstName && fullName[1] == middledName && fullName[2] == lastName && 
                row.Cells[1].Value.ToString() == dateOfBirth && row.Cells[2].Value.ToString() == gender &&
                row.Cells[3].Value.ToString() == jobTitle && row.Cells[4].Value.ToString() == uniqueInform)
            {
                return true;
            }
            return false;
        }

      

        public bool RecordUniquenessCheck(List<Employee> employees)// Проверка записи на уникальность в списке сотрудников
        {
            foreach (Employee em in employees)
            {
                if(this.firstName==em.firstName && this.middledName == em.middledName && this.lastName == em.lastName &&
                    this.dateOfBirth == em.dateOfBirth && this.gender == em.gender && this.jobTitle == em.jobTitle &&
                    this.uniqueInform == em.uniqueInform)
                {
                    return false;
                }
            }
            return true;

        }


    }
}
