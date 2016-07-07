using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Users obj = new Users();
        obj.username = TextBox1.Text;
        obj.userpwd = TextBox2.Text;
        if (Users.ifLogin(obj))
        {
            ComTool.Redirect("ManagerList.aspx");
        }
        else if (Users.selectDataTable(obj).Rows.Count == 0)
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
        ComTool.Redirect("UserM.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
   
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.open('infrastructure.html','','')</script>");
    }
}