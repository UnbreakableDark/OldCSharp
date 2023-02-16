using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace zhaoyuestaff
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;uid=sa;pwd=zy123456;database=zycsharp";
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection(connstr);
                sqlconn.Open();

                int aid = Convert.ToInt32(textBox1.Text);
                string aloginname = textBox2.Text;
                string apassword = textBox3.Text;
                int asex= Convert.ToInt32(textBox4.Text);
                string aaddress= textBox5.Text;
                string avalues = $"{aid},'{aloginname}','{apassword}',{asex},'{aaddress}'";
                string sqlre = $"insert into t_staff_zhaoy values({avalues})";

                SqlCommand sqlcomm = new SqlCommand(sqlre, sqlconn);
                int aa =sqlcomm.ExecuteNonQuery();

                if(aa!=-1)
                {
                    MessageBox.Show("注册成功");
                }
                


                /*
                int returnvalue = sqlcomm.ExecuteNonQuery();
                //判断SQL语句是否执行成功
                if (returnvalue != -1)
                {
                    MessageBox.Show("注册成功！");
                }
                */
                //MessageBox.Show($"{avalues}");
                //MessageBox.Show($"{sqlre}");
                //MessageBox.Show($"aid:{aid},aloginname:{aloginname},apassword:{apassword},asex:{asex},aaddress:{aaddress}");
                // MessageBox.Show("新用户创建成功");

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败");
            }
            finally
            {
                sqlconn.Close();  //关闭数据库连接
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            this.Hide();
        }
    }
}
