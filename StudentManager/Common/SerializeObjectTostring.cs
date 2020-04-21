using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Common
{
    /// <summary>
    /// 将任意指定对象序列化成字符串格式数据
    /// </summary>
    public class SerializeObjectTostring
    {
        /// <summary>
        /// 将对象进行序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeObject(object obj)
        {
            BinaryFormatter binary = new BinaryFormatter();
            string result = string.Empty;
            using (MemoryStream stream=new MemoryStream())
            {
                binary.Serialize(stream,obj);
                byte[] buffer = new byte[stream.Length];
                buffer = stream.ToArray();
                result = Convert.ToBase64String(buffer);
                //result = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                stream.Flush();
            }
            return result;
        }
        /// <summary>
        /// 反序列化成对象
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static object DeserializeObject(string str)
        {
            BinaryFormatter binary = new BinaryFormatter();
            byte[] buffer = Convert.FromBase64String(str);
            object obj = null;
            using (MemoryStream stream=new MemoryStream(buffer,0,buffer.Length))
            {
                obj = binary.Deserialize(stream);
            }
            return obj;
        }
    }
}
