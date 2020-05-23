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
    public partial class SearchRecordsForm : Form
    {
        SubjectsForm mainForm;
        public SearchRecordsForm()
        {
            InitializeComponent();
        }
        public SearchRecordsForm(SubjectsForm form)
        {
            InitializeComponent();
            mainForm = form;
        }
        private void surnameChangeCheck(object sender, EventArgs e)
        {
            surnameTextBox.Enabled = surnameCheck.Checked;
        }

        private void groupCodeCheck(object sender, EventArgs e)
        {
            groupCodeTextBox.Enabled = groupCheck.Checked;
        }

        private void courseChecked(object sender, EventArgs e)
        {
            courseText.Enabled = courseCheck.Checked;
        }

        private void finalTestChecked(object sender, EventArgs e)
        {
            finalTestText.Enabled = finalTestCheck.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//for tests
        public static int countRows(XDocument xmlFile, bool surCheck, bool grCheck, bool courCheck, bool ftestCheck,
                             string surname, string groupT, string courseWork, string finalTest)
        {
            IEnumerable<XNode> result = null;

            if (surCheck)
            {
                IEnumerable<XNode> temp = xmlFile.Root.Nodes();
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "TeacherName").Single()).Value == surname
                         select node;
            }

            if (grCheck)
            {
                IEnumerable<XNode> temp = result == null ? xmlFile.Root.Nodes() : result;
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "GroupCode").Single()).Value == groupT
                         select node;
            }

            if (courCheck)
            {
                IEnumerable<XNode> temp = result == null ? xmlFile.Root.Nodes() : result;
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "CourseWork").Single()).Value == courseWork
                         select node;
            }

            if (ftestCheck)
            {
                IEnumerable<XNode> temp = result == null ? xmlFile.Root.Nodes() : result;
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "FinalTest").Single()).Value == finalTest
                         select node;
            }
            if (result == null) return 0;
            return result.Count();
        }
        private IEnumerable<XNode> searchRecords()
        {
            IEnumerable<XNode> result = null;
            
            if(surnameCheck.Checked)
            {
                IEnumerable<XNode> temp = mainForm.xmlFile.Root.Nodes();
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "TeacherName").Single()).Value == surnameTextBox.Text
                         select node;
            }

            if (groupCheck.Checked)
            {
                IEnumerable<XNode> temp = result == null ?  mainForm.xmlFile.Root.Nodes() : result;
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "GroupCode").Single()).Value == groupCodeTextBox.Text
                         select node;
            }

            if (courseCheck.Checked)
            {
                IEnumerable<XNode> temp = result == null ? mainForm.xmlFile.Root.Nodes() : result;
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "CourseWork").Single()).Value == courseText.Text
                         select node;
            }

            if (finalTestCheck.Checked)
            {
                IEnumerable<XNode> temp = result == null ? mainForm.xmlFile.Root.Nodes() : result;
                result = from node in temp
                         where ((XElement)((XElement)node).Nodes()
                         .Where((n) => ((XElement)n).Name == "FinalTest").Single()).Value == finalTestText.Text
                         select node;
            }
            return result;
        }
        private void displayResult(IEnumerable<XNode> result)
        {
            SearchResultForm srf = new SearchResultForm();
            srf.Show();
            srf.DisplayResult(result);

        }

        private void searchButtonClick(object sender, EventArgs e)
        {
            IEnumerable<XNode> result = searchRecords();
            displayResult(result);
        }
    }
}
