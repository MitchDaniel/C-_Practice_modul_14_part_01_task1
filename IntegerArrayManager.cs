using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization.DataContracts;

namespace CSharp_Practice_modul_14_part_01
{
    internal static class IntegerArrayManager
    {
        public static string Serialize(IntegerArray integerArray)
        {
            return JsonSerializer.Serialize(integerArray);
        }

        public static IntegerArray Deserialize(string json)
        {
            return JsonSerializer.Deserialize<IntegerArray>(json) ?? throw new NullReferenceException();
        }

        public static void SaveToFile(string json, string path)
        {
            if(json is null) throw new ArgumentNullException(nameof(json));
            if(path is null) throw new ArgumentNullException(nameof(path)); 
            if(!File.Exists(path)) throw new FileNotFoundException();
            using FileStream fileStream = new FileStream(path, FileMode.Open);
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            fileStream.Write(bytes, 0, bytes.Length);
        }

        public static string LoadFromFile(string path)
        {
            if (path is null) throw new ArgumentNullException(nameof(path));
            if (!File.Exists(path)) throw new FileNotFoundException();
            using FileStream fileStream = new FileStream(path, FileMode.Open);
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            return Encoding.UTF8.GetString(bytes) ?? throw new FileLoadException();
        }
    }
}
