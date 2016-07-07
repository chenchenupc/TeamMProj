using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class huiyiListMM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData(searchCon1());
  
        }
    }
    private huiyi searchCon1()
    {
        huiyi obj = new huiyi();
        obj.huiyiname =TB.Text.Trim();
        return obj;
    }
    private huiyi searchCon2()
    {
        huiyi obj = new huiyi();
        obj.yuyue = TB2.Text.Trim();
        return obj;
    }
    private void BindData(huiyi obj)
    {
        DataTable dt = huiyi.selecthuiyi(obj);
        GridView2.DataSource = dt;
        GridView2.DataBind();
    }
    private void BindData2(huiyi obj)
    {
        DataTable dt = huiyi.selectyuyue(obj);
        GridView2.DataSource = dt;
        GridView2.DataBind();
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        BindData(searchCon1());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        BindData2(searchCon2());
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        BindData(searchCon1());
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button0_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("EquipListM.aspx");
    }
    protected void Buttoni_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("insert1.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("huiyiListM.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("UsersList.aspx");
    }
}
