<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="DietApp.Admin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
	<div class="container">
		<form runat="server">

			<div>
				<asp:Label ID="Label2" runat="server" Text="Diyetisyen Adı:"></asp:Label>
				<asp:TextBox ID="txtAd" runat="server" CssClass="form-control"></asp:TextBox>
			</div>
			<br />
			<div>
				<asp:Label ID="Label3" runat="server" Text="Diyetisyen Soyad:"></asp:Label>
				<asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
			</div>
			<div>
				<asp:Label ID="Label4" runat="server" Text="Diyetisyen TC:"></asp:Label>
				<asp:TextBox ID="txtTC" runat="server" CssClass="form-control"></asp:TextBox>

				<br />
				<asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn btn-info " OnClick="Button1_Click" />
			</div>
		</form>
		<br />
		<div>
			<table class="table table-bordered table-hover">
				<tr>
					<th>Diyetisyen ID</th>
					<th>Diyetisyen Adı</th>
					<th>Diyetisyen Soyadı</th>
					<th>Diyetisyen TC</th>
					<th></th>
					<tbody>
						<asp:Repeater ID="Repeater2" runat="server">
							<ItemTemplate>
								<tr>
									<td><%#Eval("KullaniciID")%></td>
									<td><%#Eval("KullaniciAd")%></td>
									<td><%#Eval("KullaniciSoyad")%></td>
									<td><%#Eval("KullaniciTC")%> </td>
									<td>
										<asp:HyperLink NavigateUrl='<%#"~/Aspx/Admin.aspx?KullaniciID="+Eval("KullaniciID")%>' ID="HyperLink2" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
									</td>
								</tr>
							</ItemTemplate>
						</asp:Repeater>
					</tbody>
				</tr>

			</table>
		</div>
		</div>
</asp:Content>
