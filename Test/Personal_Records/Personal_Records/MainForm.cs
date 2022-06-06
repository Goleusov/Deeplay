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
    public partial class MainForm : Form
    {
        List<Employee> employees = new List<Employee>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)// запонение таблицы при создании
        {
            employees.Add(new Employee("Бобкова", "Алина", "Александровна", "10 сентября 1999 г.", "Женский", "Директор", "Феномен"));

            employees.Add(new Employee("Лядов", "Антон", "Михайлович", "5 августа 1989 г.", "Мужской", "Контролер", "Пожарная безопасность"));
            employees.Add(new Employee("Фроловский", "Владислав", "Генрихович", "6 октября 1971 г.", "Мужской", "Контролер", "Периферийные устройства"));


            employees.Add(new Employee("Достовалов", "Дмитрий", "Николаевич", "1 мая 1988 г.", "Мужской", "Руководитель подразделения", "Программисты"));
            employees.Add(new Employee("Голеусов", "Игорь", "Витальевич", "3 декабря 1998 г.", "Мужской", "Рабочий", "Достовалов Дмитрий Николаевич"));
            employees.Add(new Employee("Синицин", "Артем", "Александрович", "8 февраля 1998 г.", "Мужской", "Рабочий", "Достовалов Дмитрий Николаевич"));

            employees.Add(new Employee("Ломаев", "Сергей", "Дмитриевич", "25 сентября 1978 г.", "Мужской", "Руководитель подразделения", "Дизайнеры"));
            employees.Add(new Employee("Пашков", "Андрей", "Александрович", "13 июня 1990 г.", "Мужской", "Рабочий", "Ломаев Сергей Дмитриевич"));
            employees.Add(new Employee("Гардер", "Алексей", "Антонович", "30 августа 1992 г.", "Мужской", "Рабочий", "Ломаев Сергей Дмитриевич"));
            UpdateTable();

        }

        void UpdateTable()// обновление записей таблицы
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < employees.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells[0].Value = employees[i].GetFullName();
                dataGridView.Rows[rowNumber].Cells[1].Value = employees[i].dateOfBirth;
                dataGridView.Rows[rowNumber].Cells[2].Value = employees[i].gender;
                dataGridView.Rows[rowNumber].Cells[3].Value = employees[i].jobTitle;
                dataGridView.Rows[rowNumber].Cells[4].Value = employees[i].uniqueInform;
            }
       
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(employees);
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                employees.Add(addForm.employee);
                UpdateTable();
            }
        }

        Employee GetEmployee(DataGridViewRow row)// получение экземпляра класса по строке из таблицы
        {
            foreach (Employee em in employees)
            {
                if (em.StringComparison(row))
                    return em;
            }
            return null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            comboBoxFound.Items.Clear();
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить записи? ("+ dataGridView.SelectedRows.Count+")",
                "Удаление записи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    Employee tmpEmpl;
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        if ((tmpEmpl = GetEmployee(row)) != null)
                        {
                            employees.Remove(tmpEmpl);
                            dataGridView.Rows.Remove(row);
                        }
                    }
                }
            }
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            UpdateTable();
            labelSearch.Text = "";

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (dataGridView.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Выберите одну запись", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Employee em;
                    if ((em = GetEmployee(dataGridView.CurrentRow)) != null)
                    {
                        EditForm editForm = new EditForm(ref em,employees);
                        editForm.ShowDialog();
                        if (editForm.DialogResult == DialogResult.OK)
                        {
                            UpdateTable();
                        }
                    }

                }
            }
        }

     
        private void radioButtonJobTitle_CheckedChangedorCliked(object sender, EventArgs e)
        {
            comboBoxFound.Items.Clear();
            labelSearch.Text = "";
            comboBoxFound.Items.Add("Директор");
            comboBoxFound.Items.Add("Руководитель подразделения");
            comboBoxFound.Items.Add("Контролер");
            comboBoxFound.Items.Add("Рабочий");
            comboBoxFound.Text = comboBoxFound.Items[0].ToString();

        }

        private void radioButtonSubdivision_CheckedChangedOrCliked(object sender, EventArgs e)
        {
            comboBoxFound.Items.Clear();
            labelSearch.Text = "";
            List<string> listSubdivision = GetListSubdivision();
            foreach (string str in listSubdivision)
            {
                comboBoxFound.Items.Add(str);
            }
            if (comboBoxFound.Items.Count > 0)
            {
                comboBoxFound.Text = comboBoxFound.Items[0].ToString();
            }
            else
            {
                labelSearch.Text = "Подразделения отсутствуют в базе данных";
            }
        }

        private List<string> GetListSubdivision()// получение списка существующих подразделений
        {
            List<string> listSubdivision = new List<string>();
            foreach (Employee em in employees)
            {
                if (em.jobTitle== "Руководитель подразделения" && listSubdivision.BinarySearch(em.uniqueInform) < 0)
                {
                    listSubdivision.Add(em.uniqueInform);
                }
            }
            return listSubdivision;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(comboBoxFound.Items.Count == 0 && radioButtonSubdivision.Checked)
            {
                labelSearch.Text = "Подразделения отсутствуют в базе данных";
                return;
            }
            if (radioButtonJobTitle.Checked)
            {
                dataGridView.Rows.Clear();
                SearchJobTitle(comboBoxFound.Text);
            }
            if (radioButtonSubdivision.Checked)
            {
                dataGridView.Rows.Clear();
                SearchSubdivision(comboBoxFound.Text);
            }
        }

        private void AddNote(Employee em)//добавление записи в таблицу
        {
            int rowNumber = dataGridView.Rows.Add();
            dataGridView.Rows[rowNumber].Cells[0].Value = em.GetFullName();
            dataGridView.Rows[rowNumber].Cells[1].Value = em.dateOfBirth;
            dataGridView.Rows[rowNumber].Cells[2].Value = em.gender;
            dataGridView.Rows[rowNumber].Cells[3].Value = em.jobTitle;
            dataGridView.Rows[rowNumber].Cells[4].Value = em.uniqueInform;
        }

        private void SearchJobTitle(string jobTitle)// поиск должностей
        {
            foreach (Employee em in employees)
            {
                if (em.jobTitle == jobTitle)
                    AddNote(em);
            }
        }

        private void SearchSubdivision(string subdivision)// поиск руководителей и рабочих, относящихся к подразделению
        {
            foreach (Employee em in employees)
            {
                if (em.uniqueInform == subdivision)
                {
                    AddNote(em);
                    foreach (Employee tmpEm in employees)
                    {
                        if(tmpEm.uniqueInform== em.GetFullName())
                        {
                            AddNote(tmpEm);
                        }
                    }
                }
            }
        }



        private void buttonChangeJobTitle_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (dataGridView.SelectedRows.Count > 1)// проверка на выделение строки
                {
                    MessageBox.Show("Выберите одну запись", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Employee em;
                    if ((em = GetEmployee(dataGridView.CurrentRow)) != null)// проверка на получение обекста класса по строке
                    {
                        ChangeJobTitleForm titleForm = new ChangeJobTitleForm(ref em);// передача объекта класса по ссылке в форму изменения должности
                        titleForm.ShowDialog();
                        if (titleForm.DialogResult == DialogResult.OK)
                        {
                            UpdateTable();
                        }
                    }

                }
            }
        }

        private void comboBoxFound_Click(object sender, EventArgs e)
        {
            if (radioButtonSubdivision.Checked)
                radioButtonSubdivision_CheckedChangedOrCliked(sender, e);
            if (radioButtonJobTitle.Checked)
                radioButtonJobTitle_CheckedChangedorCliked(sender, e);
        }
    }
}
