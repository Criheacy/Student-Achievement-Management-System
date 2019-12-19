using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Students_Achievement_Management_System
{
    public static class JsonReader
    {
        public static void SaveJsonFile(List<Student> student, string fileName)
        {
            string JsonText = JsonConvert.SerializeObject(student);

            File.WriteAllText(fileName, JsonText);
        }
    }
}
