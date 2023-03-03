using System.IO;
using System.Xml.Serialization;

namespace PiectureViewer
{
    public class FileHelper<T> where T : new()
    {
        private string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T picture)
        {
            var serializer = new XmlSerializer (typeof (T));  

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, picture);
                streamWriter.Close();
            }
        }

        public T DeserializeFromFile() 
        {
            if (!File.Exists(_filePath))
                return new T();
            
            var serializer = new XmlSerializer(typeof (T));

            using (var stramReader = new StreamReader(_filePath))
            {
                var pictures = (T)serializer.Deserialize (stramReader);
                stramReader.Close();
                return pictures;
            }
        }
    }
}
