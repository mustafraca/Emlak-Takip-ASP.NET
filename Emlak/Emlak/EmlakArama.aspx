<%@ Page Title="Emlak Arama" MasterPageFile="~/Template.Master" Language="C#" AutoEventWireup="true" CodeBehind="EmlakArama.aspx.cs" Inherits="Emlak.EmlakArama" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="main">

    <header id="header">
		<div class="logo"><a href="Default.aspx">Emlak Takip</a></div>
		<a href="#menu">Menu</a>
	</header>
    <section class="wrapper">
	    <div class="inner">
            <header class="align-center">
				<h1>Emlak Arama Paneli</h1>
                <br />
                <table style="width:100%; height:100%">
                <tr style="background-color:white">
                    <td align="center">
                        <table style="text-align:center; width:90%; height:90%">
                            <tr style="background-color:white; border:none">
                                <td><asp:Button ID="Button3" runat="server" Width="200" Text="Arsa" OnClick="Button3_Click" /></td>
                                <td><asp:Button ID="Button4" runat="server" Width="200" Text="Daire" OnClick="Button4_Click" /></td>
                            </tr>
                            <tr style="background-color:white; border:none">
                                <td>Metrekare</td>
                                <td><asp:TextBox ID="TextBox1" runat="server" BackColor="White"></asp:TextBox></td>
                            </tr>
                            <tr style="background-color:white; border:none">
                                <td></td>
                                <td><asp:Button ID="Button1" runat="server" Text="ARA" OnClick="Button1_Click" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr style="background-color:white; border:none">
                    <td>
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" GridLines="None" ForeColor="#333333">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            </header>
        </div>
    </section>

</div>

</asp:Content>
