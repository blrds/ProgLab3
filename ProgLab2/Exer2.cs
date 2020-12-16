using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
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

        private void Exer2_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("Test.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.Encoding = new ASCIIEncoding();
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    pupils.Add(new Pupil(csv.GetField("Surname"), csv.GetField("Name"), csv.GetField("Patronomyc"), 
                                         csv.GetField<DateTime>("Birthday"), csv.GetField<int>("Course"), csv.GetField("Group")));
                }
            }
        }

        List<Pupil> pupils = new List<Pupil>();
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
        private void Search_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (all.Checked) {
                if (first.Checked) listBox1.Items.Add(pupils.First().ToString());
                if (count.Checked) listBox1.Items.Add(pupils.Count());
                if (list.Checked) listBox1.Items.AddRange(pupils.ToArray());
            }
            if (first.Checked) {
                var newList = pupils.OrderBy(x=>x.Course);
                if (course.Checked) newList = newList.OrderBy(x => x.Course);
                if (surname.Checked) newList = newList.OrderBy(x => x.Surname);
                if (name.Checked) newList = newList.OrderBy(x => x.Name);
                if (patronomyc.Checked) newList = newList.OrderBy(x => x.Patronomyc);
                if (birthday.Checked) newList = newList.OrderBy(x => x.Birthday);
                if (group.Checked) newList = newList.OrderBy(x => x.Group);
                listBox1.Items.Add(newList.First().ToString());
                return;
            }
            if (course.Checked)
            {
                int i;
                if (!Int32.TryParse(textBox1.Text, out i))
                {
                    MessageBox.Show("Неверный курс", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
            }
            if (birthday.Checked)
            {
                DateTime i;
                if (!DateTime.TryParse(textBox1.Text, out i))
                {
                    MessageBox.Show("Неверная дата", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
            }
            var newList1 = pupils.Where(x=>x.Name!="");

            if (course.Checked) newList1 = newList1.Where(x => x.Course==Convert.ToInt32(textBox1.Text));
            if (surname.Checked) newList1 = newList1.Where(x => x.Surname.Contains(textBox1.Text));
            if (name.Checked) newList1 = newList1.Where(x => x.Name.Contains(textBox1.Text));
            if (patronomyc.Checked) newList1 = newList1.Where(x => x.Patronomyc.Contains(textBox1.Text));
            if (birthday.Checked) newList1 = newList1.Where(x => x.Birthday == DateTime.Parse(textBox1.Text));
            if (group.Checked) newList1 = newList1.Where(x => x.Group.Contains(textBox1.Text));

            if (list.Checked) listBox1.Items.AddRange(newList1.ToArray());
            else listBox1.Items.Add(newList1.Count());
        }
    }
}
