using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace judgment
{
    public partial class EditJudges : Form
    {
        public EditJudges()
        {
            InitializeComponent();
        }

        private void addJudgeBtn_Click(object sender, EventArgs e)
        {
            var newForm = new AddJudge();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void EditJudges_Load(object sender, EventArgs e)
        {
            this.хроника_судейTableAdapter.Fill(this.judgmentDataSet.Хроника_судей);
            this.составыTableAdapter.Fill(this.judgmentDataSet.Составы);
            this.judgesTableAdapter.Fill(this.judgmentDataSet.Судьи);

            // TODO: Записать Информацию о том, в каком составе, и дата поступления судья из БД в currentHronicLabel
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /* TODO: Добавить сохранение новых данных о судье
             * Взять данные из полей: surnameTextBox, nameTextBox, middlenameTextBox, selectJudge, selectStructure, dateTimePicker
             * Запрос к базе на изменение таблицы "Судьи" полей Имя, Фамилия, Отчество по id судьи
             * Запрос к базе на добавление записи к "Хроники_судей" 
             */
        }

        private void selectJudge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int judgeId = (int)senderComboBox.SelectedValue;
            var result = this.хроника_судейTableAdapter.GetDataByJudgeId(judgeId);


            string resultStr;
            if (result.Count > 0)
            {
                resultStr = "Что-то хорошее получилось";
            }
            else
            {
                resultStr = "Нет сведений о хронике судьи";
            }

            currentHronicLabel.Text = resultStr;
        }
    }
}
