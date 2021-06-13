using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace DietApp
{
	public class Baglanti
	{
		public SqlConnection baglanti()
		{
			SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-TTOQ6J4\\SQLEXPRESS;Initial Catalog=Diyet;Integrated Security=True");
			baglan.Open();
			return baglan;
		}
	}
}