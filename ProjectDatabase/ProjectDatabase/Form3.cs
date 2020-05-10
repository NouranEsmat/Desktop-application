using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectDatabase
{
    public partial class Form3 : Form
    {
        string pname;
        Course1_documentationDataSetTableAdapters.AssosiationTableAdapter a = new Course1_documentationDataSetTableAdapters.AssosiationTableAdapter();
        Course1_documentationDataSet.studentDataTable datastudent = new Course1_documentationDataSet.studentDataTable();
        Course1_documentationDataSetTableAdapters.studentTableAdapter student = new Course1_documentationDataSetTableAdapters.studentTableAdapter();
        Course1_documentationDataSetTableAdapters.ProfessorTableAdapter professor = new Course1_documentationDataSetTableAdapters.ProfessorTableAdapter();
        int? ct = 0;

        public Form3()
        {
            InitializeComponent();
        }
    
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course1_documentationDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.course1_documentationDataSet.student);
            // TODO: This line of code loads data into the 'course1_documentationDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.course1_documentationDataSet.Professor);
            // professor.Insert();
            pname = professor.GETNAME(1);

        }
        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void professorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course1_documentationDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 start;
            start = new Form10();
            start.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 start;
            start = new Form7();
            start.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ct++;
                int d = Convert.ToInt32(textBox2.Text);
                a.UpdateAttandance(ct,d); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 start;
            start = new Form8();
            start.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
