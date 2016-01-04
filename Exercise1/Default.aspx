<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div>
            <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownInputType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ConvertInputToSEK_Event">
                <asp:ListItem value="sek">SEK</asp:ListItem>
                <asp:ListItem value="euro">Euro</asp:ListItem>
                <asp:ListItem value="dollar">Dollar</asp:ListItem>
                <asp:ListItem value="pound">Pound</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:TextBox ID="TextboxOutput" ReadOnly="true" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownOutputType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ConvertInputToSEK_Event">
                <asp:ListItem value="sek">SEK</asp:ListItem>
                <asp:ListItem value="euro">Euro</asp:ListItem>
                <asp:ListItem value="dollar">Dollar</asp:ListItem>
                <asp:ListItem value="pound">Pound</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="ButtonConvert" runat="server" OnClick="ConvertInputToSEK_Event" Text="Convert Currency"/>
    </div>
    </form>
</body>
</html>
