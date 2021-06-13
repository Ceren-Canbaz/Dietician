using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DietApp
{
	public partial class Rapor : System.Web.UI.Page
	{
		EntityKullanici hasta = new EntityKullanici();
		Baglanti bgl = new Baglanti();
		protected void Page_Load(object sender, EventArgs e)
		{
			hasta.KullaniciID = Convert.ToInt32(Request.QueryString["KullaniciID"].ToString());
			SqlCommand oku = new SqlCommand("SELECT*FROM Kullanicilar k INNER JOIN Hastalik h ON k.HastalikID = h.HastalikID INNER JOIN Diyet d ON k.DiyetID = d.DiyetID WHERE k.KullaniciID=@p1", bgl.baglanti());
			oku.Parameters.AddWithValue("@p1", hasta.KullaniciID);
			SqlDataReader dr = oku.ExecuteReader();
			while (dr.Read())
			{
				hasta.KullaniciAd = dr["KullaniciAd"].ToString();
				hasta.KullaniciSoyad = dr["KullaniciSoyad"].ToString();
				hasta.KullaniciTC = dr["KullaniciTC"].ToString();
				hasta.DiyetAd = dr["DiyetAd"].ToString();
				hasta.HastalikAd = dr["HastalikAd"].ToString();
			}
			dr.Close();



		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			ReportInfo rapor = new ReportInfo() { dietName = hasta.DiyetAd, patientName = hasta.KullaniciAd, patientTC = hasta.KullaniciTC, illness = hasta.HastalikAd };
			if (DropDownList1.SelectedValue == "JSON")
			{
				JsonReportBuilder jsonReportBuilder = new JsonReportBuilder(rapor);
				ReportManager reportManager = new ReportManager(jsonReportBuilder);
				if (DropDownList2.SelectedValue == "hasta")
				{
					Label2.Text = reportManager.BuildOutput();
				}
				else if (DropDownList2.SelectedValue == "diyet")
				{
					Label2.Text = reportManager.BuildUpsideDown();
				}
			}
			else if (DropDownList1.SelectedValue == "HTML")
			{
				HtmlReportBuilder htmlReportBuilder = new HtmlReportBuilder(rapor);
				ReportManager reportManager2 = new ReportManager(htmlReportBuilder);
				if (DropDownList2.SelectedValue == "hasta")
				{
					Label2.Text = reportManager2.BuildOutput();
				}
				else if (DropDownList2.SelectedValue == "diyet")
				{
					Label2.Text = reportManager2.BuildUpsideDown();
				}
			}
		}
	}
}