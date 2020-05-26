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
        private int currentId;
        private string currentName;
        private string currentSurname;
        private string currentMiddlename;
        private DateTime currentDateStart;
        private int currentStructureId;
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

            var currentId = (int)selectJudge.SelectedValue;
            fetchJudge(currentId);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /* TODO: Добавить сохранение новых данных о судье
             * Взять данные из полей: surnameTextBox, nameTextBox, middlenameTextBox, selectJudge, selectStructure, dateTimePicker
             * Запрос к базе на изменение таблицы "Судьи" полей Имя, Фамилия, Отчество по id судьи
             * Запрос к базе на добавление записи к "Хроники_судей" 
             */
            var updateResult = this.судьиTableAdapter.UpdateJudge(currentId, currentName, currentSurname, currentMiddlename);
            Console.WriteLine($"Update result: {updateResult.ToString()}");
            if (updateResult > 0)
            {
                successLabel.Visible = true;
            } else
            {
                errorLabel.Visible = true;
            }
        }

        private void selectJudge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            currentId = (int)senderComboBox.SelectedValue;
            fetchJudge(currentId);
        }

        private void fetchJudge(int judgeId)
        {
            string infoStr = "";
            try
            {
                var hronicsResult = this.хроника_судейTableAdapter.GetDataByJudgeId(judgeId);
                var judgeResult = this.судьиTableAdapter.GetDataByJudgeId(judgeId)[0];

                currentName = judgeResult["Имя"].ToString();
                currentSurname = judgeResult["Фамилия"].ToString();
                currentMiddlename = judgeResult["Отчество"].ToString();

                currentDateStart = DateTime.Today;
                currentStructureId = 0;

                if (hronicsResult.Count > 0)
                {
                    var lastItem = hronicsResult.Last();
                    currentDateStart = (DateTime)lastItem["Дата_поступления"];
                    currentStructureId = (int)lastItem["id_состава"];
                    foreach (judgmentDataSet.Хроника_судейRow hronicsItem in hronicsResult)
                    {
                        string structureName = hronicsItem["Название_состава"].ToString(),
                            dateStart = hronicsItem["Дата_поступления"].ToString().Substring(0, hronicsItem["Дата_поступления"].ToString().Length - 8),
                            dateEnd = hronicsItem["Дата_ухода"].ToString() != "" ? hronicsItem["Дата_ухода"].ToString().Substring(0, hronicsItem["Дата_ухода"].ToString().Length - 8) : "по настоящее время";
                        infoStr += $"* {structureName}: {dateStart} - {dateEnd}\n";
                    }
                }
                else
                {
                    infoStr = "Нет сведений о хронике судьи";
                }
                setValuesToForm(currentName, currentSurname, currentMiddlename, currentDateStart, currentStructureId);
            }
            catch
            {
                infoStr = "В процессе получения данных возникла ошибка";
            }
            finally
            {
                currentHronicLabel.Text = infoStr;
            }

            void setValuesToForm(string currentName, string currentSurname, string currentMiddlename, DateTime currentDateStart, int currentStructureId)
            {
                surnameTextBox.Text = currentSurname;
                nameTextBox.Text = currentName;
                middlenameTextBox.Text = currentMiddlename;
                dateTimePicker.Value = currentDateStart;
                selectStructure.SelectedValue = currentStructureId;
            }
        }
    }
}
