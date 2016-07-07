<%@ Page Language="C#" AutoEventWireup="true" CodeFile="huiyiListM.aspx.cs" Inherits="huiyiListM" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>中国石油大学会议室管理系统_会议室申请列表</title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 110px;
        }
        .style3
        {
            width: 137px;
        }
        .style4
        {
            width: 114px;
        }
        .style5
        {
            width: 110px;
            height: 11px;
        }
        .style6
        {
            width: 137px;
            height: 11px;
        }
        .style7
        {
            height: 11px;
        }
        </style>
</head>
<body background="IMAGES/bggg.jpg">
 <p align="center"><img src="IMAGES/logo.jpg" width="440" height="150"></p>
 <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    会议室列表</td>
                    <td><asp:Button ID="Button0" runat="server" Text="查看会议室设备" onclick="Button0_Click" 
                        Width="117px" /><asp:Button ID="Buttoni" runat="server" Text="更新/新增会议室" onclick="Buttoni_Click" 
                        Width="121px" /></td><td>&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">后退</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    查询条件：</td>
                <td class="style2">
                   会议室名：</td>
                <td class="style3">
                    <asp:TextBox ID="TB" runat="server"></asp:TextBox>
                </td>
                <td><asp:Button ID="chaxun" runat="server" Text="查询" onclick="Button3_Click" 
                        Width="92px" />   
                </td>
                </tr>
                <tr><td class="style5">
                </td><td class="style5">
                   预约时间：</td>
                <td class="style6">
                    <asp:TextBox ID="TB2" runat="server"></asp:TextBox>
                </td>
                <td class="style7"><asp:Button ID="yuyue0" runat="server" Text="查询" onclick="Button2_Click" 
                        Width="92px" />   
                </td>
                </tr>
                <tr>
                <td>
                <%-- <asp:LinkButton ID="lbtnupd" class="easyui-linkbutton" plain="true" iconCls="icon-save"
                                        runat="server" OnClick="lbtnupd_Click">修改</asp:LinkButton>--%>
                                        &nbsp; &nbsp;<asp:LinkButton ID="lbtndel" class="easyui-linkbutton" plain="true"
                                        iconCls="icon-remove" runat="server" OnClick="lbtndel_Click" OnClientClick="return confirm('确定删除预约的会议室吗？')">删除</asp:LinkButton>
                                    &nbsp;
                    
                    </td>
                   
                </tr>
                <tr><td> 会议室申请列表</td></tr>
            <tr><td class="style1" colspan="4">
  
                             <asp:GridView ID="gvcourse" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvclass_RowDataBound"
                        Width="934px" OnRowCommand="gvcourse_RowCommand" DataKeyNames="huiyiname">
                    
                        <Columns>
                            <asp:TemplateField HeaderText="选择">
                                <ItemTemplate>
                                    <asp:CheckBox ID="cbsel" runat="server" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="20px" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="huiyiname" HeaderText="会议室名称">
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="huiyiid" HeaderText="会议室代码">
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                       
                            <asp:BoundField DataField="shijian" HeaderText="开会时间" ReadOnly="True">
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                    
                     <%--   <asp:TemplateField HeaderText="是否预约">
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" width="100%" Text='<%#Eval("yuyue").ToString()=="0"?"未预约":"已预约"%>'></asp:Label>
                            
                                </ItemTemplate>
                            </asp:TemplateField>--%>

                                  <asp:TemplateField HeaderText="审核">
                                <ItemTemplate>
                                    <asp:Button ID="Button1" runat="server" CommandArgument='<%#Eval("huiyiname") %>'
                                        Text='<%#Eval("shenhe").ToString()=="0"?"未通过":"已通过"%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                            还没有会议室信息
                        </EmptyDataTemplate>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
