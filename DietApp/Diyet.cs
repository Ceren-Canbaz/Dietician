using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DietApp
{
	public interface IDiyet
	{
		void DiyetGuncelle(EntityKullanici hasta);
	}

	
	public class GlutenFree : IDiyet
	{
		Baglanti bgl = new Baglanti();

	

		public void DiyetGuncelle(EntityKullanici hasta)
		{
			SqlCommand diyetguncelle = new SqlCommand("UPDATE Kullanicilar set DiyetID=@p2 WHERE KullaniciID=@p3",bgl.baglanti());
			diyetguncelle.Parameters.AddWithValue("@p2", "2");
			diyetguncelle.Parameters.AddWithValue("@p3",hasta.KullaniciID);
			diyetguncelle.ExecuteNonQuery();
			bgl.baglanti().Close();
		}
	}
	public class YesilliklerDunyasi : IDiyet
	{
		Baglanti bgl = new Baglanti();

		

		public void DiyetGuncelle(EntityKullanici hasta)
		{
			SqlCommand ekle = new SqlCommand("UPDATE Kullanicilar set DiyetID=@p2 WHERE KullaniciID=@p3", bgl.baglanti());
			ekle.Parameters.AddWithValue("@p2", "4");
			ekle.Parameters.AddWithValue("@p3", hasta.KullaniciID);
			ekle.ExecuteNonQuery();
			bgl.baglanti().Close(); 
		}
	}

	public class Akdeniz : IDiyet
	{
		Baglanti bgl = new Baglanti();


		public void DiyetGuncelle(EntityKullanici hasta)
		{

			SqlCommand ekle = new SqlCommand("UPDATE Kullanicilar set DiyetID=@p2 WHERE KullaniciID=@p3", bgl.baglanti());
			ekle.Parameters.AddWithValue("@p2", "1");
			ekle.Parameters.AddWithValue("@p3", hasta.KullaniciID);
			ekle.ExecuteNonQuery();
			bgl.baglanti().Close();
		}

	}
	public class DenizUrunleri : IDiyet
	{
		Baglanti bgl = new Baglanti();


		public void DiyetGuncelle(EntityKullanici hasta)
		{
			SqlCommand ekle = new SqlCommand("UPDATE Kullanicilar set DiyetID=@p2 WHERE KullaniciID=@p3", bgl.baglanti());
			ekle.Parameters.AddWithValue("@p2", "3");
			ekle.Parameters.AddWithValue("@p3", hasta.KullaniciID);
			ekle.ExecuteNonQuery();
			bgl.baglanti().Close();
		}
	}
	public class DiyetBase
	{
		public IDiyet DiyetSecimi(string diyet)
		{
			if (diyet == "Gluten Free")
			{
				return new GlutenFree();
			}
			else if (diyet == "Yeşillikler Dünyası")
			{
				return new YesilliklerDunyasi();
			}
			else if (diyet == "Akdeniz")
			{
				return new Akdeniz();
			}
			else 
			{
			return new DenizUrunleri();
			}
	
		}
	}
}
