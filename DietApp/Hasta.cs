using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace DietApp
{
	public interface IHasta
	{
		void HastaEkle(EntityKullanici hasta);
	}
	public class Obez : IHasta
	{
		Baglanti bgl = new Baglanti();
		public void HastaEkle(EntityKullanici hasta)
		{
			SqlCommand ekle = new SqlCommand("insert into Kullanicilar(KullaniciAd,KullaniciSoyad,KullaniciTC,HastalikID,DiyetID,DiyetisyenID)values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
			ekle.Parameters.AddWithValue("@p1", hasta.KullaniciAd);
			ekle.Parameters.AddWithValue("@p2", hasta.KullaniciSoyad);
			ekle.Parameters.AddWithValue("@p3", hasta.KullaniciTC);
			ekle.Parameters.AddWithValue("@p4", hasta.HastalikID);
			ekle.Parameters.AddWithValue("@p5", hasta.DiyetID);
			ekle.Parameters.AddWithValue("@p6", hasta.DiyetisyenID);
			ekle.ExecuteNonQuery();
		}
	}
	public class Colyak : IHasta
	{
		Baglanti bgl = new Baglanti();
		public void HastaEkle(EntityKullanici hasta)
		{
			SqlCommand ekle = new SqlCommand("insert into Kullanicilar(KullaniciAd,KullaniciSoyad,KullaniciTC,HastalikID,DiyetID,DiyetisyenID)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
			ekle.Parameters.AddWithValue("@p1", hasta.KullaniciAd);
			ekle.Parameters.AddWithValue("@p2", hasta.KullaniciSoyad);
			ekle.Parameters.AddWithValue("@p3", hasta.KullaniciTC);
			ekle.Parameters.AddWithValue("@p4", hasta.HastalikID);
			ekle.Parameters.AddWithValue("@p5", hasta.DiyetID);
			ekle.Parameters.AddWithValue("@p6", hasta.DiyetisyenID);
			ekle.ExecuteNonQuery();
		}
	}
	public class Seker : IHasta
	{
		Baglanti bgl = new Baglanti();
		public void HastaEkle(EntityKullanici hasta)
		{
			SqlCommand ekle = new SqlCommand("insert into Kullanicilar(KullaniciAd,KullaniciSoyad,KullaniciTC,HastalikID,DiyetID,DiyetisyenID)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
			ekle.Parameters.AddWithValue("@p1", hasta.KullaniciAd);
			ekle.Parameters.AddWithValue("@p2", hasta.KullaniciSoyad);
			ekle.Parameters.AddWithValue("@p3", hasta.KullaniciTC);
			ekle.Parameters.AddWithValue("@p4", hasta.HastalikID);
			ekle.Parameters.AddWithValue("@p5", hasta.DiyetID);
			ekle.Parameters.AddWithValue("@p6", hasta.DiyetisyenID);
			ekle.ExecuteNonQuery();
		}
	}
	public class HastaBase
	{
		public IHasta HastaEkle(int hastalik)
		{
			if (hastalik == 1)
			{
				return new Obez();
			}
			else if(hastalik==2)
			{
				return new Colyak();
			}
			else
			{
				return new Seker();
			}

		}
	}
}