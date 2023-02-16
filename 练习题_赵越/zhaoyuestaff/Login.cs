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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = @"server=.;uid=sa;pwd=zy123456;database=zycsharp";
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection(connstr);
                sqlconn.Open();

                string log = Loginname.Text;
                string pwd = Password.Text;
                // MessageBox.Show("数据库连接成功");
                string sqllogin = @"use zycsharp;select count(*) from t_staff_zhaoy  
                                    where Loginname='{log}'and Password='{pwd}'";
               // sqllogin = string.Format(sqllogin, Loginname.Text);
                SqlCommand sqlcomm = new SqlCommand(sqllogin, sqlconn);
                //错误代码
                //string password = Convert.ToString(sqlcomm.ExecuteReader());
               // SqlDataReader dr = sqlcomm.ExecuteReader();
                //string password = null;
                int returnvalue = (int)sqlcomm.ExecuteScalar();
                if(returnvalue!=-1)
                {
                    MessageBox.Show("登陆成功" + Loginname.Text);
                    Firstpage firstpage = new Firstpage();
                   
                    firstpage.Show();

                    this.Hide();
                }
                else { MessageBox.Show("登录失败，请重新尝试登录"); }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据库连接失败");
            }
            finally
            {
                sqlconn.Close();  //关闭数据库连接
                
            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Loginname_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
