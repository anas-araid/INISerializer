using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace INISerializer
{
	public static class INISerializer
	{
		public static string SerializeObject(object obj)
		{
			return (obj == null) ? null : buildIniString(getPropertiesInfo(obj));
		}
		private static Dictionary<string, string> getPropertiesInfo(object obj)
		{
			Dictionary<string, string> _propertyDict = new Dictionary<string, string>();
			PropertyInfo[] properties = obj.GetType().GetProperties();
			foreach (var prop in properties)
			{
				_propertyDict.Add(prop.Name, prop.GetValue(obj, null).ToString());
			}

			return _propertyDict;
		}
		private static string buildIniString(Dictionary<string, string> props)
		{

			return "";
		}
	}
}
