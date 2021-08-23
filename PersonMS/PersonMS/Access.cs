using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

class Access
{
    OleDbConnection oleDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CodeRuan\Desktop\PersonMS\Person.accdb");//此处改为自己数据源位置

    public Access() //构造函数
    {
        oleDb.Open();
    }

    //查询全部
    public DataTable Get()
    {
        string sql = "select * from person";
        //获取表1的内容
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
        DataTable dt = new DataTable(); //新建表对象
        dbDataAdapter.Fill(dt); //用适配对象填充表对象
        //foreach (DataRow item in dt.Rows)
        //{
        //    Console.WriteLine(item[0] + " | " + item[1]);
        //}
        return dt;
    }

    //查询

    public DataTable FindById( String value)
    {
        string sql = "select * from person WHERE pid='" + value + "'";
        Console.WriteLine(sql);
        //获取表1中昵称为LanQ的内容
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
        DataTable dt = new DataTable(); //新建表对象
        dbDataAdapter.Fill(dt); //用适配对象填充表对象
        foreach (DataRow item in dt.Rows)
        {
            Console.WriteLine(item[0] + " | " + item[1]);
        }
        return dt;
 
    }

    public DataTable FindByName(String value)
    {
        string sql = "select * from person WHERE username='" + value + "'";
        Console.WriteLine(sql);
        //获取表1中昵称为LanQ的内容
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
        DataTable dt = new DataTable(); //新建表对象
        dbDataAdapter.Fill(dt); //用适配对象填充表对象
        foreach (DataRow item in dt.Rows)
        {
            Console.WriteLine(item[0] + " | " + item[1]);
        }
        return dt;

    }

    public DataTable FindByPhone(String value)
    {
        string sql = "select * from person WHERE phone='" + value + "'";
        Console.WriteLine(sql);
        //获取表1中昵称为LanQ的内容
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
        DataTable dt = new DataTable(); //新建表对象
        dbDataAdapter.Fill(dt); //用适配对象填充表对象
        foreach (DataRow item in dt.Rows)
        {
            Console.WriteLine(item[0] + " | " + item[1]);
        }
        return dt;

    }
    
    //添加
    public bool Add(String pid,String username,String phone,String sex,String in_time,String temperature)
    {
        string sql = "insert into person (pid,username,phone,sex,enter_time,temperature) values ('" + pid + "','" + username + "','" + phone + "','" + sex + "','" + in_time + "','" + temperature + "')";
        Console.Write(sql);
        //往表1添加一条记录，
        OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
        int i = oleDbCommand.ExecuteNonQuery(); //返回被修改的数目
        return i > 0;
    }

    //删除
    public bool Del()
    {
        string sql = "delete from person where 昵称='LANQ'";
        //删除昵称为LanQ的记录
        OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
        int i = oleDbCommand.ExecuteNonQuery();
        return i > 0;
    }

    //修改
    public bool Change()
    {
        string sql = "update person set 账号='233333' where 昵称='东熊'";
        //将表1中昵称为东熊的账号修改成233333
        OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
        int i = oleDbCommand.ExecuteNonQuery();
        return i > 0;
    }

}
