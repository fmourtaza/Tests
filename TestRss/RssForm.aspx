<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RssForm.aspx.cs" Inherits="TestRss.RssForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptRSS" runat="server" OnItemDataBound="rptRSS_ItemDataBound">
                <HeaderTemplate>
                    <table class="tablerss">
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td class="rsstitle">
                            <asp:Label ID="lblRSSTitle" runat="server" CssClass="rsshead"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="lnkArticle" runat="server"></asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td class="rssdescription">
                            <asp:Label ID="lblDescription" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="rssimage">
                            <asp:Image ID="imgRss" runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>

                <FooterTemplate>
                    </table>
                    <br />
                </FooterTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
