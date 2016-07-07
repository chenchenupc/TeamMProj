using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class yuyue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private yuyuehuiyi searchCon()
    {  huiyi  h=new huiyi ();
        h.huiyiname=hyname.Text.Trim();
        DataTable da = huiyi.selecthuiyi(h); 
        
        yuyuehuiyi obj = new yuyuehuiyi();
        obj.huiyiname = hyname.Text.Trim();
        obj.shijian = shijian.Text.Trim();
        obj.yuyue = (string )da.Rows[0][2];
        return obj;
    }



    protected void B1Click(object sender, EventArgs e)
    {
        if (hyname.Text.Trim() == "")
        {
            ComTool.Alert("请输入会议室名！");
        }
        else if (shijian.Text.Trim() == "")
        {
            ComTool.Alert("请输入预约时间 ！");
        }
        else
        {
            yuyuehuiyi obj = searchCon();
           
            if (obj.yuyue == "0" )
            {
                int i=yuyuehuiyi.insertshenqingRecord(obj);
                if (i != 0)
                {
                    ComTool.Alert("预约单提交成功！等待管理员审核！");

                    ComTool.Redirect("huiyiList.aspx");
                }
                else 
                {
                    ComTool.Alert("预约单提交失败！请再次提交！");
                }

            }
         
            else
            {
                ComTool.Alert("会议室已被他人预约！");

            }
        }
    }

    protected void B2Click(object sender, EventArgs e)
    {
        ComTool.Redirect("huiyiList.aspx");
    }
}
