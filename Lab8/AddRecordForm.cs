using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    public partial class AddRecordForm : Form
    {
        SubjectsForm mainForm;
        public AddRecordForm()
        {
            InitializeComponent();
        }

        public AddRecordForm(SubjectsForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            long id = mainForm.lastId == -1 ? mainForm.START_ID : mainForm.lastId+1;           
            if( subjCode.Text.Length == 0 ||
                lable2.Text.Length == 0 ||
                teacherName.Text.Length == 0 ||
                label4.Text.Length == 0 ||
                amountOfStudents.Text.Length == 0 ||
                label6.Text.Length == 0 ||
                label7.Text.Length == 0 
                )
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }         
            mainForm.xmlFile.Root.Add(new XElement("Subject", new XAttribute("ID", id),
                            new XElement("SubjectCode", subjCode.Text),
                            new XElement("Name", subjName.Text),
                            new XElement("TeacherName", teacherName.Text),
                            new XElement("GroupCode", groupCode.Text),
                            new XElement("AmountOfStudents", amountOfStudents.Text),
                            new XElement("AmountOFHoursLec", amountOfHoursLec.Text),
                            new XElement("AmountOfHoursPrac", amountOfHoursPrac.Text),
                            new XElement("CourseWork", courseWork.Text),
                            new XElement("FinalTest", finalTest.Text)
            ));
            mainForm.xmlFile.Save(mainForm.xmlPathName);
            mainForm.lastId = id;
            addRecordToDisplay();
            MessageBox.Show("Запись была успешно внесена!");
        }
        private void addRecordToDisplay()
        {
            XElement node = (XElement)mainForm.xmlFile.Root.LastNode;
            String record = node.LastAttribute + " ";
            foreach (XElement node2 in node.Nodes())
            {
                record += node2.Value + " ";
            }
            mainForm.recordsList.Items.Add(record);
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
