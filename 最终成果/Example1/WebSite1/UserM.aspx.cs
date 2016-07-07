using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (tbxUserName.Text.Trim() == "")
        {
            ComTool.Alert("请输入用户名！");
        }
        else if (tbxUserPWD.Text.Trim() == "")
        {
            ComTool.Alert("请输入密码！");
        }
        else
        {
            Users obj = new Users();
            obj.username = tbxUserName.Text;
            obj.userpwd = tbxUserPWD.Text;
            if (Users.selectDataTable(obj).Rows.Count == 0&&Users .insertRecord(obj)==1)
            {
                ComTool.Alert("注册成功！");
                ComTool.Redirect("Default.aspx");
            }
            else
            {
                ComTool.Alert("用户名已存在！");

            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("Default.aspx");
    }
}
