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
    public partial class SearchResultForm : Form
    {
        public SearchResultForm()
        {
            InitializeComponent();
        }
        
        public void DisplayResult(IEnumerable<XNode> result)
        {
            if (result == null || result.Count() == 0)
            {
                resultDisplayBox.Items.Add("Не найдены записи, соответствующие данным критериям");
                return;
            }

            String record = "";
            foreach (XElement node in result)
            {
                record += node.LastAttribute + " ";
                foreach (XElement node2 in node.Nodes())
                {
                    record += node2.Value + " ";
                }
                resultDisplayBox.Items.Add(record);
                record = "";
            }
        }

    }
}
