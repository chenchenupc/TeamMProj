using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ManagerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData(searchCon());
        }
    }
    private Manager searchCon()
    {
        Manager obj = new Manager();
        obj.managername = TextBox1.Text.Trim();
        return obj;
    }
    private void BindData(Manager obj)
    {
        DataTable dt = Manager.selectDataTable(obj);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindData(searchCon());
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        BindData(searchCon());
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("huiyiList.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("Default.aspx");
    }
}
