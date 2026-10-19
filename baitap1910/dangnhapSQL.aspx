<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangnhapSQL.aspx.cs" Inherits="baitap1910.dangnhapSQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
     <style type="text/css">
        .container {
            width: 400px;
            border: 2px solid blue;
            margin: 0 auto;
            padding: 10px;
            border-radius: 5px;
            box-shadow: 0 0 10px red;
        }

        .dangChu {
            color: blue;
            font-size: 30px;
            font-weight: bold;
            padding: 5px;
        }

        .canle {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <h2 class="dangChu canle">Đăng nhập</h2>
            <br />

            <asp:Label ID="lblUser" runat="server"
                Text="Đăng nhập"
                Font-Size="20px" Font-Bold="true">
            </asp:Label>

            <p>
                <asp:TextBox ID="txtUser" runat="server"
                    Font-Size="20px" Width="380px">
                </asp:TextBox>
            </p>

            <p>
                <asp:Label ID="lblPass" runat="server"
                    Text="Mật khẩu"
                    Font-Size="20px" Font-Bold="true">
                </asp:Label>
            </p>

            <p>
                <asp:TextBox ID="txtPass" runat="server"
                    TextMode="Password"
                    Font-Size="20px" Width="380px">
                </asp:TextBox>
            </p>

            <p class="canle">
                <asp:Button ID="btnDangnhap" runat="server"
                    Text="Đăng nhập"
                    Font-Size="20px" Width="150px"
                    OnClick="btnDangnhap_Click" />

                &nbsp;&nbsp;

                <asp:Button ID="btnReset" runat="server"
                    Text="Reset"
                    Font-Size="20px" Width="100px"
                    OnClick="btnReset_Click" />
            </p>

            <p>
                <asp:Label ID="lblKetqua" runat="server"
                    Text="Kết quả: "
                    Font-Size="20px">
                </asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
