<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Quiz_Vendly_2301858345.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome to Our Note</h1>
        <div>
            <asp:GridView ID="OurNoteGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="OurNoteGV_RowDeleting" OnRowEditing="OurNoteGV_RowEditing">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Note Title" SortExpression="OurNote" />
                    <asp:BoundField DataField="Writer" HeaderText="Note Writer" SortExpression="OurNote" />
                    <asp:BoundField DataField="Content" HeaderText="Note Content" SortExpression="OurNote" />
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:Button ID="insertBtn" runat="server" Text="Insert Note" OnClick="insertBtn_Click" />
    </form>
</body>
</html>
