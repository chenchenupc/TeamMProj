using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() == "")
        {
            ComTool.Alert("请输入设备编号！");
        }
        else if (tbxUserName.Text.Trim() == "")
        {
            ComTool.Alert("请输入设备名称！");
        }
        else if (tbxUserPWD.Text.Trim() == "")
        {
            ComTool.Alert("请输入设备所在位置！");
        }
        else if (TextBox2.Text.Trim() == "")
        {
            ComTool.Alert("请输入设备状态！");
        }
        else
        {
            Equip obj = new Equip();
            obj.equipcode = TextBox1.Text;
            obj.equipname = tbxUserName.Text;
            obj.location = tbxUserPWD.Text;
            obj.status = TextBox2.Text;
            if (Equip.selectcon(obj).Rows.Count==0&&Equip.insertRecord(obj) == 1)   
            {
                ComTool.Alert("新增成功！");
                ComTool.Redirect("EquipListM.aspx");
            }
            else
            {
                ComTool.Alert("编号重复！");

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
            Equip obj = new Equip();
            obj.equipcode = TextBox1.Text;
            obj.status = TextBox2.Text;
            if (Equip.updateRecord(obj) == 1)
            {
                ComTool.Alert("更新成功！");
                ComTool.Redirect("EquipListM.aspx");
            }
            else
            {
                ComTool.Alert("更新失败！");

            }
        }
    }
}
