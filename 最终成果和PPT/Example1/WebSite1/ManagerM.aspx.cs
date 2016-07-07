using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManagerM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (tbxManagerName.Text.Trim() == "")
        {
            ComTool.Alert("请输入用户名！");
        }
        else if (tbxManagerPWD.Text.Trim() == "")
        {
            ComTool.Alert("请输入密码！");
        }
        else if (tbxManagerTel.Text.Trim() == "")
        {
            ComTool.Alert("请输入联系方式！");
        }
        else
        {
            Manager obj = new Manager();
            obj.managername = tbxManagerName.Text;
            obj.managerpwd = tbxManagerPWD.Text;
            obj.telephone = tbxManagerTel.Text;
            if (Manager.selectDataTable(obj).Rows.Count == 0 && Manager.insertRecord(obj) == 1)
            {
                ComTool.Alert("注册成功！");
                ComTool.Redirect("DefaultM.aspx");
            }
            else
            {
                ComTool.Alert("用户名已存在！");

            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("DefaultM.aspx");
    }
}
