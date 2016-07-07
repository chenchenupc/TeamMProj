<%@ Page Language="C#" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>中国石油大学会议室管理系统</title>
    <style type="text/css">
        .style1
        {
            width: 106px;
        }
        .style2
        {
            font-size: xx-large;
        }
        .STYLE1
        {
            width: 386px;
        }
        #form1 #f1 {
	position: absolute;
	left: 399px;
	top: 152px;
	height: 260px;
}
    body,td,th {
	color: #FFFFFF;
	font-size: x-large;
}
.STYLE3 {font-size: xx-large; font-weight: bold; }
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" /></head>
<body background="IMAGES/midd_bg.jpg">
 <p align="center" class="STYLE3">欢迎登陆会议室管理系统</p>
              <div align="center">                                  
    <form id="form1" runat="server">
    <div>
    
        <table id="f1" style="width: 658px; margin-top: 15px;">
        <tr><td><p align="center" class="style5">&nbsp;</p></td>
        </tr>
            <tr>
                 <td width="28%"><div align="center" class="STYLE1"><font size="4"><font size="3">
                    <font size="2" style="font-size: large">
                    用户名：</font>
                    <asp:TextBox ID="TextBox1" runat="server" 
                        Height="19px"></asp:TextBox>
                    </font></font></div></td>            
            </tr>
            <tr>
                <td width="28%"><div align="center" class="STYLE1"><font size="3">
                    <font size="2" style="font-size: large">
                    密&nbsp; 码：</font></a><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </font></div></td>
            </tr>
            <tr>
                <td height="47" class="style1"> <div align="center" class="STYLE1"><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click" /> 
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="注册" onclick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返回" />
                </font></div></td>
          </tr>                
      </table>
    
    </div>
    </form>
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
