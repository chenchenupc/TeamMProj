﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManagerM.aspx.cs" Inherits="ManagerM" %>

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
<body   background="IMAGES/bggg.jpg">
<p align="right" style="width:55%" class="style2" >会议室管理</p>
 <form id="form1" runat="server">
    <div>
        <table style="width:200" align="center">
        <tr>
        <td>
        <p align="center" class="style5">管理员注册</p>
        </td>
        </tr>
            <tr>
                <td class="style3" ><div align="center" class="STYLE1"> <font size="2">
                    用 户 名：
                    <asp:TextBox ID="tbxManagerName" runat="server"></asp:TextBox></font></div></td>
            </tr>
            <tr>
                 <td class="style3"><div align="center" class="STYLE1"><font size="4"><font size="3" 
                         style="background-color: #FFFFFF"><font size="2">
                    密&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 码： 
            <asp:TextBox ID="tbxManagerPWD" runat="server"></asp:TextBox></font></font></font></div></td>
            </tr>
            <tr>
                 <td class="style3"><div align="center" class="STYLE1"><font size="4"><font size="3" 
                         style="background-color: #FFFFFF"><font size="2">
                    电&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 话：
            <asp:TextBox ID="tbxManagerTel" runat="server"></asp:TextBox></font></font></font></div></td>
            </tr><%--
            <tr>
            <td><div align="center" class="STYLE1">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal" RepeatLayout="Flow" >
            <asp:ListItem Selected="True">用户</asp:ListItem>    
            <asp:ListItem>管理员</asp:ListItem>
        </asp:RadioButtonList>
        <br />
            </div></td>
            </tr>--%>
            <tr>
                <td><div align="center" class="STYLE1">
                    <font size="2">
                    <asp:Button  ID="Button1" runat="server" 
                        onclick="Button1_Click" Text="确定" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="取消" onclick="Button2_Click" />
                </font></div></td>
            </tr>
        </table>
    
    </div>
</form>
</body>
</html>
