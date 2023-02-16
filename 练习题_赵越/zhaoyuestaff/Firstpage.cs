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
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            InitializeComponent();
        }

       
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = @"server=.;uid=sa;pwd=zy123456;database=zycsharp";
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection(connstr);
                sqlconn.Open();


                string sqlselect = $"use zycsharp; select * from t_staff_zhaoy";
                SqlDataAdapter sda = new SqlDataAdapter(sqlselect, sqlconn);

                DataSet ds = new DataSet();
                sda.Fill(ds);

                DataTable dt = new DataTable();

                dataGridView1.DataSource = ds.Tables[0];
                


              /*
                string sqllogin = @"use zycsharp;select count(*) from t_staff_zhaoy  
                                    where Loginname='{log}'and Password='{pwd}'";
               
                SqlCommand sqlcomm = new SqlCommand(sqllogin, sqlconn);
                
                int returnvalue = (int)sqlcomm.ExecuteScalar();
                if (returnvalue != -1)
                {
                    MessageBox.Show("登陆成功" );
                   
                }
                else { MessageBox.Show("登录失败，请重新尝试登录"); }
                */

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            //this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change ch = new Change();
            ch.Show();
        }

        private void Firstpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
