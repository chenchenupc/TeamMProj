using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _DefaultM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Manager obj = new Manager();
        obj.managername = TextBox1.Text;
        obj.managerpwd = TextBox2.Text;
        if (Manager.ifLogin(obj))
        {
            ComTool.Redirect("UsersList.aspx");
        }
        else if (Manager.selectDataTable(obj).Rows.Count == 0)
        {
            ComTool.Alert("用户名未注册，请先注册！");
        }
        else
        {
            ComTool.Alert("密码错误！");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("ManagerM.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.open('infrastructure.html','','')</script>");

    }
}