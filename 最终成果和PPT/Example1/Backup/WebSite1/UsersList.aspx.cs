using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class UsersList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData(searchCon());
        }
    }
    private Users searchCon()
    {
        Users obj = new Users();
        obj.username = TextBox1.Text.Trim();
        return obj;
    }
    private void BindData(Users obj)
    {
        DataTable dt = Users.selectDataTable(obj);
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
    protected void btnNew_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("UserM.aspx");
    }
}
