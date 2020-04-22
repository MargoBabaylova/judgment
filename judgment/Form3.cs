using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace judgment
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "judgmentDataSet.Судьи". При необходимости она может быть перемещена или удалена.
            this.судьиTableAdapter.Fill(this.judgmentDataSet.Судьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "judgmentDataSet.Составы". При необходимости она может быть перемещена или удалена.
            this.составыTableAdapter.Fill(this.judgmentDataSet.Составы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "judgmentDataSet.Коллегии". При необходимости она может быть перемещена или удалена.
            this.коллегииTableAdapter.Fill(this.judgmentDataSet.Коллегии);

        }
    }
}
