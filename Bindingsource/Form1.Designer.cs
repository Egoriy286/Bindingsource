namespace Bindingsource
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            факультетBindingSource = new BindingSource(components);
            StudentImage = new DataGridViewImageColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            comboBox7 = new ComboBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button7 = new Button();
            textBox4 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            studentidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentgroupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentkursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentphotoDataGridViewImageColumn = new DataGridViewImageColumn();
            studentgenderDataGridViewCheckBoxColumn = new DataGridViewTextBoxColumn();
            studentmidmarkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Facultet = new DataGridViewComboBoxColumn();
            studentsBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)факультетBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // факультетBindingSource
            // 
            факультетBindingSource.DataSource = typeof(Факультет);
            // 
            // StudentImage
            // 
            StudentImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            StudentImage.DataPropertyName = "studentphoto";
            StudentImage.HeaderText = "Student Photo";
            StudentImage.MinimumWidth = 100;
            StudentImage.Name = "StudentImage";
            StudentImage.Resizable = DataGridViewTriState.True;
            StudentImage.SortMode = DataGridViewColumnSortMode.Automatic;
            StudentImage.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(152, 69);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ADD_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(238, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += REMOVE_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(319, 69);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(279, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += Name_changed;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(385, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += Group_changed;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(512, 40);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 10;
            comboBox3.SelectedIndexChanged += Kurs_changed;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(639, 40);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 12;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Location = new Point(400, 69);
            button4.Name = "button4";
            button4.Size = new Size(117, 23);
            button4.TabIndex = 13;
            button4.Text = "Скрыть Год";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top;
            numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Location = new Point(766, 40);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Bottom;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(138, 526);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 15;
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.Bottom;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(265, 526);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 17;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.Location = new Point(519, 525);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 18;
            button5.Text = "Запрос";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Zapros_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom;
            button6.Location = new Point(600, 525);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 19;
            button6.Text = "Reset";
            button6.UseVisualStyleBackColor = true;
            button6.Click += RESET_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Location = new Point(138, 497);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 16;
            // 
            // comboBox7
            // 
            comboBox7.Anchor = AnchorStyles.Bottom;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(392, 526);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(121, 23);
            comboBox7.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom;
            textBox3.Location = new Point(138, 571);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(138, 553);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 22;
            label1.Text = "Средний балл";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom;
            button7.Location = new Point(714, 525);
            button7.Name = "button7";
            button7.Size = new Size(172, 23);
            button7.TabIndex = 23;
            button7.Text = "Студент неудвол";
            button7.UseVisualStyleBackColor = true;
            button7.Click += MARK_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom;
            textBox4.Location = new Point(714, 497);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 26;
            label2.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentidDataGridViewTextBoxColumn, studentnameDataGridViewTextBoxColumn, studentgroupDataGridViewTextBoxColumn, studentdateDataGridViewTextBoxColumn, studentkursDataGridViewTextBoxColumn, studentphotoDataGridViewImageColumn, studentgenderDataGridViewCheckBoxColumn, studentmidmarkDataGridViewTextBoxColumn, Facultet });
            dataGridView1.DataSource = studentsBindingSource;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1031, 368);
            dataGridView1.TabIndex = 28;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            studentidDataGridViewTextBoxColumn.DataPropertyName = "studentid";
            studentidDataGridViewTextBoxColumn.Frozen = true;
            studentidDataGridViewTextBoxColumn.HeaderText = "studentid";
            studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            studentnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            studentnameDataGridViewTextBoxColumn.DataPropertyName = "studentname";
            studentnameDataGridViewTextBoxColumn.HeaderText = "studentname";
            studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            studentnameDataGridViewTextBoxColumn.Width = 102;
            // 
            // studentgroupDataGridViewTextBoxColumn
            // 
            studentgroupDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            studentgroupDataGridViewTextBoxColumn.DataPropertyName = "studentgroup";
            studentgroupDataGridViewTextBoxColumn.HeaderText = "studentgroup";
            studentgroupDataGridViewTextBoxColumn.Name = "studentgroupDataGridViewTextBoxColumn";
            // 
            // studentdateDataGridViewTextBoxColumn
            // 
            studentdateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            studentdateDataGridViewTextBoxColumn.DataPropertyName = "studentdate";
            studentdateDataGridViewTextBoxColumn.HeaderText = "studentdate";
            studentdateDataGridViewTextBoxColumn.Name = "studentdateDataGridViewTextBoxColumn";
            // 
            // studentkursDataGridViewTextBoxColumn
            // 
            studentkursDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            studentkursDataGridViewTextBoxColumn.DataPropertyName = "studentkurs";
            studentkursDataGridViewTextBoxColumn.HeaderText = "studentkurs";
            studentkursDataGridViewTextBoxColumn.Name = "studentkursDataGridViewTextBoxColumn";
            // 
            // studentphotoDataGridViewImageColumn
            // 
            studentphotoDataGridViewImageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            studentphotoDataGridViewImageColumn.DataPropertyName = "studentphoto";
            studentphotoDataGridViewImageColumn.HeaderText = "studentphoto";
            studentphotoDataGridViewImageColumn.MinimumWidth = 50;
            studentphotoDataGridViewImageColumn.Name = "studentphotoDataGridViewImageColumn";
            studentphotoDataGridViewImageColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            studentphotoDataGridViewImageColumn.Width = 104;
            // 
            // studentgenderDataGridViewCheckBoxColumn
            // 
            studentgenderDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            studentgenderDataGridViewCheckBoxColumn.DataPropertyName = "studentgender";
            studentgenderDataGridViewCheckBoxColumn.HeaderText = "studentgender";
            studentgenderDataGridViewCheckBoxColumn.Name = "studentgenderDataGridViewCheckBoxColumn";
            studentgenderDataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.True;
            studentgenderDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // studentmidmarkDataGridViewTextBoxColumn
            // 
            studentmidmarkDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            studentmidmarkDataGridViewTextBoxColumn.DataPropertyName = "studentmidmark";
            studentmidmarkDataGridViewTextBoxColumn.HeaderText = "studentmidmark";
            studentmidmarkDataGridViewTextBoxColumn.Name = "studentmidmarkDataGridViewTextBoxColumn";
            // 
            // Facultet
            // 
            Facultet.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Facultet.DataSource = факультетBindingSource;
            Facultet.DisplayMember = "Name";
            Facultet.HeaderText = "NumFacultet";
            Facultet.Name = "Facultet";
            Facultet.Resizable = DataGridViewTriState.True;
            Facultet.SortMode = DataGridViewColumnSortMode.Automatic;
            Facultet.ValueMember = "Value";
            // 
            // studentsBindingSource
            // 
            studentsBindingSource.DataSource = typeof(Students);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(152, 22);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 29;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(279, 22);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 30;
            label4.Text = "Год рождения";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(385, 22);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 31;
            label5.Text = "Группа";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(512, 22);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 32;
            label6.Text = "Курс";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(639, 22);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 33;
            label7.Text = "Пол";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(766, 22);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 34;
            label8.Text = "Балл";
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top;
            button8.Location = new Point(811, 69);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 35;
            button8.Text = "Random";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Random_Click;
            // 
            // button9
            // 
            button9.Location = new Point(913, 61);
            button9.Name = "button9";
            button9.Size = new Size(130, 38);
            button9.TabIndex = 36;
            button9.Text = "Отоюразить колическтво лет";
            button9.UseVisualStyleBackColor = true;
            button9.Click += yearsold_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 613);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(comboBox7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(comboBox6);
            Controls.Add(textBox1);
            Controls.Add(comboBox5);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)факультетBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private ComboBox comboBox7;
        private TextBox textBox3;
        private Label label1;
        private Button button7;
        private TextBox textBox4;
        private Label label2;
        private BindingSource факультетBindingSource;
        private DataGridViewImageColumn StudentImage;
        private DataGridViewTextBoxColumn Name1;
        private DataGridView dataGridView1;
        private BindingSource studentsBindingSource;
        private DataGridViewTextBoxColumn номерФакультетаDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button8;
        private DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentgroupDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentkursDataGridViewTextBoxColumn;
        private DataGridViewImageColumn studentphotoDataGridViewImageColumn;
        private DataGridViewTextBoxColumn studentgenderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn studentmidmarkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Facultet;
        private Button button9;
    }
}