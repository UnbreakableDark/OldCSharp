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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;uid=sa;pwd=zy123456;database=zycsharp";
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection(connstr);
                sqlconn.Open();

                int cid = Convert.ToInt32(textBox1.Text);
                string cloginname = textBox2.Text;
                string cpassword = textBox3.Text;
                int csex = Convert.ToInt32(textBox4.Text);
                string caddress = textBox5.Text;
                // string avalues = $"{cid},'{cloginname}','{cpassword}',{csex},'{caddress}'";
                 string sqlchange = $"update t_staff_zhaoy set Password='{cpassword}',Sex={csex},address='{caddress}' where ID={cid} and Loginname='{cloginname}'";
               
                SqlCommand sqlcomm = new SqlCommand(sqlchange, sqlconn);
                
                
                int cc = sqlcomm.ExecuteNonQuery();

                if (cc != -1)
                {
                    MessageBox.Show("用户信息更改成功");
                }

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

        private void Change_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
