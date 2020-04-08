using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace genSignatures
{
    public class genSignatures
    {
        public static void Main(string[] args)
        {
            testObject to1 = new testObject();
            
            MemoryStream ms1 = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();
            BinaryFormatter ser = new BinaryFormatter();
            
            try 
            {
                ser.Serialize(ms1, to1);
                Console.WriteLine("ascii: " + Encoding.ASCII.GetString(ms1.ToArray()));
                Console.WriteLine("base64: " + Convert.ToBase64String(ms1.ToArray()));
                
                GZipStream compressionStream = new GZipStream(ms2, CompressionMode.Compress);
                
                compressionStream.Write(ms1.ToArray(), 0, ms1.ToArray().Length);
                Console.WriteLine("ascii: " + Encoding.ASCII.GetString(ms2.ToArray()));
                Console.WriteLine("base64: " + Convert.ToBase64String(ms2.ToArray()));
            }
            catch (SerializationException e) 
            {
                Console.WriteLine("SerializationException: " + e.Message);
                throw;
            }
        }
    }
}
