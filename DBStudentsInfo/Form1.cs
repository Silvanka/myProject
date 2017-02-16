using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBStudentsInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsInfoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsInfoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDBDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet1.StudentsInfoes' table. You can move, or remove it, as needed.
            this.studentsInfoesTableAdapter.Fill(this.studentDBDataSet1.StudentsInfoes);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.studentsInfoesBindingSource.RemoveCurrent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.studentsInfoesBindingSource.AddNew();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsInfoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDBDataSet1);
        }
    }
}
