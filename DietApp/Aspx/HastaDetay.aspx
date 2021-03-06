<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/Diyetisyen.master" AutoEventWireup="true" CodeBehind="HastaDetay.aspx.cs" Inherits="DietApp.HastaDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
	<div class="container">
		<form runat="server">
			<div>
				<asp:Label ID="Label2" runat="server" Text="Hasta Adı:"></asp:Label>
				<asp:TextBox ID="TxtHastaAd" runat="server" CssClass="form-control"></asp:TextBox>
			</div>
			<br />
			<div>
				<asp:Label ID="Label3" runat="server" Text="Hasta Soyadı:"></asp:Label>
				<asp:TextBox ID="TxtHastaSoyd" runat="server" CssClass="form-control"></asp:TextBox>
			</div>
			<br />
			<div>
				<asp:Label ID="Label4" runat="server" Text="TC:"></asp:Label>
				<asp:TextBox ID="TxtHastaTC" runat="server" CssClass="form-control"></asp:TextBox>
			</div>
			<br />
			<div>
				<asp:Label ID="Label6" runat="server" Text="Hastalık:"></asp:Label>
				<asp:TextBox ID="TxtHastalik" runat="server" CssClass="form-control"></asp:TextBox>
			</div>
			<br />
			<div>
				<asp:Label ID="Label1" runat="server" Text="Diyet Yöntemi:"></asp:Label>
				<asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="DiyetAd" DataValueField="DiyetAd"></asp:DropDownList>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DiyetConnectionString %>" SelectCommand="SELECT [DiyetAd], [DiyetID] FROM [Diyet]"></asp:SqlDataSource>
			</div>
			<br />
			<asp:Label ID="Label5" runat="server"></asp:Label>
			<br />
			<asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-info " OnClick="Button1_Click" />
		</form>
	</div>
</asp:Content>
