using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class huiyiListM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData3();
            //BindData()
  
        }
    }
    protected void gvclass_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    Label lb = (Label)e.Row.FindControl("Label1");
        //    Button bt = (Button)e.Row.FindControl("Button1");
        //    if (lb.Text == "未预约")
        //        bt.Visible = false;
        //    else
        //        bt.Visible = true;
        //}

    }
    private yuyuehuiyi searchCon1()
    {
        yuyuehuiyi obj = new yuyuehuiyi();
        obj.huiyiname = TB.Text.Trim();
        return obj;
    }
    private yuyuehuiyi searchCon2()
    {
        yuyuehuiyi obj = new yuyuehuiyi();
        obj.shijian = TB2.Text.Trim();
        return obj;
    }
    private void BindData(yuyuehuiyi obj)
    {
        DataTable dt = yuyuehuiyi.selecthuiyishenqing(obj);
        gvcourse.DataSource = dt;
        gvcourse.DataBind();
    }
 
    private void BindData2(yuyuehuiyi obj)
    {
        DataTable dt = yuyuehuiyi.selectyuyueshijian(obj);
        gvcourse.DataSource = dt;
        gvcourse.DataBind();
    }
    private void BindData3()
    {
        yuyuehuiyi obj = new yuyuehuiyi();
        DataTable dt = yuyuehuiyi.huiyishenqingqb(obj);
        gvcourse.DataSource = dt;
        gvcourse.DataBind();
    } //申请表全部
    //private void BindData4(yuyuehuiyi obj)
    //{
        
    //    DataTable dt = yuyuehuiyi.selectshenhe(obj);
    //    gvcourse.DataSource = dt;
    //    gvcourse.DataBind();
    //}
    private void BindData5(huiyi obj)
    {

        DataTable dt = huiyi.selecthuiyi(obj);
        gvcourse.DataSource = dt;
        gvcourse.DataBind();
    }

    //private void BindData4(yuyuehuiyi obj)
    //{

    //    DataTable dt = yuyuehuiyi.update(obj);
    //    gvcourse.DataSource = dt;
    //    gvcourse.DataBind();
    //}

    protected void gvcourse_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        huiyi hy=new huiyi();
        hy.huiyiname = e.CommandArgument.ToString(); 
        huiyi.updateRecord(hy);//yuyue=1
        BindData5(hy);  
        yuyuehuiyi obj=new yuyuehuiyi();
        obj.huiyiname = e.CommandArgument.ToString(); 
        yuyuehuiyi.updateshenheRecord(obj);
        BindData(obj);
       
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

 

    protected void lbtndel_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < gvcourse.Rows.Count; i++)
        {
            CheckBox cb = (CheckBox)gvcourse.Rows[i].FindControl("cbsel");
            if (cb.Checked)
            {
                string name = gvcourse.DataKeys[i].Value.ToString();
                yuyuehuiyi myhuiyi = new yuyuehuiyi();
                myhuiyi.huiyiname = name;
                yuyuehuiyi.deleteshenqingRecord(myhuiyi);
                BindData(myhuiyi);

                huiyi huiy = new huiyi();
                huiy.huiyiname = name;
                huiyi.quxiaoRecord(huiy);
                BindData5(huiy);
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("huiyiListMM.aspx");
    }
}

