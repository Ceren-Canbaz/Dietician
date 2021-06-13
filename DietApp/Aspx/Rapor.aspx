<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/Diyetisyen.master" AutoEventWireup="true" CodeBehind="Rapor.aspx.cs" Inherits="DietApp.Rapor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
	<form id="form1" runat="server">
		<div class="container">
			<div >
				<asp:Label ID="Label1" runat="server" Text="Rapor tipi:"></asp:Label>
				<asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
					<asp:ListItem>JSON</asp:ListItem>
					<asp:ListItem>HTML</asp:ListItem>
				</asp:DropDownList>
				<br />
				<asp:DropDownList ID="DropDownList2"  CssClass="form-control" runat="server">
					<asp:ListItem Value="hasta">Hasta Bilgisi</asp:ListItem>
					<asp:ListItem Value="diyet">Diyet Bilgisi</asp:ListItem>
				</asp:DropDownList>
			</div>
			<br />
			<div>
				<asp:Button ID="Button1" CssClass="btn btn-info" runat="server" Text="Rapor Al" OnClick="Button1_Click" />
			</div>
			<br />
			<div>
				<asp:Label ID="Label2" runat="server"></asp:Label>
			</div>
		</div>
	</form>
</asp:Content>
