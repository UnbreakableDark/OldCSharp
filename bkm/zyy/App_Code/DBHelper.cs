using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
///DBHelper 的摘要说明
/// </summary>
public class DBHelper
{
	public DBHelper()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    private static String connStr = "server=(local);database=pkm;uid=sa;pwd =123456"; //连接通道字符串（服务器名称、数据库名字、用户名、用户密码）
    public static SqlConnection GetConn()
    {
        return new SqlConnection(connStr);   //建立连接通道
    }

    public static int ExecuteNonQuery(CommandType ct, String sqlStr, params SqlParameter[] paras)
    {
        int res = -1;  // 返回受影响行数
        using (var conn = GetConn())  //建立连接，使用using可保证大括号结束时及时释放资源
        {
            var cmd = new SqlCommand(sqlStr, conn);  //新建命令对象
            cmd.CommandType = ct;	//告诉cmd，执行的语句类型
            cmd.Parameters.AddRange(paras);  //传递参数
            conn.Open();   //打开连接通道
            res = cmd.ExecuteNonQuery();//执行语句，返回受影响行数
            conn.Close();  //关闭连接通道
            cmd.Dispose();  //释放资源
        }
        return res;
    }

    public static T ExecuteScalar<T>(CommandType ct, String sqlStr, params SqlParameter[] paras)
    {
        using (var conn = GetConn())
        {
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(paras);
            conn.Open();
            T result = default(T);
            result = (T)cmd.ExecuteScalar();
            return result;
        }
    }

    public static DataTable ExecuteDataTable(CommandType ct, String sqlStr, params SqlParameter[] paras)
    {
        using (var conn = GetConn())
        {
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(paras);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }

    public static DataSet ExecuteDataSet(CommandType ct, String sqlStr, params SqlParameter[] paras)
    {
        DataSet ds = null;
        using (var conn = GetConn())
        {
            var cmd = new SqlCommand(sqlStr, conn);
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(paras);
            var da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cmd.Dispose();
            da.Dispose();
        }
        return ds;
    }



}