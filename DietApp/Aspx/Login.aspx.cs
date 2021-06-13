using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace DietApp
{
	public partial class Login : System.Web.UI.Page
	{
		Baglanti bgl = new Baglanti();
		EntityKullanici kullanici = new EntityKullanici();
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("SELECT*FROM Kullanicilar WHERE KullaniciTC=@p1 AND KullaniciParola=@p2",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1",TextBox1.Text);
			komut.Parameters.AddWithValue("@p2",TextBox2.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				kullanici.KullaniciRol = dr["KullaniciRol"].ToString();
				kullanici.KullaniciID = Convert.ToInt32(dr["KullaniciID"].ToString());
				Session.Add("KullaniciID",kullanici.KullaniciID);

				if (kullanici.KullaniciRol == "Diyetisyen")
				{
					Response.Write("Diyetisyen girişi");
					Response.Redirect("Hastalar.aspx");
				}
				else if (kullanici.KullaniciRol == "Admin")
				{
					Response.Write("Admin girişi");
					Response.Redirect("Admin.aspx");
				}
			}
			else
			{ 
				Label3.Text = "Kullanıcı Adı veya Şifre Hatalı";
			}
		}
	}
}