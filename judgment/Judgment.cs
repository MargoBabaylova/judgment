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
    public partial class Judgment : Form
    {
        public Judgment()
        {
            InitializeComponent();
        }

        private void editJudgesBtn_Click(object sender, EventArgs e)
        {
            var newForm = new EditJudges();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void LoadDataBtn_Click(object sender, EventArgs e)
        {
            var newForm = new LoadData();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void Form1Btn_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void Form2Btn_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void Form3Btn_Click(object sender, EventArgs e)
        {
            var newForm = new Form3();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void Form4Btn_Click(object sender, EventArgs e)
        {
            var newForm = new Form4();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void Form5Btn_Click(object sender, EventArgs e)
        {
            var newForm = new Form5();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void Form6Btn_Click(object sender, EventArgs e)
        {
            var newForm = new Form6();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void Form7Btn_Click(object sender, EventArgs e)
        {
            var newForm = new Form7();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }

        private void TableGenBtn_Click(object sender, EventArgs e)
        {
            var newForm = new TableGenerator();
            this.Hide();
            DialogResult response = newForm.ShowDialog();
            this.Show();
        }
    }
}
