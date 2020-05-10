using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class Form4 : Form
    {
        Course1_documentationDataSetTableAdapters.studentTableAdapter s= new Course1_documentationDataSetTableAdapters.studentTableAdapter();
        Course1_documentationDataSetTableAdapters.AssosiationTableAdapter a = new Course1_documentationDataSetTableAdapters.AssosiationTableAdapter();
        int? id;
        int id2;
        int g;
        public Form4()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 start;
            start = new Form5();
            start.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 start;
            start = new Form6();
            start.Show();
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox4.Text);
            s.DeleteStudent(id);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id2 = Convert.ToInt32(textBox3.Text);
            g= Convert.ToInt32(textBox2.Text);
            a.UpdateGrades(g, id2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 start;
            start = new Form9();
            start.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
