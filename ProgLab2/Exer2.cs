using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgLab2
{
    public partial class Exer2 : Form
    {
        public Exer2()
        {
            InitializeComponent();
        }
        Form _f;
        public Exer2(Form f)
        {
            InitializeComponent();
            _f = f;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            _f.Show();
        }

        void listShow()
        {
            listBox1.Items.Clear();
            foreach (bool a in list)
            {
                listBox1.Items.Add(a.ToString());
            }
        }

        LinkedList<bool> list;
        Dictionary<int, bool> keyValuePairs;
        private void Exer2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            list = new LinkedList<bool>();
            insertIndex.Enabled = false;
            delFrom.Enabled = false;
            delTo.Enabled = false;
            inFirst.Checked = true;
            delFirst.Checked = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool item = Convert.ToBoolean(Convert.ToInt32(textBox1.Text));
            if (inFirst.Checked) list.AddFirst(item);
            if (inLast.Checked) list.AddLast(item);
            if (inBefore.Checked)
            {
                int index = Convert.ToInt32(insertIndex.Text);

                if (index > list.Count || index < 0) { MessageBox.Show(""); return; }
                if (index == 0) list.AddFirst(item);
                else
                if (index == list.Count) list.AddLast(item);
                else
                {
                    LinkedListNode<bool> a = list.First;
                    for (int i = 0; i < index; i++)
                    {
                        a = a.Next;
                    }
                    list.AddBefore(a, item);
                }
            }
            if (inAfter.Checked)
            {
                int index = Convert.ToInt32(insertIndex.Text);

                if (index > list.Count+1 || index < -1) { MessageBox.Show(""); return; }
                if (index == -1) list.AddFirst(item);
                else
                if (index == list.Count-1) list.AddLast(item);
                else
                {
                    LinkedListNode<bool> a = list.First;
                    for (int i = 0; i < index-1; i++)
                    {
                        a = a.Next;
                    }
                    list.AddAfter(a, item);
                }
            }
            listShow();
        }

        private void inAfter_CheckedChanged(object sender, EventArgs e)
        {
            insertIndex.Enabled = (sender as RadioButton).Checked;
            if ((sender as RadioButton).Checked)
            {
                inLabel.Text = (sender as RadioButton).Text;
            }
            
        }

        private void delRange_CheckedChanged(object sender, EventArgs e)
        {
            delFrom.Enabled = (sender as RadioButton).Checked;
            delTo.Enabled = (sender as RadioButton).Checked;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar!='0' && e.KeyChar!='1' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Exer2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (string.Equals((sender as Button).Name, @"CloseButton")) { }
            }
            catch (Exception ex) {
                Application.ExitThread();
            }
        }

        private void insertIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (delFirst.Checked) list.RemoveFirst();
            if (delLast.Checked) list.RemoveLast();
            if (delRange.Checked) {
                int from = Convert.ToInt32(delFrom.Text);
                int to = Convert.ToInt32(delTo.Text);
                if (from < 0) { MessageBox.Show("");return; }
                if (from >to) { MessageBox.Show(""); return; }
                LinkedListNode<bool> a = list.First;
                
                for (int i = 0; i < from-1; i++) {
                    a = a.Next;
                }
                for (int i = 0; i < to && a.Next != null; i++) {
                    list.Remove(a.Next);
                }
                if (from == 0) list.RemoveFirst();
            }
            listShow();
        }

        void showDictionary() {
            foreach (var a in keyValuePairs) {
                listBox2.Items.Add(a.ToString());
            }
        }
        private void make_Click(object sender, EventArgs e)
        {
            keyValuePairs = new Dictionary<int, bool>();
            int i = 0;
            foreach (var a in list) {
                keyValuePairs.Add(i, a);
                i+=2;
            }
            showDictionary();
        }

        private void search_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(searchIndex.Text);
            int i = 0;
            bool flag = false;
            foreach (int a in keyValuePairs.Keys) {
                if (a == index) {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag) listBox2.SelectedIndex = i;
        }
    }
}
