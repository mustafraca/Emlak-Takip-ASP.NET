<%@ Page Title="Oturum Aç" MasterPageFile="~/Template.Master" Language="C#" AutoEventWireup="true" CodeBehind="OturumAc.aspx.cs" Inherits="Emlak.OturumAc" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="main">

    <header id="header">
		<div class="logo"><a href="Default.aspx">Emlak Takip</a></div>
		<a href="#menu">Menu</a>
	</header>
    <section class="wrapper">
	    <div class="inner">
            <header class="align-center">
				<h1>Oturum Aç</h1>
                <span>Kayıtlı değilseniz "KAYIT OL" bölümünden kayıt olunuz.</span><br />
                <span class="fa-4x"><asp:Label ID="Label1" runat="server" Text=""></asp:Label></span>
                <br />
                <table style="width:100%; height:100%">
                <tr style="background-color:white">
                    <td align="center">
                        <table style="text-align:center; width:30%; height:30%">
                            <tr>
                                <td>Kullanıcı Adı:</td>
                                <td><asp:TextBox ID="TextBox1" runat="server" MaxLength="20" BackColor="White"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Şifre:</td>
                                <td><asp:TextBox ID="TextBox2" runat="server" MaxLength="20" BackColor="White" TextMode="Password"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td><asp:Button ID="Button1" runat="server" Width="200" Text="Oturum Aç" OnClick="Button1_Click" /></td>
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
