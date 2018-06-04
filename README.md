# INISerializer example

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INI_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect r = new Rect();
            r.a = 100;
            r.b = 200;
            string s = INISerializer.INISerializer.SerializeObject(r);
            string path = @"path\file.ini";
            try
            {
                File.Create(path).Dispose();
		using (var tw = new StreamWriter(path, true))
		{
			tw.WriteLine(s);
		}
            }
            catch(Exception)
            {

            }
            object obj = INISerializer.INISerializer.deserializeObject(path);
        }
    }
    class Rect
    {
        public int a { get; set; }
        public int b { get; set; }
    }
}
```
