using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    public partial class SubjectsForm : Form
    {
        public long START_ID = 100;
        public long lastId = -1;
        public XDocument xmlFile;
        public String xmlPathName;
        //private const String path = "C:\\Users\\Maxim\\source\\repos\\Lab8\\Lab8\\bin\\Debug\\data.xml";
        public SubjectsForm()
        {
            InitializeComponent();
        }
        private bool isXml(String path)
        {
            string ext = path.Substring(path.LastIndexOf('.')+1);          
            return ext == "xml";
        }
        private void chooseFileClick(object sender, EventArgs e)
        {
            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                if (isXml(chooseFile.FileName))
                {
                    xmlFile = XDocument.Load(chooseFile.FileName);
                    xmlPathName = chooseFile.FileName;
                    try
                    {
                        lastId = xmlFile.Root.Nodes().Count() == 0 ? START_ID :
                                 long.Parse(((XElement)xmlFile.Root.LastNode).LastAttribute.Value);
                    }
                    catch { }
                    labelFile.Text = "Выбранный файл: " + chooseFile.FileName;

                }
                else
                {
                    labelFile.Text = "Неверный формат файла";
                }
            }
        }
        public void displayRecords()
        {
            if (xmlFile == null) return;
            recordsList.Items.Clear();
            String record = "";
            foreach (XElement node in xmlFile.Root.Nodes().ToList())
            {
                record += node.LastAttribute + " ";
                foreach (XElement node2 in node.Nodes())
                {
                    record += node2.Value + " ";
                }
                recordsList.Items.Add(record);
                record = "";
            }

        }
        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            displayRecords();
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            new AddRecordForm(this).Show();
        }

        private void deleteRecord()
        {
            String record = recordsList.SelectedItem.ToString();
            String id = record.Substring(record.IndexOf('\"')+1, 3);
            recordsList.Items.Remove(recordsList.SelectedItem);
            XNode elemToDelete = null;
            try
            {
                elemToDelete = xmlFile.Root.Nodes()
               .Where((node) => ((XElement)node).LastAttribute.Value == id).Single();
            }
            catch
            {
                MessageBox.Show("Данной записи нет");
                return;
            }
            elemToDelete.Remove();
            xmlFile.Save(xmlPathName);
            displayRecords();         
            MessageBox.Show("Запись успешно удалена");
        }
        private void deleteRecordBtn_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }

        private void findRecordsBtn_Click(object sender, EventArgs e)
        {
            new SearchRecordsForm(this).Show();
        }

        private void chooseFileMenuClick(object sender, EventArgs e)
        {
            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                if (isXml(chooseFile.FileName))
                {
                    xmlFile = XDocument.Load(chooseFile.FileName);
                    xmlPathName = chooseFile.FileName;
                    try
                    {
                        lastId = xmlFile.Root.Nodes().Count() == 0 ? START_ID :
                                 long.Parse(((XElement)xmlFile.Root.LastNode).LastAttribute.Value);
                    }
                    catch { }
                    labelFile.Text = "Выбранный файл: " + chooseFile.FileName;

                }
                else
                {
                    labelFile.Text = "Неверный формат файла";
                }
            }
        }
    }
}
