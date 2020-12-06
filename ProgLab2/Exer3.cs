using LabCSH;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgLab2
{
    public partial class Exer3 : Form
    {
        public Exer3()
        {
            InitializeComponent();
        }
        Form _f;
        public Exer3(Form f)
        {
            InitializeComponent();
            _f = f;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            _f.Show();
        }

        LinkedList<Player> players;
        Dictionary<int, Player> keyValuePairs;
        private void Exer3_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (string.Equals((sender as Button).Name, @"CloseButton")) { }
            }
            catch (Exception ex)
            {
                Application.ExitThread();
            }
        }

        void listShow() {
            listBox1.Items.Clear();
            foreach (var a in players) {
                listBox1.Items.Add(a.Name);
            }
        }
        private void Exer3_Load(object sender, EventArgs e)
        {
            players = new LinkedList<Player>();
            listBox1.Items.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Player item;
            if (random.NextDouble() > 0.9)
                item=new SmartMachine(_item.Text, ' ');
            else item =new Machine(_item.Text, ' ');
            if (inFirst.Checked) players.AddFirst(item);
            if (inLast.Checked) players.AddLast(item);
            if (inBefore.Checked)
            {
                int index = Convert.ToInt32(insertIndex.Text);

                if (index > players.Count || index < 0) { MessageBox.Show(""); return; }
                if (index == 0) players.AddFirst(item);
                else
                if (index == players.Count) players.AddLast(item);
                else
                {
                    LinkedListNode<Player> a = players.First;
                    for (int i = 0; i < index; i++)
                    {
                        a = a.Next;
                    }
                    players.AddBefore(a, item);
                }
            }
            if (inAfter.Checked)
            {
                int index = Convert.ToInt32(insertIndex.Text);

                if (index > players.Count + 1 || index < -1) { MessageBox.Show(""); return; }
                if (index == -1) players.AddFirst(item);
                else
                if (index == players.Count - 1) players.AddLast(item);
                else
                {
                    LinkedListNode<Player> a = players.First;
                    for (int i = 0; i < index - 1; i++)
                    {
                        a = a.Next;
                    }
                    players.AddAfter(a, item);
                }
            }
            listShow();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (delFirst.Checked) players.RemoveFirst();
            if (delLast.Checked) players.RemoveLast();
            if (delRange.Checked)
            {
                int from = Convert.ToInt32(delFrom.Text);
                int to = Convert.ToInt32(delTo.Text);
                if (from < 0) { MessageBox.Show(""); return; }
                if (from > to) { MessageBox.Show(""); return; }
                LinkedListNode<Player> a = players.First;

                for (int i = 0; i < from - 1; i++)
                {
                    a = a.Next;
                }
                for (int i = 0; i < to && a.Next != null; i++)
                {
                    players.Remove(a.Next);
                }
                if (from == 0) players.RemoveFirst();
            }
            listShow();
        }

        private void search_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(searchIndex.Text);
            int i = 0;
            bool flag = false;
            foreach (int a in keyValuePairs.Keys)
            {
                if (a == index)
                {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag) listBox2.SelectedIndex = i;
        }
        void showDictionary()
        {
            foreach (var a in keyValuePairs)
            {
                listBox2.Items.Add(a.ToString());
            }
        }
        private void make_Click(object sender, EventArgs e)
        {
            keyValuePairs = new Dictionary<int, Player>();
            int i = 0;
            foreach (var a in players)
            {
                keyValuePairs.Add(i, (a.Clone() as Player));
                i += 2;
            }
            showDictionary();
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
        private void insertIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Player> mass = new List<Player>();
            foreach (var a in players) {
                mass.Add(a);
            }
            mass.Sort();
            players = new LinkedList<Player>(mass);
            listShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Player> mass = new List<Player>();
            foreach (var a in players)
            {
                mass.Add(a);
            }
            mass.Sort(new PlayerComparer());
            players = new LinkedList<Player>(mass);
            listShow();
        }
    }
}
