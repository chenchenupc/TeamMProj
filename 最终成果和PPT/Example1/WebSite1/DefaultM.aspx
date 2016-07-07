<%@ Page Language="C#" AutoEventWireup="false" CodeFile="DefaultM.aspx.cs" Inherits="_DefaultM" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>中国石油大学会议室管理系统</title>
	<%--<META content="text/html; charset=gb2312" http-equiv=Content-Type>
<META content="Microsoft FrontPage 4.0" name=GENERATOR>
<META content=FrontPage.Editor.Document name=ProgId>
<meta http-equiv="content-type" content="text/html; charset=gb2312">--%>
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
            width: 381px;
        }
        #form1 #f2 {
	position: absolute;
	left: 410px;
	top: 150px;
	height: 242px;
}
    body,td,th {
	color: #FFFFFF;
}
.STYLE3 {font-size: xx-large; font-weight: bold; }
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" /></head>
<body background="IMAGES/midd_bg.jpg">
 <p align="center" class="STYLE3">欢迎登陆会议室管理系统</p>
              <div align="center">                                  
    <form id="form1" runat="server">
    <div>
    
        <table id="f2" style="width: 446px; margin-top: 15px;">
        <tr><td><p align="center" class="style5">管理员登录</p></td>
        </tr>
            <tr>
                 <td width="28%"><div align="center" class="STYLE1"><font size="4"><font size="3">
                    <font size="2" style="font-size: large">
                    用户名：</font><asp:TextBox ID="TextBox1" runat="server" 
                        Height="19px"></asp:TextBox>
                    </font></font></div></td>            
            </tr>
            <tr>
                <td width="28%"><div align="center" class="STYLE1">密<font size="3"><font size="2" style="font-size: large">&nbsp; 码：</font></a><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </font></div></td>
            </tr>
            <%--<tr>
                <td width="28%"><div align="center" class="STYLE1"><font size="3">
                    <font size="2" style="font-size: large">
                    电&nbsp;&nbsp; 话：</font></a><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </font></div></td>
            </tr>--%>
            <%--<tr>
                 <td width="28%">
                         <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal" RepeatLayout="Flow" 
                             onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Selected="True">用户</asp:ListItem>    
            <asp:ListItem>管理员</asp:ListItem>
        </asp:RadioButtonList>
        <br />
                         </td>            
            </tr>--%>
            <tr>
                <td height="47" class="style1"> <div align="center" class="STYLE1"><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click" /> 
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="注册" onclick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返回" />
                </font></div></td>
          </tr>                
      </table>
    
    </div>
    </form>
</body>
</html>
