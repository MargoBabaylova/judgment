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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void судьиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.судьиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.judgmentDataSet);

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "judgmentDataSet.Судьи". При необходимости она может быть перемещена или удалена.
            this.судьиTableAdapter.Fill(this.judgmentDataSet.Судьи);

        }
    }
}
