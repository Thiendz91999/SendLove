using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SendLove
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;Database=sendlove;Uid=root;Pwd=12345");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPassWord.Text == "")
            {
                MessageBox.Show("Hãy nhập ngày sinh nhật của bạn!!!", "Gửi đến bạn", MessageBoxButtons.OK, //MessageBoxIcon.Warning // for Warning  
                            //MessageBoxIcon.Error // for Error 
                            MessageBoxIcon.Information  // for Information
                            //MessageBoxIcon.Question // for Question
                );
            }
            else
            {
                try
                {
                    MySqlDataAdapter mda = new MySqlDataAdapter("select count(*) from tbllove where password = '" + txtPassWord.Text + "' ", conn);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Form3 main = new Form3();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Xin lỗi, bạn không phải cô ấy!!!", "Gửi đến bạn", MessageBoxButtons.OK, //MessageBoxIcon.Warning // for Warning  
                                                                                                                   //MessageBoxIcon.Error // for Error 
                            MessageBoxIcon.Information  // for Information
                                                        //MessageBoxIcon.Question // for Question
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xin lỗi, bạn không phải cô ấy!!!", "Gửi đến bạn", MessageBoxButtons.OK, //MessageBoxIcon.Warning // for Warning  
                                                                                                             MessageBoxIcon.Error // for Error 
                            //MessageBoxIcon.Information  // for Information
                                                        //MessageBoxIcon.Question // for Question
                        );
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
