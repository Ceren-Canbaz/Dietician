<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/Diyetisyen.master" AutoEventWireup="true" CodeBehind="Hastalar.aspx.cs" Inherits="DietApp.Hastalar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
	<form id="form1" runat="server">
	<div>
		<div class="container">
		<table class="table table-bordered table-hover">
		<tr>
			<th>Hasta TC</th>
			<th>Hasta Adı</th>
			<th>Hasta Soyadı</th>	
			<th>Hastalık tipi</th>	
			<th>Diyet Yöntemi</th>
			<th></th>
			<th></th>
			<tbody>
				<asp:Repeater ID="Repeater2" runat="server">
					<ItemTemplate>
						<tr>
							<td><%#Eval("KullaniciTC")%> </td>
							<td><%#Eval("KullaniciAd")%></td>
							<td><%#Eval("KullaniciSoyad")%></td>
							<td><%#Eval("HastalikAd")%></td>
							<td><%#Eval("DiyetAd")%> </td>
							<td>
								<asp:HyperLink NavigateUrl='<%#"~/Aspx/HastaDetay.aspx?KullaniciID="+Eval("KullaniciID")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Düzenle</asp:HyperLink>
							</td>
								<td>
								<asp:HyperLink NavigateUrl='<%#"~/Aspx/Rapor.aspx?KullaniciID="+Eval("KullaniciID")%>' ID="HyperLink1" CssClass="btn btn-success" runat="server">Rapor Al</asp:HyperLink>
							</td>
						</tr>
					</ItemTemplate>
				</asp:Repeater>
			</tbody>
		</tr>

	</table>
	</div>
	</div>
	</form>
</asp:Content>
