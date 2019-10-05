using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox.Text = "using Just to note that ElementAt() requires using System.Linq; ElementAt() using";
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic = DiccHelper.TextToDic(richTextBox.Text);
            dic = DiccHelper.SortByValueDes(dic);
            List<KeyValuePair<string, int>> listDic = dic.ToList<KeyValuePair<string, int>>();
            string printData = "";
            printData += "TOP 1 key: " + listDic.ElementAt(0).Key + "\t";
            printData += "Value: " + listDic.ElementAt(0).Value + "\n";
            printData += "TOP 2 key: " + listDic.ElementAt(1).Key + "\t";
            printData += "Value: " + listDic.ElementAt(1).Value + "\n";
            printData += "TOP 3 key: " + listDic.ElementAt(2).Key + "\t";
            printData += "Value: " + listDic.ElementAt(2).Value + "\n\n";

            printData += DiccHelper.PrintDic(dic);

            System.Windows.Forms.MessageBox.Show(printData);

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

