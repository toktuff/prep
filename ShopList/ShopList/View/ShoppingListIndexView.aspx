<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingListIndexView.aspx.cs"
    Inherits="ShopList.View.ShoppingListIndexView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <table id="theTable" runat="server"></table>
    <table style="width: 100%;">
        <tr>
            <th>
                List name
            </th>
            <th>
                Stuff
            </th>
        </tr>
        <%
            for (int i = 0; i < Names.Count; i++) {
                var name = Names[i];
            var id = Ids[i];
          %>
          <tr>
          <td>
          <p><%=name%></p>
          </td>
          <td>
              <asp:Button ID="deleteButton" runat="server" Text="Delete" 
                  onclick="DeleteButtonClick"/>     
          </td>
          </tr>
        <%} %>
    </table>
    </form>
</body>
</html>
