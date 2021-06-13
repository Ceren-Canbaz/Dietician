using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietApp
{
	public class EntityKullanici
	{
		public int KullaniciID { get; set; }
		public string KullaniciAd { get; set; }
		public string KullaniciSoyad { get; set; }
		public string KullaniciParola { get; set; }
		public string KullaniciRol { get; set; }
		public string KullaniciTC { get; set; }
		public int DiyetisyenID { get; set; }
		public int DiyetID { get; set; }
		public int HastalikID { get; set; }
		public string DiyetAd { get; set; }
		public string HastalikAd { get; set; }
	}
}