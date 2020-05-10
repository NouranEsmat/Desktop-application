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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Course1_documentationDataSet.AssosiationDataTable datastudent = new Course1_documentationDataSet.AssosiationDataTable();

        Course1_documentationDataSetTableAdapters.AssosiationTableAdapter a = new Course1_documentationDataSetTableAdapters.AssosiationTableAdapter();
        int? id;
        private void assosiationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assosiationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course1_documentationDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course1_documentationDataSet.Assosiation' table. You can move, or remove it, as needed.
            this.assosiationTableAdapter.Fill(this.course1_documentationDataSet.Assosiation);

        }

        private void assosiationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox1.Text);
            datastudent = a.GetDataBy1(id);
            assosiationDataGridView.DataSource = datastudent;
            assosiationDataGridView.Update();
            assosiationDataGridView.Refresh();

        }
    }
}
