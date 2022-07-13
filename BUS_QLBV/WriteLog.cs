using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BUS_QLBV
{
    public class WriteLog
    {
        public static void Write(string nguoithuchien, string tenLog)
        {
            string day = "Log\\FileLog-" + DateTime.Now.ToString("dd-MM-yyyy") + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<log>));
            if (!Directory.Exists("log"))
            {
                Directory.CreateDirectory("log");
            }
            List<log> data = new List<log>();
            if (File.Exists(day))
            {
                StreamReader streamReader = new StreamReader(new FileStream(day, FileMode.Open));
                var dt = xml.Deserialize(streamReader);
                if (dt != null)
                {
                    data = dt as List<log>;
                }
                streamReader.Close();
            }

            data.Add(new log()
            {
                nguoidung = nguoithuchien,
                tenlog = tenLog,
                ngaygio = DateTime.Now.ToString()
            });
            StreamWriter streamWriter = new StreamWriter(new FileStream(day, FileMode.Create));
            xml.Serialize(streamWriter, data);
            streamWriter.Close();
        }

        public class log
        {
            public string nguoidung { get; set; }
            public string tenlog { get; set; }
            public string ngaygio { get; set; }
        }
    }
}
