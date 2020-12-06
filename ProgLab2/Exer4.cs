using LabCSH;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace ProgLab2
{
    public partial class Exer4 : Form
    {
        public Exer4()
        {
            InitializeComponent();
        }
        Form _f;
        public Exer4(Form f)
        {
            InitializeComponent();
            _f = f;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            _f.Show();
        }

        ObservableCollection<Player> list;  
        private void Exer4_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Exer4_Load(object sender, EventArgs e)
        {
            list = new ObservableCollection<Player>();
            list.CollectionChanged += changer;
            label2.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Player item;
            if (r.NextDouble() > 0.9) item = new SmartMachine(_item.Text, ' ');
            else item = new Machine(_item.Text, ' ');
            list.Add(item);
        }

        void changer(object sender, NotifyCollectionChangedEventArgs e) {
            listShow();
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    label2.Text = "Added";
                    break;
                case NotifyCollectionChangedAction.Remove:
                    label2.Text = "Deleted";
                    break;
            }
        }

        void listShow() {
            listBox1.Items.Clear();
            foreach (Player a in list) {
                listBox1.Items.Add(a.Name);
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            if (str == null) return;
            foreach (Player a in list) {
                if (a.Name == str)
                {
                    list.Remove(a);
                    return;
                }
            }
        }
    }
}
