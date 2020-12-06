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
    }
}
