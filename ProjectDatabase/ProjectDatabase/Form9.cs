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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Course1_documentationDataSetTableAdapters.studentTableAdapter s = new Course1_documentationDataSetTableAdapters.studentTableAdapter();
        string name;
        int? id;
        string password;
        string cname;
        int? sem;
        int? c_id;
        int s_id;
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            id = Convert.ToInt32(textBox2.Text);
            password= Convert.ToString(textBox3.Text);
            cname = textBox4.Text;
            sem= Convert.ToInt32(textBox5.Text);
            c_id= Convert.ToInt32(textBox6.Text);
            s_id= Convert.ToInt32(textBox7.Text);
            s.InsertStudent(name,id,password,cname,sem,c_id,s_id);
            

        }
    }
}
