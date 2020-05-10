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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        Course1_documentationDataSet.coursesDataTable datacourse = new Course1_documentationDataSet.coursesDataTable();
        Course1_documentationDataSetTableAdapters.coursesTableAdapter course= new Course1_documentationDataSetTableAdapters.coursesTableAdapter();

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course1_documentationDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course1_documentationDataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.course1_documentationDataSet.courses);
            datacourse = course.GetDataBy1();
            coursesDataGridView.DataSource = datacourse;
            coursesDataGridView.Update();
            coursesDataGridView.Refresh();
        }

        private void coursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
