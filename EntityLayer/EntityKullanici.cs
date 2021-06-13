using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
	public class EntityKullanici
	{
		private int kullaniciID;
		private string kullaniciAd;
		private string kullaniciSoyad;
		private string kullaniciTC;
		private string kullaniciParola;
		private string kullaniciRol;
		private int hastalikID;
		private int diyetisyenID;

		public int KullaniciID { get => kullaniciID; set => kullaniciID = value; }
		public string KullaniciAd { get => kullaniciAd; set => kullaniciAd = value; }
		public string KullaniciSoyad { get => kullaniciSoyad; set => kullaniciSoyad = value; }
		public string KullaniciTC { get => kullaniciTC; set => kullaniciTC = value; }
		public string KullaniciParola { get => kullaniciParola; set => kullaniciParola = value; }
		public string KullaniciRol { get => kullaniciRol; set => kullaniciRol = value; }
		public int HastalikID { get => hastalikID; set => hastalikID = value; }
		public int DiyetisyenID { get => diyetisyenID; set => diyetisyenID = value; }
	}
}
