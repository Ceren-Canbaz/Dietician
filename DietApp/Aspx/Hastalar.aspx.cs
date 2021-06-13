using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DietApp
{
	public partial class Hastalar : System.Web.UI.Page
	{
		Baglanti bgl = new Baglanti();
		EntityKullanici diyetisyen = new EntityKullanici();
		protected void Page_Load(object sender, EventArgs e)
		{
			diyetisyen.KullaniciID = Convert.ToInt32(Session["KullaniciID"].ToString());
			SqlCommand komut = new SqlCommand("SELECT*FROM Kullanicilar k INNER JOIN Hastalik h ON k.HastalikID = h.HastalikID INNER JOIN Diyet d ON k.DiyetID = d.DiyetID WHERE k.DiyetisyenID=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1",diyetisyen.KullaniciID);
			komut.ExecuteNonQuery();
			SqlDataReader dr = komut.ExecuteReader();
			Repeater2.DataSource = dr;
			Repeater2.DataBind();
		}

	}
}