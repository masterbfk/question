using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace netcadAssessment
{
    public static class GetDataFromStaticFile
    {
        public static List<int[]> getData()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string path = System.IO.Path.GetDirectoryName(asm.Location)+ "\\a.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            List<int[]> dataList = new List<int[]>();
            string data = sw.ReadLine();
            while (data != null)
            {                
                string[] st= data.Split(',');
                dataList.Add( Array.ConvertAll(st, s => int.Parse(s)));
                data = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            return dataList;
        }
    }
}
