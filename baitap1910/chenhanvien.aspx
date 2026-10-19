<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chenhanvien.aspx.cs" Inherits="baitap1910.chenhanvien" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chèn nhân viên</title>
    <style type="text/css">
        .container {
            width: 50%;
            margin: 0 auto;
            box-shadow: 0 0 5px blue;
            padding: 20px;
        }
        .style1 { width: 80%; }
        .style2 { width: 100%; padding: 5px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table class="style1" align="center">
                <caption><strong>THÊM BẢN GHI MỚI</strong></caption>

                <tr>
                    <td class="style2">
                        <asp:Label ID="lblManv" runat="server" Text="Mã nhân viên"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="txtManv" runat="server" autocomplete="off"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style2">
                        <asp:Label ID="lblHoten" runat="server" Text="Họ tên nhân viên"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="txtHoten" runat="server" autocomplete="off"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style2">
                        <asp:Label ID="lblUser" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="txtUser" runat="server" autocomplete="off"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style2">
                        <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" autocomplete="off"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style2"></td>
                    <td class="style2">
                        <asp:Button ID="btnDangky" runat="server" Text="Đăng ký" OnClick="btnDangky_Click" />
                    </td>
                </tr>
            </table>
        </div>

        <div>
            <asp:Label ID="lbl1" runat="server" Font-Bold="true" ForeColor="Green"></asp:Label>
        </div>

        <div>
            <h1>Danh sách nhân viên</h1>
            <asp:GridView ID="grvDanhsach" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>