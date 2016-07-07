using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

/// <summary>
/// huiyi 的摘要说明
/// </summary>
public class yuyuehuiyi
{
    public string huiyiid;
    public string huiyiname;
    public string yuyue;
    public string shenhe;
    public string shijian;
	public yuyuehuiyi()
	{ 	//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static DataTable huiyishenqingqb(yuyuehuiyi hy){
    
        string str = "select * from shenqinghuiyi where 1=1 ";  
       DataTable dt = DBOper.execQueryBySQLText(str);

        return dt;
    }
    public static DataTable selecthuiyishenqing(yuyuehuiyi hy)
    {
        string str = "select * from shenqinghuiyi where 1=1 ";
        if (hy.huiyiname != "" && hy.huiyiname != null)
        str = str + "and huiyiname='" + hy.huiyiname + "'";
          
        DataTable dt = DBOper.execQueryBySQLText(str);
    
        return dt;
    }
    public static DataTable selectshenhe(yuyuehuiyi hy)
    {
        string str = "select * from shenqinghuiyi where 1=1 ";
        if (hy.shenhe != "" && hy.shenhe != null)
            str = str + "and shenhe='" + hy.shenhe + "'";

        DataTable dt = DBOper.execQueryBySQLText(str);

        return dt;
    }
    public static DataTable selectyuyueshijian(yuyuehuiyi hy)
    {
        string str = "select * from tbhuiyi where 1=1 ";
        if (hy.shijian!= "" && hy.shijian != null)
            str = str + "and shijian='" + hy.shijian + "'";

        DataTable dt = DBOper.execQueryBySQLText(str);

        return dt;
    }
    public static int insertshenqingRecord(yuyuehuiyi obj)
    {
        string strSQL = "insert into shenqinghuiyi(huiyiname,shijian,shenhe) values('" + obj.huiyiname + "','"+obj.shijian+"','"+"0"+"')";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int deleteshenqingRecord(yuyuehuiyi obj)
    {
        string strSQL = "delete from shenqinghuiyi where huiyiname='" + obj.huiyiname + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    //public static int delRecord(yuyuehuiyi obj)
    //{
    //    string strSQL = "delete from shenqinghuiyi where huiyiid='" + obj.huiyiid + "'";
    //    int iRet = DBOper.execNonQueryBySQLText(strSQL);
    //    return iRet;
    //}
    public static int updateshenheRecord(yuyuehuiyi obj)
    {
        string strSQL = "update shenqinghuiyi set shenhe='"+"1" +"' where huiyiname='" + obj.huiyiname + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    //public static DataTable update(yuyuehuiyi obj)
    //{
    //    string strSQL = "update shenqinghuiyi set yuyue='" + obj.yuyue + "' where huiyiname='" + obj.huiyiname + "'";
    //    DBOper.execNonQueryBySQLText(strSQL);
    //    DataTable dt = DBOper.execQueryBySQLText(strSQL);
    //    return dt;

    //}

}