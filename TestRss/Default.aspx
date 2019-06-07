<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestRss.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Latest News</h1>
            <p>
                <b>
                    <asp:Label ID="lblRDate1" runat="server" Text=""></asp:Label></b>
            </p>
            <p>
                <asp:Label ID="lblRss1" runat="server" Text=""></asp:Label>
            </p>
            <hr style="border: none; background-color: #dedede; color: #dedede; height: 1px;" />

            <p>
                <b>
                    <asp:Label ID="lblRDate2" runat="server" Text=""></asp:Label></b>
            </p>
            <p>
                <asp:Label ID="lblRss2" runat="server" Text=""></asp:Label>
            </p>
            <hr style="border: none; background-color: #dedede; color: #dedede; height: 1px;" />
        </div>
    </form>
</body>
</html>
