namespace judgment
{
    partial class EditJudges
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJudges));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.middlenameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.selectStructure = new System.Windows.Forms.ComboBox();
            this.составыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judgmentDataSet = new judgment.judgmentDataSet();
            this.selectJudge = new System.Windows.Forms.ComboBox();
            this.judgesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.currentHronicLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.addJudgeBtn = new System.Windows.Forms.Button();
            this.judgesTableAdapter = new judgment.judgmentDataSetTableAdapters.СудьиTableAdapter();
            this.составыTableAdapter = new judgment.judgmentDataSetTableAdapters.СоставыTableAdapter();
            this.хроника_судейTableAdapter = new judgment.judgmentDataSetTableAdapters.Хроника_судейTableAdapter();
            this.судьиTableAdapter = new judgment.judgmentDataSetTableAdapters.СудьиTableAdapter();
            this.successLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.составыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Изменить отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Изменить имя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Изменить фамилию:";
            // 
            // middlenameTextBox
            // 
            this.middlenameTextBox.Location = new System.Drawing.Point(328, 316);
            this.middlenameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.middlenameTextBox.Name = "middlenameTextBox";
            this.middlenameTextBox.Size = new System.Drawing.Size(296, 24);
            this.middlenameTextBox.TabIndex = 63;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(328, 274);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(296, 24);
            this.nameTextBox.TabIndex = 62;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(328, 233);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(296, 24);
            this.surnameTextBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 67;
            this.label1.Text = "Редактировать данные о судье:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Выберите судью:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "Укажите новый состав:";
            // 
            // selectStructure
            // 
            this.selectStructure.DataSource = this.составыBindingSource;
            this.selectStructure.DisplayMember = "Название";
            this.selectStructure.FormattingEnabled = true;
            this.selectStructure.Location = new System.Drawing.Point(328, 148);
            this.selectStructure.Margin = new System.Windows.Forms.Padding(4);
            this.selectStructure.Name = "selectStructure";
            this.selectStructure.Size = new System.Drawing.Size(298, 26);
            this.selectStructure.TabIndex = 70;
            this.selectStructure.ValueMember = "id";
            // 
            // составыBindingSource
            // 
            this.составыBindingSource.DataMember = "Составы";
            this.составыBindingSource.DataSource = this.judgmentDataSet;
            // 
            // judgmentDataSet
            // 
            this.judgmentDataSet.DataSetName = "judgmentDataSet";
            this.judgmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectJudge
            // 
            this.selectJudge.DataSource = this.judgesBindingSource;
            this.selectJudge.DisplayMember = "fullName";
            this.selectJudge.FormattingEnabled = true;
            this.selectJudge.Location = new System.Drawing.Point(328, 78);
            this.selectJudge.Margin = new System.Windows.Forms.Padding(4);
            this.selectJudge.Name = "selectJudge";
            this.selectJudge.Size = new System.Drawing.Size(298, 26);
            this.selectJudge.TabIndex = 68;
            this.selectJudge.ValueMember = "id";
            this.selectJudge.SelectedIndexChanged += new System.EventHandler(this.selectJudge_SelectedIndexChanged);
            // 
            // judgesBindingSource
            // 
            this.judgesBindingSource.DataMember = "Судьи";
            this.judgesBindingSource.DataSource = this.judgmentDataSet;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 193);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 18);
            this.label11.TabIndex = 75;
            this.label11.Text = "Дата начала периода:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(328, 191);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(296, 24);
            this.dateTimePicker.TabIndex = 74;
            // 
            // currentHronicLabel
            // 
            this.currentHronicLabel.AutoSize = true;
            this.currentHronicLabel.Location = new System.Drawing.Point(648, 78);
            this.currentHronicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentHronicLabel.Name = "currentHronicLabel";
            this.currentHronicLabel.Size = new System.Drawing.Size(272, 36);
            this.currentHronicLabel.TabIndex = 76;
            this.currentHronicLabel.Text = "Информация о том, в каком составе,\r\nкакой коллегии судья хранится в БД";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(477, 410);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 45);
            this.saveButton.TabIndex = 93;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addJudgeBtn
            // 
            this.addJudgeBtn.Location = new System.Drawing.Point(43, 410);
            this.addJudgeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addJudgeBtn.Name = "addJudgeBtn";
            this.addJudgeBtn.Size = new System.Drawing.Size(147, 45);
            this.addJudgeBtn.TabIndex = 94;
            this.addJudgeBtn.Text = "Добавить судью";
            this.addJudgeBtn.UseVisualStyleBackColor = true;
            this.addJudgeBtn.Click += new System.EventHandler(this.addJudgeBtn_Click);
            // 
            // judgesTableAdapter
            // 
            this.judgesTableAdapter.ClearBeforeFill = true;
            // 
            // составыTableAdapter
            // 
            this.составыTableAdapter.ClearBeforeFill = true;
            // 
            // хроника_судейTableAdapter
            // 
            this.хроника_судейTableAdapter.ClearBeforeFill = true;
            // 
            // судьиTableAdapter
            // 
            this.судьиTableAdapter.ClearBeforeFill = true;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.successLabel.Location = new System.Drawing.Point(248, 469);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(146, 18);
            this.successLabel.TabIndex = 95;
            this.successLabel.Text = "Данные обновлены";
            this.successLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorLabel.Location = new System.Drawing.Point(248, 469);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(357, 18);
            this.errorLabel.TabIndex = 96;
            this.errorLabel.Text = "В процессе обновления данных возникли ошибки";
            this.errorLabel.Visible = false;
            // 
            // EditJudges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 555);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.addJudgeBtn);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.currentHronicLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.selectStructure);
            this.Controls.Add(this.selectJudge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.middlenameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditJudges";
            this.Text = "Редактор судей";
            this.Load += new System.EventHandler(this.EditJudges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.составыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox middlenameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectStructure;
        private System.Windows.Forms.ComboBox selectJudge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label currentHronicLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addJudgeBtn;
        private judgmentDataSet judgmentDataSet;
        private System.Windows.Forms.BindingSource judgesBindingSource;
        private judgmentDataSetTableAdapters.СудьиTableAdapter judgesTableAdapter;
        private System.Windows.Forms.BindingSource составыBindingSource;
        private judgmentDataSetTableAdapters.СоставыTableAdapter составыTableAdapter;
        private judgmentDataSetTableAdapters.Хроника_судейTableAdapter хроника_судейTableAdapter;
        private judgmentDataSetTableAdapters.СудьиTableAdapter судьиTableAdapter;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}