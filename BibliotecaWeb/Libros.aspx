<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="BibliotecaWeb.Libros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height:100%; border:1px solid red;">
            <asp:GridView runat="server" ID="GridLibros"></asp:GridView>
            <asp:Button runat="server" Text="Consulta Todos" ID="BttConsulta" OnClick="BttConsulta_Click"></asp:Button>
            <asp:Button runat="server" Text="primer libro" ID="BttConsult1" OnClick="Unnamed1_Click"></asp:Button>
            <asp:Button runat="server" Text="ultimo libro" ID="BttConsulta2" OnClick="Unnamed2_Click"></asp:Button>
        </div>
        <div style="height:100%; border:1px solid red;">
            <table style="height:50px;" border="1">
                <tr>
                    <td style="height:30%">
                    </td>
                    <td style="height:30%">
                    </td>
                    <td style="height:30%">
                    </td>
                </tr>
                <tr>
                    <td style="height:100%">
                        <asp:Label runat="server" Text="ISBN:" ID="lb1" Font-Bold="True"></asp:Label>
                        <asp:TextBox runat="server" ID="txt1"></asp:TextBox>
                    </td>
                    <td style="height:100%">
                        <asp:Label runat="server" Text="Título:" ID="lb2" Font-Bold="True"></asp:Label>
                        <asp:TextBox runat="server" ID="txt2"></asp:TextBox>
                    </td>
                    <td style="height:100%">
                        <asp:Label runat="server" Text="Estante:" ID="lb3" Font-Bold="True"></asp:Label>
                        <asp:TextBox runat="server" ID="txt3"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:100%">
                        <asp:Label runat="server" Text="Sala:" ID="lb4" Font-Bold="True"></asp:Label>
                        <asp:TextBox runat="server" ID="txt4"></asp:TextBox>
                    </td>
                    <td style="height:100%">
                        <asp:Label runat="server" Text="Librero:" ID="lb5" Font-Bold="True"></asp:Label>
                        <asp:TextBox runat="server" ID="txt5"></asp:TextBox>
                    </td>
                    <td style="height:100%">
                        <asp:Label runat="server" Text="Posición:" ID="lb6" Font-Bold="True"></asp:Label>
                        <asp:TextBox runat="server" ID="txt6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:100%">
                    </td>
                    <td style="height:100%">
                        <asp:Button runat="server" Text="Guardar" ID="Button4" OnClick="Button4_Click"></asp:Button>
                    </td>
                    <td style="height:100%">
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
