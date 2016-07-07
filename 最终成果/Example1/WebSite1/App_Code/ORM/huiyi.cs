using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

/// <summary>
/// huiyi 的摘要说明
/// </summary>
public class huiyi
{
    public string huiyiid;
    public string huiyiname;
    public string yuyue;
    public string didian;

	public huiyi()
	{ 	//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static DataTable selecthuiyi(huiyi hy)
    {
        string str = "select * from tbhuiyi where 1=1 ";
        if (hy.huiyiname != "" && hy.huiyiname != null)
        str = str + "and huiyiname='" + hy.huiyiname + "'";
          
        DataTable dt = DBOper.execQueryBySQLText(str);
    
        return dt;
    }
    public static DataTable selectyuyue(huiyi hy)
    {
        string str = "select * from tbhuiyi where 1=1 ";
        if (hy.yuyue!= "" && hy.yuyue != null)
            str = str + "and yuyue='" + hy.yuyue + "'";

        DataTable dt = DBOper.execQueryBySQLText(str);

        return dt;
    }
    public static int insertRecord(huiyi obj)
    {
        string strSQL = "insert into tbhuiyi(huiyiname,yuyue,didian) values('" + obj.huiyiname + "','"+obj.yuyue+"','"+obj.didian+"')";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int deleteRecord(huiyi obj)
    {
        string strSQL = "delete from tbhuiyi where huiyiid='" + obj.huiyiid + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int updateRecord(huiyi obj)
    {
        string strSQL = "update tbhuiyi set yuyue='" + obj.yuyue + "' where huiyiname='" + obj.huiyiname + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int quxiaoRecord(huiyi obj)
    {
        string strSQL = "update tbhuiyi set yuyue='" + "0" + "' where huiyiname='" + obj.huiyiname + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
}