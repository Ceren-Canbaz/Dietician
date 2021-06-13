using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DietApp
{
	public partial class Admin1 : System.Web.UI.Page
	{
		Baglanti bgl = new Baglanti();
		EntityKullanici diyetisyen = new EntityKullanici();
		protected void Page_Load(object sender, EventArgs e)
		{
			SqlCommand listele = new SqlCommand("SELECT*FROM Kullanicilar WHERE KullaniciRol='Diyetisyen'", bgl.baglanti());
			SqlDataReader dr = listele.ExecuteReader();
			Repeater2.DataSource = dr;
			Repeater2.DataBind();
			bgl.baglanti().Close();

			SqlCommand sil = new SqlCommand("DELETE FROM Kullanicilar WHERE KullaniciID=@p1",bgl.baglanti());
			diyetisyen.KullaniciID = Convert.ToInt32(Request.QueryString["KullaniciID"]);
			sil.Parameters.AddWithValue("@p1", diyetisyen.KullaniciID);
			sil.ExecuteNonQuery();

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			SqlCommand ekle = new SqlCommand("insert into Kullanicilar(KullaniciAd,KullaniciSoyad,KullaniciTC,KullaniciRol)values(@p1,@p2,@p3,@p4)",bgl.baglanti());
			ekle.Parameters.AddWithValue("@p1",txtAd.Text);
			ekle.Parameters.AddWithValue("@p2",txtSoyad.Text);
			ekle.Parameters.AddWithValue("@p3",txtTC.Text);
			ekle.Parameters.AddWithValue("@p4","Diyetisyen");
			ekle.ExecuteNonQuery();
			bgl.baglanti().Close();
			Response.Redirect("Admin.aspx");
		}
	}
}