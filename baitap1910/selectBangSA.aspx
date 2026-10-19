<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="selectBangSA.aspx.cs" Inherits="baitap1910.selectBangSA" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Danh sách nhân viên</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Danh sách nhân viên</h1>
            <asp:GridView ID="grvDanhsach" runat="server" AutoGenerateColumns="True"></asp:GridView>
        </div>
    </form>
</body>
</html>