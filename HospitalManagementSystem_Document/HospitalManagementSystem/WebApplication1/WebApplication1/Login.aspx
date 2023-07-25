<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="navbar.css" rel="stylesheet" type="text/css" />

    <style type="text/css">

        .style10
        {
            color: #006699;
            font-family: "Comic Sans MS";
        }
        .style11
        {
            width: 100%;
            height: 66px;
        }
        .style1
        {
            width: 78%;
            height: 92px;
        }
        .style4
        {
            width: 582px;
            height: 30px;
            text-align: right;
        }
        .style7
        {
            width: 22px;
            height: 30px;
            text-align: right;
        }
        .style5
        {
            text-align: left;
            height: 30px;
        }
        .style12
        {
            width: 582px;
            height: 32px;
            text-align: right;
        }
        .style13
        {
            width: 22px;
            height: 32px;
            text-align: right;
        }
        .style14
        {
            text-align: left;
            height: 32px;
        }
        .style2
        {
            width: 582px;
        }
        .style9
        {
            width: 22px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
    </div>
    <div style="text-align: center">
        <img src="Images/Dubai-Hospital.jpg" alt="img1"
            style="width: 1348px; height: 286px; margin-top: 0px; margin-left: 0px;" />
        <%--<br />
        <br />
        <br />
        <br />
        <br />--%>
        <asp:Panel ID="Panel1" runat="server" Height="79px">
            <h1>
                <span class="style10"><strong>Aikya Hospitals</strong></span></h1>
        </asp:Panel>
        <br />
        <table align="left" bgcolor="#006699" class="style11">
            <tr>
                <td>
                    <table align="center" class="style1">
                        <tr>
                            <td class="style4">
                                <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                            </td>
                            <td class="style7">
                                &nbsp;</td>
                            <td class="style5">
        <asp:TextBox ID="Txt_Userid" runat="server"></asp:TextBox>
                            </td>
                            <td class="style5">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td class="style13">
                            </td>
                            <td class="style14">
        <asp:TextBox ID="Txt_Password" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                            <td class="style14">
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td class="style9">
                                &nbsp;</td>
                            <td style="text-align: left">
        <asp:Button ID="btn_UserLogIn" runat="server" onclick="btn_UserLogIn_Click" 
            Text="Login" CssClass="Buttonclass" />
    
                                &nbsp;
    
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    <div style="z-index: 1; left: 15px; top: 567px; position: absolute; height: 95px; width: 1113px">
    <p style="z-index: 1; left: 328px; top: 52px; position: absolute; height: 32px; width: 748px">© 2015 - 2020 by 
        Aikya Hospitals™ . All Rights Reserved | Copyright | Terms of Use & Privacy Policy </p></div>
    </form>
</body>
</html>
