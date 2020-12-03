using System;
using System.Collections;
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
    public partial class Exer1 : Form
    {
        public Exer1()
        {
            InitializeComponent();
        }
        Form _f;
        public Exer1(Form f)
        {
            InitializeComponent();
            _f = f;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            _f.Show();
        }

        ArrayList arrayList = new ArrayList();

        void arrayShow() {
            listBox1.Items.Clear();
            foreach(var a in arrayList)
            {
                listBox1.Items.Add(a.ToString());
            }
            count.Text = arrayList.Count.ToString();
        }
        private void Exer1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < 5; i++) {
                arrayList.Add(r.Next(0, 100));
            }
            arrayShow();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach (var a in arrayList) {
                if (listBox1.SelectedItem.ToString() == a.ToString())
                {
                    arrayList.Remove(a);
                    break;
                }
            }
            arrayShow();
        }

        private void add_Click(object sender, EventArgs e)
        {
            arrayList.Add(additem.Text);
            arrayShow();
        }

        private void search_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (var a in listBox1.Items) {
                if (a.ToString() == serchitem.Text)
                {
                    listBox1.SelectedItem = a;
                    flag = false;
                    break;
                }
            }
            if(flag)MessageBox.Show("Такого элемента нет", "Нам (не) жаль", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
