<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DroneWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pharmakinematics DroneView</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="dronesGridView" runat="server"
                ItemType="DroneDAL.Models.Inventory"
                SelectMethod="GetData" Height="600px" Width="800px" AllowSorting="True" BackColor="#CCCCCC" BorderColor="#003300" BorderStyle="Solid" Font-Bold="True" Font-Names="Segoe UI" Font-Size="Medium">
                <HeaderStyle BackColor="#009900" BorderStyle="Dotted" Font-Bold="True" Font-Size="Large" />

            </asp:GridView>

            <img src="/images/web/drone.JPG" style="height: auto; width: auto" /></div>
    </form>
</body>
</html>
