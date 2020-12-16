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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pupil> pupils = new List<Pupil>();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (radioButton1.Checked) {
                Exer1 f = new Exer1(this);
                f.Show();
            }
            if (radioButton2.Checked)
            {
                Exer2 f = new Exer2(this);
                f.Show();
            }
        }
    }
}
