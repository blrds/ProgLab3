using System;
using System.Collections.Generic;
using System.Linq;
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

        private void Exer1_Load(object sender, EventArgs e)
        {
               
        }
        List<Month> months = new List<Month>{
                new Month{Name="January", Season="Winter"},
                new Month{Name="February", Season="Winter"},
                new Month{Name="March", Season="Spring"},
                new Month{Name="April", Season="Spring"},
                new Month{Name="May", Season="Spring"},
                new Month{Name="June", Season="Summer"},
                new Month{Name="Jule", Season="Summer"},
                new Month{Name="August", Season="Summer"},
                new Month{Name="September", Season="Autumn"},
                new Month{Name="October", Season="Autumn"},
                new Month{Name="November", Season="Autumn"},
                new Month{Name="December", Season="Winter"}
            };
        private void Exer1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Index_Click(object sender, EventArgs e)
        {
            var newList = months.Where(x => x.Name.Length > Convert.ToInt32(textBox1.Text));
            label1.Text = string.Join("\n", newList);
        }

        private void Season_Click(object sender, EventArgs e)
        {

            var newList = months.Where(x =>(
                (x.Season.Contains("Winter") && Winter.Checked) ||
                (x.Season.Contains("Spring") && Spring.Checked) ||
                (x.Season.Contains("Summer") && Summer.Checked) ||
                (x.Season.Contains("Autumn") && Autumn.Checked) 
            ));
            label1.Text = string.Join("\n", newList.OrderBy(x=>x.Season));
        }

        private void Alphabet_Click(object sender, EventArgs e)
        {
            label1.Text = string.Join("\n", months.OrderBy(x => x.Name));
        }

        private void Parametrs_Click(object sender, EventArgs e)
        {
            label1.Text = string.Join("\n", months.Where(x => x.Name.Length > Convert.ToInt32(textBox2.Text) && x.Name.Contains(textBox3.Text)));
        }
    }
}
