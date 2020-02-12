<%@ Page Title="Emlak Kayıt" MasterPageFile="~/Template.Master" Language="C#" AutoEventWireup="true" CodeBehind="EmlakKayit.aspx.cs" Inherits="Emlak.EmlakKayit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="main">

    <header id="header">
		<div class="logo"><a href="Default.aspx">Emlak Takip</a></div>
		<a href="#menu">Menu</a>
	</header>
    <section class="wrapper">
	    <div class="inner">
            <header class="align-center">
				<h1>Emlak Kayıt Paneli</h1>
                <br />
                <table style="width:100%; height:100%">
                <tr style="background-color:white">
                    <td align="center">
                        <table style="text-align:center; width:90%; height:90%">
                            <tr style="background-color:white; border:none">
                                <td></td>
                                <td><asp:Button ID="Button3" runat="server" Width="200" Text="Arsa" OnClick="Button3_Click" /></td>
                                <td></td>
                                <td><asp:Button ID="Button4" runat="server" Width="200" Text="Daire" OnClick="Button4_Click" /></td>
                            </tr>
                            <tr style="background-color:white; border:none">
                                <td>Metrekare</td>
                                <td><asp:TextBox ID="TextBox1" runat="server" BackColor="White" MaxLength="10"></asp:TextBox></td>
                                <td>Salon Sayısı</td>
                                <td><asp:TextBox ID="TextBox2" runat="server" BackColor="White" MaxLength="10"></asp:TextBox></td>
                            </tr>
                            <tr style="background-color:white; border:none">
                                <td>Oda Sayısı</td>
                                <td><asp:TextBox ID="TextBox3" runat="server" BackColor="White" MaxLength="10"></asp:TextBox></td>
                                <td>Balkon Sayısı</td>
                                <td><asp:TextBox ID="TextBox4" runat="server" BackColor="White" MaxLength="10"></asp:TextBox></td>
                            </tr>
                            <tr style="background-color:white; border:none">
                                <td>Emlak Sahibinin<br />Adı Soyadı</td>
                                <td><asp:TextBox ID="TextBox5" runat="server" BackColor="White" MaxLength="20"></asp:TextBox></td>
                                <td>Emlak Sahibinin<br />Telefon Numarası</td>
                                <td><asp:TextBox ID="TextBox6" runat="server" BackColor="White" MaxLength="11"></asp:TextBox></td>
                            </tr>
                            <tr style="background-color:white; border:none">
                                <td>Kiralık/Satılık</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem Selected="True">Kiralık</asp:ListItem>
                                    <asp:ListItem>Satılık</asp:ListItem>
                                    </asp:RadioButtonList></td>
                                <td>Ücret</td>
                                <td><asp:TextBox ID="TextBox7" runat="server" BackColor="White" MaxLength="30"></asp:TextBox></td>
                            </tr>
                            <tr style="background-color:white; border:none">
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            </header>
        </div>
    </section>

</div>

</asp:Content>
