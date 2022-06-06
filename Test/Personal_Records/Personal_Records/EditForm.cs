using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Records
{
    public partial class EditForm : Form
    {
        public Employee employee;
        List<Employee> employees;

        public EditForm(ref Employee em, List<Employee> listEmployee)
        {
            InitializeComponent();
            employee = em;
            employees = listEmployee;
        }

        // изменение видимости полей с уникальной информацией и надписей над ними, зависящих от выбора должности
        private void comboBoxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxUniqueInform1.Text = "";
            textBoxUniqueInform2.Text = "";
            textBoxUniqueInform3.Text = "";
            labelUniqInform2.Text = "";
            labelUniqInform3.Text = "";

            textBoxUniqueInform2.Visible = false;
            textBoxUniqueInform3.Visible = false;

            switch (comboBoxJobTitle.SelectedItem.ToString())
            {
                case "Директор":
                    labelUniqInform1.Text = "Название компании";
                    textBoxUniqueInform1.Visible = true;
                    break;

                case "Руководитель подразделения":
                    labelUniqInform1.Text = "Название подразделения";
                    textBoxUniqueInform1.Visible = true;
                    break;

                case "Контролер":
                    labelUniqInform1.Text = "Объект контроля";
                    textBoxUniqueInform1.Visible = true;
                    break;

                case "Рабочий":
                    labelUniqInform1.Text = "Имя руководителя";
                    labelUniqInform2.Text = "Фамилия руководителя";
                    labelUniqInform3.Text = "Отчество руководителя";
                    textBoxUniqueInform1.Visible = true;
                    textBoxUniqueInform2.Visible = true;
                    textBoxUniqueInform3.Visible = true;
                    break;
            }
        }

        // заполнение полей информацией редактируемой записи
        private void EditForm_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = employee.firstName;
            textBoxMiddleName.Text = employee.middledName;
            textBoxLastName.Text = employee.lastName;
            dateTimePicker.Text = employee.dateOfBirth;
            comboBoxGender.Text = employee.gender;
            comboBoxJobTitle.Text = employee.jobTitle;

            textBoxUniqueInform1.Visible = true;
            textBoxUniqueInform2.Visible = false;
            textBoxUniqueInform3.Visible = false;
            textBoxUniqueInform1.Text = employee.uniqueInform;

            switch (employee.jobTitle)
            {
                case "Директор":
                    labelUniqInform1.Text = "Название компании";
                    break;

                case "Руководитель подразделения":
                    labelUniqInform1.Text = "Название подразделения";
                    break;

                case "Контролер":
                    labelUniqInform1.Text = "Объект контроля";
                    break;

                case "Рабочий":
                    labelUniqInform1.Text = "Имя руководителя";
                    labelUniqInform2.Text = "Фамилия руководителя";
                    labelUniqInform3.Text = "Отчество руководителя";
                    textBoxUniqueInform2.Visible = true;
                    textBoxUniqueInform3.Visible = true;
                    string[] subs = employee.uniqueInform.Split(' ');

                    textBoxUniqueInform1.Text = subs[0];
                    textBoxUniqueInform2.Text = subs[1];
                    textBoxUniqueInform3.Text = subs[2];
                    break;
            }

        }

        private bool EditEmployee(string UniqInfo)// изменение информации записи (объекта класса) 
        {
            Employee em = new Employee(textBoxFirstName.Text, textBoxMiddleName.Text, textBoxLastName.Text, dateTimePicker.Text,
                        comboBoxGender.Text, comboBoxJobTitle.Text, UniqInfo);
            if (em.RecordUniquenessCheck(employees))// проверка созданного объекта класса на уникальность
            {
                employee.CopyData(em);// копирование данных в объект из главной формы, переданного по ссылке
                return true;
            }
            else
            {
                return false;
            }
            


        }
        bool SaveEmployee()//сохранение изменений записи
        {
            bool error = false;

            if (textBoxFirstName.Text != "" && textBoxMiddleName.Text != "" && textBoxLastName.Text != "" && dateTimePicker.Text != "")
            {
                string UniqInfo = "";
                if (comboBoxJobTitle.SelectedItem.ToString() == "Рабочий")// если рабочий, то идет проверка на заполненность полей руководителя
                {
                    if (textBoxUniqueInform1.Text != "" && textBoxUniqueInform2.Text != "" && textBoxUniqueInform3.Text != "")
                        UniqInfo = textBoxUniqueInform1.Text + " " + textBoxUniqueInform2.Text + " " + textBoxUniqueInform3.Text;
                    else
                        error = true;
                }
                else// любая другая должность, кроме рабочего и проверка заполненности полей
                {
                    if (textBoxUniqueInform1.Text != "")
                        UniqInfo = textBoxUniqueInform1.Text;
                    else
                        error = true;
                }
                if (!error)
                {
                    if (EditEmployee(UniqInfo))
                    {
                        return true;
                    }
                    else
                    {
                        labelError.Text = "Такая запись уже существует";
                        return false;
                    }
                }

            }
            labelError.Text = "Заполните все поля";
            return false;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SaveEmployee())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
