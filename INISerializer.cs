using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INISerializer
{
    public class INISerializer
    {
		Object obj;
		public INISerializer(){}
		public string SerializeObject(Object obj)
		{
			this.obj = obj;
			return (obj == null) ? null : doTask();
		}
		private string doTask()
		{
			
		}
    }
}
