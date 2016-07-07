using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class Manager
{
	public Manager()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public string managerid;
    public string managername;
    public string managerpwd;
	public string telephone;
    public static bool ifLogin(Manager obj)
    {
        bool blRet = true;

        string strSQL = "select * from tbmanager where managername='" + obj.managername + "' "
            + " and managerpwd='" + obj.managerpwd + "'";
        DataTable dt = DBOper.execQueryBySQLText(strSQL);
        try
        {
            if (dt.Rows.Count > 0)
            {
                blRet = true;
            }
            else
            {
                blRet = false;
            }
        }
        catch
        {
            blRet = false;
        }
        return blRet;
    }

    public static DataTable selectDataTable(Manager obj)
    {
        string strSQL = "select * from tbmanager where 1=1 ";
        if (obj.managername != "" && obj.managername != null)
            strSQL = strSQL + "and managername='" + obj.managername + "'";

        DataTable dt = DBOper.execQueryBySQLText(strSQL);

        return dt;
    }
 

    public static int insertRecord(Manager obj)
    {
        string strSQL = "insert into tbmanager(managername,managerpwd,telephone) values('"+obj.managername+"','"+obj.managerpwd +"','"+obj.telephone+"')";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int deleteRecord(Manager obj)
    {
        string strSQL = "delete from tbmanager where managerid='"+ obj.managerid + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int updateRecord(Manager obj)
    {
        string strSQL = "update tbmanager set managername='" + obj.managername + "' where managerid='" + obj.managerid + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
}