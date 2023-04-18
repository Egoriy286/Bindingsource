using System;
using System.ComponentModel;
using System.Net.Cache;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Bindingsource
{
    public partial class Form1 : Form
    {
        public int i = 0;
        string studgr;
        string studft;
        bool put = false;
        Image image;
        BindingList<Students> IsStudents = new BindingList<Students>();
        List<Students> student = new List<Students>();
        List<Students> all = new List<Students>();

        public Form1()
        {
            InitializeComponent();
        }

        private string Gender(string temp)
        {
            string Sex = "Man";
            if (temp.Length > 1)
                if (temp[temp.Length - 1] == 'а')
                {
                    Sex = "Woman";
                }
            return Sex;
        }

        private void AddName(Students person, string group)
        {
            if (person.studentgroup == group)
            {
                comboBox1.Items.Add(person.studentname);
            }
            comboBox1.Enabled = true;
            comboBox1.SelectedIndex = 0; comboBox1.Focus();
        }

        private void AddGroup(Students person, string kurs)
        {

            if (person.studentkurs == kurs && person.studentgroup != studgr)
            {
                comboBox2.Items.Add(person.studentgroup);
                studgr = person.studentgroup;
            }
            comboBox2.Enabled = true;
            comboBox2.SelectedIndex = 0; comboBox2.Focus();
        }

        //private void AddKurs(Students person, string Facul)
        //{
        //    if (person.studentfacult.Name == Facul && person.studentgroup != studgr)
        //    {
        //        comboBox2.Items.Add(person.studentgroup);
        //        studgr = person.studentgroup;
        //    }
        //    comboBox2.Enabled = true;
        //    comboBox2.SelectedIndex = 0; comboBox2.Focus();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            string s;
            int k = 0, j = 0;

            studentsBindingSource.DataSource = IsStudents;

            string path = "C:\\Users\\egori\\source\\repos\\Bindingsource\\Bindingsource\\студ.txt";//путь к БД студентам
            StreamReader f1 = new StreamReader(path);

            while (!f1.EndOfStream)
            {
                s = f1.ReadLine();
                j = 0;
                foreach (string temp in s.Split(' '))
                {
                    all.Add(new Students { studentname = temp, studentgender = Gender(temp) });
                    break;
                }
                foreach (string temp in s.Split(' '))
                {
                    switch (j)
                    {
                        case 1:
                            all[k].studentkurs = temp;
                            break;
                        case 2:
                            all[k].studentgroup = temp;
                            break;
                        case 3:
                            all[k].Номер = temp;
                            break;
                        case 4:
                            all[k].studentdate = Convert.ToInt32(temp);
                            break;
                        case 5:
                            all[k].studentmidmark = Convert.ToInt32(temp);
                            break;
                        case 6:
                            all[k].studentfacult = new Факультет(temp);
                            break;
                        default:
                            break;
                    }
                    j++;
                }
                k++;
            }
            f1.Close();
            //all.Add(new Students { studentname = "ALL" });
            comboBox8.Items.Add("ИМИ");
            comboBox8.Items.Add("ГИ");
            comboBox8.Items.Add("ИТИ");
            textBox2.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button1.Enabled = false;
            comboBox4.Items.Add("Man");
            comboBox4.Items.Add("Woman");
            label2.Text = dataGridView1.ColumnCount.ToString();
            факультетBindingSource.DataSource = Факультет.GetChoices();
        }

        private void refresh()
        {
            studentsBindingSource.ResetBindings(false);
            факультетBindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (put == false)
            {
                put = true;
                dataGridView1.Columns[3].Visible = false;
                button4.Text = "Раскрыть год";
            }
            else
            {
                put = false;
                dataGridView1.Columns[3].Visible = true;
                button4.Text = "Скрыть год";
            }
        }

        private void Kurs_changed(object sender, EventArgs e)
        {
            string kurs = comboBox3.Text;
            string Facul = comboBox8.Text;
            comboBox2.Items.Clear();
            comboBox2.Enabled = false;
            comboBox1.Items.Clear();
            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            foreach (var temp in all)
            {
                if (temp.studentkurs == kurs && temp.studentfacult.Name == Facul)
                {
                    AddGroup(temp, kurs);
                }
            }
        }

        private void Group_changed(object sender, EventArgs e)
        {
            string group = comboBox2.Text;
            comboBox1.Items.Clear();
            comboBox1.Enabled = false;
            foreach (var temp in all)
            {
                if (temp.studentgroup == group)
                {
                    AddName(temp, group);
                }
            }
        }

        private void Name_changed(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            textBox2.Clear();
            textBox2.Enabled = true;
            comboBox4.Enabled = true;
            button1.Enabled = true;
            foreach (var temp in all)
            {
                if (temp.studentname == name)
                {
                    textBox2.Text = temp.studentdate.ToString();
                    if (temp.studentgender == "Man")
                        comboBox4.SelectedIndex = 0;
                    else comboBox4.SelectedIndex = 1;
                    numericUpDown1.Value = temp.studentmidmark;

                }
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            comboBox8.SelectedIndex = random.Next(0, comboBox8.Items.Count);

            comboBox3.SelectedIndex = random.Next(0, comboBox3.Items.Count);

            comboBox2.SelectedIndex = random.Next(0, comboBox2.Items.Count);

            comboBox1.SelectedIndex = random.Next(0, comboBox1.Items.Count);

            ADD_Click(sender, e);
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\egori\\source\\repos\\Bindingsource\\Bindingsource\\Студент.jpg";
            StreamReader image1 = new StreamReader(path);
            image = Image.FromFile(path);

            string Sex = "Woman";
            if (comboBox4.Text == "Man")
                Sex = "Man";

            student.Add(new Students(
                "ID00" + (student.Count + 1),
                comboBox1.Text,
                comboBox2.Text,
                Convert.ToInt32(textBox2.Text),
                comboBox3.Text,
                image,
                Sex,
                (int)numericUpDown1.Value,
                new Факультет(comboBox8.Text)
                ));
            i++;

            studentsBindingSource.DataSource = student;
            refresh();
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            if (IsStudents.Count > 0)
            {
                studentsBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                i--;
            }
            if (student.Count > 0)
            {
                student.RemoveAt(dataGridView1.CurrentRow.Index);
                i--;
            }
            refresh();
        }

        private void Zapros_Click(object sender, EventArgs e)
        {
            List<Students> Zapros = new List<Students>();
            string s1 = comboBox5.Text;
            string s2 = comboBox6.Text;
            string s3 = comboBox7.Text;
            int l = 0, sum = 0;

            for (int j = 0; j < student.Count; j++)
            {
                if (student[j].studentname == s1)
                    if (student[j].studentkurs == s3)
                        if (student[j].studentgroup == s2)
                        {
                            Zapros.Add(student[j]);
                            sum += student[j].studentmidmark;
                            l++;
                        }
            }
            if (l != 0)
                textBox3.Text = (sum / l).ToString();
            else
                textBox3.Text = "0";
            studentsBindingSource.DataSource = Zapros;
            refresh();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            studentsBindingSource.DataSource = student;
            refresh();
        }

        private void MARK_Click(object sender, EventArgs e)
        {
            int min = 0, k = 0;
            if (student.Count != -1)
                for (int j = 0; j < student.Count; j++)
                    if (min > student[j].studentmidmark)
                    {
                        min = student[j].studentmidmark;
                        k = j;
                    }
            textBox4.Text = student[k].studentname;
        }
        bool put1 = true;
        private void yearsold_click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn dgvAge = new DataGridViewTextBoxColumn() { Name = "dgvAge", HeaderText = "Возраст", DataPropertyName = "yearsold", Width = 100 };
            if (put1)
            {
                dataGridView1.Columns.Add(dgvAge);
                button9.Text = "Скрыть колическтво лет";
                put1 = false;
            }
            else
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
                button9.Text = "Отоюразить колическтво лет";
                put1 = true;
            }


        }

        private void Facul(object sender, EventArgs e)
        {
            string Facul = comboBox8.Text;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            int n = 5;
            if (Facul == "ИТИ")
                n = 4;
            for (int j = 1; j < n; j++)
                comboBox3.Items.Add(j.ToString());
            comboBox3.SelectedIndex= 0;
            Group_changed(sender, e);
        }
    }
}