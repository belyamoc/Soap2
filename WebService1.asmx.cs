using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace soap
{
	/// <summary>
	/// Descripción breve de WebService1
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
	// [System.Web.Script.Services.ScriptService]
	public class WebService1 : System.Web.Services.WebService
	{

		[WebMethod]
		public string HelloWorld()
		{
			return "Hola a todos";
		}
		[WebMethod]
		public string ConsultaPrecio(int codigo) {
			SqlConnection cn = new SqlConnection("Server=tcp:utec2020.database.windows.net,1433;Initial Catalog=DBUTECITER;Persist Security Info=False;User ID=utecadmin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			cn.Open();
			SqlCommand cm = new SqlCommand();
			cm.Connection = cn;
			cm.CommandText = "select ListPrice from [SalesLT].Product where ProductID= " + codigo;
			return cm.ExecuteScalar().ToString();
			

		}
	}
}
