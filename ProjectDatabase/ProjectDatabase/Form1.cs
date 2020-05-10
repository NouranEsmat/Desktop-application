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
    public partial class Form1 : Form
    {
        Course1_documentationDataSetTableAdapters.ProfessorTableAdapter professor = new Course1_documentationDataSetTableAdapters.ProfessorTableAdapter();
        Course1_documentationDataSetTableAdapters.studentTableAdapter student = new Course1_documentationDataSetTableAdapters.studentTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }
        //static void Main(string[] args)
        //{
        //    SqlConnection ABC = new SqlConnection("Data Source=;Initial Catalog=Course1 documentation;Integrated Security=True");
        //    ABC.Open();
        //    SqlCommand command = new SqlCommand();
            
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            int v = Convert.ToInt32(textBox2.Text);
            string pass = textBox1.Text;
            if (v%2==0)
            {
                string pass3 = professor.GetPassword(v);
               
                if (pass==pass3)
                {

                    Form4 start;
                    start = new Form4();
                    start.Show();
                    
                }
            }
            else
            {
                string pass2 = student.GetPassword(v);
                
                if (pass==pass2)
                {
                     Form3 start;
                    start = new Form3();
                    start.Show();
                    
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 start;
            start = new Form2();
            start.Show();
        }
    }
}
