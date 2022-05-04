<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestDataWebForm.aspx.cs" Inherits="_7PracticeExample.GuestDataWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Guests" runat="server" AutoGenerateColumns="False" DataKeyNames="Phone" DataSourceID="SqlDataSourceGuests">
                <Columns>
                    <asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" SortExpression="Phone" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Agreement" HeaderText="Agreement" SortExpression="Agreement" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourceGuests" runat="server" ConnectionString="<%$ ConnectionStrings:GuestContext %>" SelectCommand="SELECT * FROM [Guests]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
