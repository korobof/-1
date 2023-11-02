using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БАЗА
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coursesBindingSource;
            bindingNavigator1.BindingSource = coursesBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.Specialties". При необходимости она может быть перемещена или удалена.
            this.specialtiesTableAdapter.Fill(this.dekanatDataSet.Specialties);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.dekanatDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.StudyPlans". При необходимости она может быть перемещена или удалена.
            this.studyPlansTableAdapter.Fill(this.dekanatDataSet.StudyPlans);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.dekanatDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.ExamResults". При необходимости она может быть перемещена или удалена.
            this.examResultsTableAdapter.Fill(this.dekanatDataSet.ExamResults);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.Courses". При необходимости она может быть перемещена или удалена.
            this.coursesTableAdapter.Fill(this.dekanatDataSet.Courses);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = examResultsBindingSource;
            bindingNavigator1.BindingSource = examResultsBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = groupsBindingSource;
            bindingNavigator1.BindingSource = groupsBindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studyPlansBindingSource;
            bindingNavigator1.BindingSource = studyPlansBindingSource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentsBindingSource;
            bindingNavigator1.BindingSource = studentsBindingSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = specialtiesBindingSource;
            bindingNavigator1.BindingSource = specialtiesBindingSource;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

        }
    }
}
