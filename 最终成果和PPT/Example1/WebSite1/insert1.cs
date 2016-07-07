using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insert1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (tbxUserName.Text.Trim() == "")
        {
            ComTool.Alert("请输入会议室名称！");
        }
        else if (tbxUserPWD.Text.Trim() == "")
        {
            ComTool.Alert("请输入会议室位置！");
        }
        else if (TextBox2.Text.Trim() == "")
        {
            ComTool.Alert("请输入会议室状态！");
        }
        else
        {
            huiyi obj = new huiyi();
            obj.huiyiname = tbxUserName.Text;
            obj.didian = tbxUserPWD.Text;
            obj.yuyue = TextBox2.Text;
            if (huiyi.insertRecord(obj)==1)
            {
                ComTool.Alert("新增成功！");
                ComTool.Redirect("huiyiListM.aspx");
            }
            else
            {
                ComTool.Alert("新增失败！");

            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() == "")
        {
            ComTool.Alert("请输入设备编号！");
        }
        else if (TextBox2.Text.Trim() == "")
        {
            ComTool.Alert("请输入设备状态！");
        }
        else
        {
            huiyi obj = new huiyi();
            obj.huiyiname = TextBox1.Text;
            obj.yuyue = TextBox2.Text;
            if (huiyi.updateRecord(obj) == 1)
            {
                ComTool.Alert("更新成功！");
                ComTool.Redirect("huiyiListListM.aspx");
            }
            else
            {
                ComTool.Alert("更新失败！");
            }
        }
    }
}
