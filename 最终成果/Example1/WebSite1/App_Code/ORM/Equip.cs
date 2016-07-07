using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

/// <summary>
///Equip 的摘要说明
/// </summary>
public class Equip
{
    public string equipid;
    public string equipname;
    public string location;
    public string status;
    public string equipcode;
    public Equip()
    { 	//
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static DataTable selectdatatable(Equip e)
    {
        string str = "select * from equipment where 1=1 ";
        if (e.equipname != "" && e.equipname != null)
            str = str + "and equipname='" + e.equipname + "'";
        DataTable dt = DBOper.execQueryBySQLText(str);
        return dt;
    }
    public static DataTable selectcon(Equip e)
    {
        string str = "select * from equipment where 1=1 ";
        if (e.equipcode != "" && e.equipcode != null)
            str = str + "and equipcode='" + e.equipcode + "'";

        DataTable dt = DBOper.execQueryBySQLText(str);
        return dt;
    }

    public static DataTable selectcondition(Equip e)
    {
        string str = "select * from equipment where 1=1 ";
        if (e.equipname != "" && e.equipname != null)
            str = str + "and equipname='" + e.equipname + "'";
        if (e.status != "" && e.status != null)
            str = str + "and status='" + e.status + "'";
        if(e.location != "" && e.location != null)
            str = str + "and location='" + e.location + "'";
        DataTable dt = DBOper.execQueryBySQLText(str);
        return dt;
    }
    public static int insertRecord(Equip obj)
    {
        string strSQL = "insert into equipment(equipname,location,status,equipcode) values('" + obj.equipname + "','" + obj.location + "','" + obj.status + "','" + obj.equipcode + "')";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int deleteRecord(Equip obj)
    {
        string strSQL = "delete from equipment where equipid='" + obj.equipid + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int updateRecord(Equip obj)
    {
        string strSQL = "update equipment set status='" + obj.status + "' where equipcode='" + obj.equipcode + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }

}