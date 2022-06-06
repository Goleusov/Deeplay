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
    public partial class AddForm : Form
    {
        public Employee employee;
        List<Employee> employees;

        public AddForm(List<Employee> listEmployee)
        {
            InitializeComponent();
            employees = listEmployee;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            labelUniqInform1.Text = "";
            labelUniqInform2.Text = "";
            labelUniqInform3.Text = "";
            textBoxUniqueInform1.Visible = false;
            textBoxUniqueInform2.Visible = false;
            textBoxUniqueInform3.Visible = false;
        }

        // изменение видимости полей с уникальной информацией и надписей над ними, зависящих от выбора должности
        private void comboBoxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelUniqInform2.Text = "";
            labelUniqInform3.Text = "";
            textBoxUniqueInform2.Visible = false;
            textBoxUniqueInform3.Visible = false;
            textBoxUniqueInform1.Visible = true;

            switch (comboBoxJobTitle.SelectedItem.ToString()) 
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
                    break;
            }
        }

        bool CreateEmployee()// создание записи
        {
            bool error = false;

            if (textBoxFirstName.Text != "" && textBoxMiddleName.Text != "" && textBoxLastName.Text != "" && dateTimePicker.Text != "" &&
                comboBoxGender.Text != "" && comboBoxJobTitle.Text != "") // проверка на заполненность полей
            {
                string UniqInfo = "";
                if (comboBoxJobTitle.SelectedItem.ToString() == "Рабочий") // если рабочий, то идет проверка на заполненность полей руководителя
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
                if (!error)// если ошибок нет, то создается объект класса
                {
                    employee = new Employee(textBoxFirstName.Text, textBoxMiddleName.Text, textBoxLastName.Text, dateTimePicker.Text,
                        comboBoxGender.Text, comboBoxJobTitle.Text, UniqInfo);

                    if (employee.RecordUniquenessCheck(employees))
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(CreateEmployee())
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
