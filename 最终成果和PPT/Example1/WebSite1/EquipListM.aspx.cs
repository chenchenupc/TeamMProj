using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class EquipListM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData(searchCon1());
  
        }
    }
    private Equip searchCon1()
    {
        Equip obj = new Equip();
        obj.equipname = TextBox1.Text.Trim();
        return obj;
    }
    private void BindData(Equip obj)
    {
        DataTable dt = Equip.selectdatatable(obj);
        GridView3.DataSource = dt;
        GridView3.DataBind();
    }
    private Equip searchCon4()
    {
        Equip obj = new Equip();
        obj.equipname = TextBox1.Text.Trim();
        obj.status= TextBox2.Text.Trim();
        obj.location = TextBox3.Text.Trim();
        return obj;
    }
    private void BindData4(Equip obj)
    {
        DataTable dt = Equip.selectcondition(obj);
        GridView3.DataSource = dt;
        GridView3.DataBind();
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        BindData(searchCon1());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        BindData4(searchCon4());
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Buttoni_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("insert.aspx");
    }
}
