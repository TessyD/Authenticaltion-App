﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="SocialMediaApplication.Landing_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  
        <title></title>  
    </head>  
  
    <body>  
        <form id="form1" runat="server">  
            <div>  
                <table>  
                    <tr>  
                        <td>  
                            <asp:Image ID="imgprofile" runat="server" Height="225px" Width="231px" /> </td>  
                    </tr>  
                    <tr>  
                        <td> Id </td>  
                        <td>  
                            <asp:Label ID="lblid" runat="server" Text=""></asp:Label>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td> Name </td>  
                        <td>  
                            <asp:Label ID="lblname" runat="server" Text=""></asp:Label>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td> Gender </td>  
                        <td>  
                            <asp:Label ID="lblgender" runat="server" Text=""></asp:Label>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td> locale </td>  
                        <td>  
                            <asp:Label ID="lbllocale" runat="server" Text=""></asp:Label>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td> link </td>  
                        <td>  
                            <asp:HyperLink ID="hylprofile" runat="server">Profile link</asp:HyperLink>  
                        </td>  
                    </tr>  
                </table>  
            </div>  
        </form>  
    </body>  
  
    </html>  