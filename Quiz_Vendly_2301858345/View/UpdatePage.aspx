<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Quiz_Vendly_2301858345.View.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Update Note</h1>
        <div>
            <asp:Label ID="titleLbl" runat="server" Text="Title: "></asp:Label>
            <asp:TextBox ID="titleTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="writerLbl" runat="server" Text="Writer: "></asp:Label>
            <asp:TextBox ID="writerTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="contentLbl" runat="server" Text="Content: "></asp:Label>
            <asp:TextBox ID="contentTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="codeLbl" runat="server" Text="Code: "></asp:Label>
            <asp:TextBox ID="codeTxt" runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="updateBtn" runat="server" Text="Update Note" OnClick="updateBtn_Click" />
        <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
