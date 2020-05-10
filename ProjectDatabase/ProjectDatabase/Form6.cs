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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int? id7;
        int? id8;
        Course1_documentationDataSet.studentDataTable datastudent = new Course1_documentationDataSet.studentDataTable();
        Course1_documentationDataSet.AssosiationDataTable dataA = new Course1_documentationDataSet.AssosiationDataTable();

        Course1_documentationDataSetTableAdapters.AssosiationTableAdapter a = new Course1_documentationDataSetTableAdapters.AssosiationTableAdapter();
        Course1_documentationDataSetTableAdapters.studentTableAdapter s = new Course1_documentationDataSetTableAdapters.studentTableAdapter();

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course1_documentationDataSet.Assosiation' table. You can move, or remove it, as needed.
            this.assosiationTableAdapter.Fill(this.course1_documentationDataSet.Assosiation);
            // TODO: This line of code loads data into the 'course1_documentationDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.course1_documentationDataSet.student);
            
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course1_documentationDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id7 = Convert.ToInt32(textBox1.Text);
            datastudent = s.GetDataBy3(id7);
            id8 = Convert.ToInt32(textBox1.Text);
            dataA = a.GetDataBy3(id8);

            studentDataGridView.DataSource = datastudent;
            studentDataGridView.Update();
            studentDataGridView.Refresh();
            assosiationDataGridView.DataSource = dataA;
            assosiationDataGridView.Update();
            assosiationDataGridView.Refresh();

        }
    }
}
