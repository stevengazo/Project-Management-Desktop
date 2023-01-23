using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Xml;
using System.Text.Json;

namespace Datos
{
	public static class XMLConfiguraciones
	{
		

		public static string LeerCadenaDeConexion()
		{
			try
			{
				string urlArchivo = Path.Combine( Directory.GetCurrentDirectory() ,"Configuracion.xml");
				var data = new FileStream(urlArchivo, FileMode.Open, FileAccess.Read);
				var documento = new XmlDataDocument();
				documento.Load(data);
				XmlNodeList nodeList = documento.GetElementsByTagName("cadenasdeconexion");

				foreach (XmlNode item in nodeList)
				{
					var daata= item.SelectSingleNode("DBAsfaltos").InnerText.ToString();
					return daata;
				}
				return null;
			}catch(Exception f)
			{
				return null;
			}
		}

	}
}
