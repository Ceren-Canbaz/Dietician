using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DietApp
{
	public partial class HastaDetay : System.Web.UI.Page
	{
		EntityKullanici hasta = new EntityKullanici();
		Baglanti bgl = new Baglanti();
		protected void Page_Load(object sender, EventArgs e)
		{
			hasta.KullaniciID = Convert.ToInt32(Request.QueryString["KullaniciID"].ToString());
			SqlCommand oku = new SqlCommand("SELECT * FROM Kullanicilar k INNER JOIN Diyet d ON k.DiyetID=d.DiyetID INNER JOIN Hastalik h ON k.HastalikID=h.HastalikID WHERE KullaniciID=@p1", bgl.baglanti());
			oku.Parameters.AddWithValue("@p1", hasta.KullaniciID);
			SqlDataReader dr = oku.ExecuteReader();
			while(dr.Read())
			{
				TxtHastaAd.Text = dr["KullaniciAd"].ToString();
				TxtHastaSoyd.Text = dr["KullaniciSoyad"].ToString();
				TxtHastaTC.Text = dr["KullaniciTC"].ToString();
				TxtHastalik.Text = dr["HastalikAd"].ToString();
			}
			dr.Close();
			TxtHastalik.Enabled = false;
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
		
			DiyetBase diyetbase = new DiyetBase();
			IDiyet secim = diyetbase.DiyetSecimi(DropDownList1.SelectedValue.ToString());
			secim.DiyetGuncelle(hasta);
			Response.Redirect("Hastalar.aspx");
			Label5.Text = "Hasta Bilgileri Güncellendi";
		}
	}
}