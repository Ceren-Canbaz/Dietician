using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DietApp
{
	public partial class Ekle : System.Web.UI.Page
	{
		EntityKullanici hasta = new EntityKullanici();
		Baglanti bgl = new Baglanti();
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void Button1_Click(object sender, EventArgs e)
		{

			hasta.KullaniciAd = TxtHastaAd.Text;
			hasta.KullaniciSoyad = TxtHastaSoyd.Text;
			hasta.KullaniciTC = TxtHastaTC.Text;
			hasta.DiyetID = Convert.ToInt32(DropDownList1.SelectedValue);
			hasta.HastalikID = Convert.ToInt32(DropDownList2.SelectedValue);
			hasta.DiyetisyenID = Convert.ToInt32(Session["KullaniciID"].ToString());
			HastaBase hastabase = new HastaBase();
			IHasta hastalik = hastabase.HastaEkle(hasta.HastalikID);
			hastalik.HastaEkle(hasta);
			Response.Redirect("Hastalar.aspx");
		}
	}
}