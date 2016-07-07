<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert1.cs" Inherits="insert1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>中国石油大学会议室管理系统</title>
    <style type="text/css">
        .style2
        {
            font-size: x-large;
            color: #000000;
            background-color: #FFFFFF;
        }
        .style3
        {
            height: 25px;
        }
        .style5
        {
            font-size: x-large;
        }
    </style>
</head>
<body   background="IMAGES/bg.jpg">
 <form id="form1" runat="server">
    <div>
        <table style="width:200" align="center">
        <tr>
        <td>
        <p align="center" class="style5">会议室管理</p>
        </td>
        </tr><tr>
                <td class="style3" ><div align="center" class="STYLE1"><font size="4"><font size="3"> <font size="2">
                    会议室编号：
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></font></font></font></div></td>
            </tr>
            <tr>
                <td class="style3" ><div align="center" class="STYLE1"><font size="4"><font size="3"> <font size="2">
                    会议室名称：
                    <asp:TextBox ID="tbxUserName" runat="server"></asp:TextBox></font></font></font></div></td>
            </tr>
            <tr>
                 <td class="style3"><div align="center" class="STYLE1"><font size="4"><font size="3" 
                         style="background-color: #FFFFFF"><font size="2">
                    会议室位置：
            <asp:TextBox ID="tbxUserPWD" runat="server"></asp:TextBox></font></font></font></div></td>
            </tr>
            <tr>
                <td class="style3" ><div align="center" class="STYLE1"><font size="4"><font size="3"> <font size="2">
                    会议室状态：
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></font></font></font></div></td>
            </tr>
            <tr>
                <td><div align="center" class="STYLE1">
                    <font size="2">
                    <asp:Button  ID="Button1" runat="server" 
                        onclick="Button1_Click" Text="新增" />&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="更新" onclick="Button2_Click" />
                </font></div></td>
            </tr>
        </table>
    
    </div>
</form>
</body>
</html>
