<%@ Page Title="Ana Sayfa" MasterPageFile="~/Template.Master" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Emlak.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="main">
    <header id="header">
		<div class="logo"><a href="Default.aspx">Emlak Takip</a></div>
		<a href="#menu">Menu</a>
	</header>
    <section id="banner">
	<div class="inner">
	    <header>
			<h1>Emlak Takip Portalı</h1>
			<p>Tüm internet portallarına uygun olarak hazırlanmış bir veritabanı<br />
            sayesinde gayrimenkul portföylerinizi internet ortamında yayınlayabilirsiniz.</p>
		</header>
		<a href="OturumAc.aspx" class="button big scrolly">Oturum Aç</a>
	</div>
    </section>

	<section class="wrapper style1">
	    <div class="inner">
			<div class="flex flex-2">
				<div class="col col1">
					<div class="image round fit">
						<img src="images/foto1.png" alt="" />
					</div>
				</div>
				<div class="col col2">
					<h3>Emlak Takip Portalı</h3>
					<p>Tüm internet portallarına uygun olarak hazırlanmış bir veritabanı sayesinde gayrimenkul portföylerinizi internet ortamında yayınlayabilirsiniz.</p>
					<p>Sade, şık, kolay bir arayüz ile emlak işlemlerinizi tek bir web portalı üzerinde birleştirdik. İşlemlerinizi kolay ve hızlı çözümlerle gerçekleştirebilir
                    ve bu sayede müşteri memnuniyetini arttırabilirsiniz.</p>                 
					<a href="OturumAc.aspx" class="button">Oturum Aç</a>
				</div>
			</div>
		</div>
	</section>

	<section class="wrapper style2">
		<div class="inner">
			<div class="flex flex-2">
				<div class="col col2">
					<h3>İş Yükünüzü Azaltın</h3>
					<p>Tamamen emlak danışmanlarının isteklerine cevap verebilecek şekilde olan portalımız sayesinde gayrimenkul portföyünüzü profesyonel bir şekilde 
                    yönetmenize imkan sağlamaktadır.</p>
					<p>Müşterilerimizin, ürün hizmetlerini en etkin medya kabul edilen internet ortamına taşımak müşterilerimizin işlerine değer 
                    katabilmek gibi önemli ve zor bir görevi üstlendik.</p>
					<a href="KayitOl.aspx" class="button">Kayıt Ol</a>
				</div>
				<div class="col col1 first">
					<div class="image round fit">
						<img src="images/foto2.png" alt="" />
					</div>
				</div>
			</div>
		</div>
	</section>

	<section class="wrapper style1">
		<div class="inner">
			<header class="align-center">
				<h2>Vesta Yazılım</h2>
				<p style="font-size:20px">Tasarım, yazılım ve internet alanlarında uzman ve her biri on yılın üzerinde tecrübelere sahip profesyonellerin bir araya geldiği bir bilişim firmasıdır.
                İş dünyası ağırlıklı olmak üzere, çeşitli kurum ve kuruluşlara anahtar teslim internet ve yazılım çözümleri sunmaktayız.
                Müşterilerimizin, ürün ve hizmetlerini en etkin medya kabul edilen internet ortamına taşımak gibi önemli ve zor bir görevi üstlendik.</p>
			</header>
			<div class="flex flex-3">
				<div class="col align-center">
					<div class="image round fit">
						<img src="images/foto3.png" alt="" />
					</div>
					<p>Emlak ofislerinin ve gayrimenkul danışmanlarının ihtiyacı olan tüm uygulamalar bu yazılımda birleşti.</p>
				</div>
				<div class="col align-center">
					<div class="image round fit">
						<img src="images/foto4.jpg" alt="" />
					</div>
					<p>Sektörün önde gelen portalları sahibinden.com, hurriyetemlak.com ve diğer portallara yayınlayabilirsiniz.</p>
				</div>
				<div class="col align-center">
					<div class="image round fit">
						<img src="images/foto5.png" alt="" />
					</div>
					<p>İçerisindeki hazır şablonları kullanarak size ait özel web sayfası oluşturma imkanı hazırlıyor. Kendinize ait web sayfayı oluşturun.</p>
				</div>
			</div>
		</div>
	</section>

</div>

</asp:Content>
