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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đừng thoát! Hãy trả lời câu hỏi này nhé!", "Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            int x = this.ClientSize.Width - btnCancel.Width;
            int y = this.ClientSize.Height - btnCancel.Height;
            Random r = new Random();
            btnCancel.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }

        private void btnAccept_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAccept, "Đồng ý");
        }
    }
}
