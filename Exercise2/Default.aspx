<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonLoadCategories" runat="server" OnClick="ButtonLoadCategories_OnClick" Text="Load Product Categories"/>
            <asp:DropDownList ID="DropDownCategories" runat="server" AutoPostBack="True"/>
            <asp:Label ID="LabelInfo" runat="server" Text="" Visible="False"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TextBoxCategoryName" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonAddCategory" runat="server" OnClick="ButtonAddCategory_OnClick" Text="Add Product Category"/>
        </div>

    </form>
</body>
</html>
