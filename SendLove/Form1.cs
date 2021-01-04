using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendLove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            Progress.Value = start;
            if(Progress.Value == 100)
            {
                Progress.Value = 0;
                timer1.Stop();
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
