using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Prototype.CopyThroughSerializationAndXml
{
    public static class ExtensionMethod
    {
        public static T DeepCopy<T>(this T self)
        {
            // Initializes a new instance of the MemoryStream
            // class with an expandable capacity initialized to zero.
            var stream = new MemoryStream();
            
            // Initializes a new instance of the BinaryFormatter class with default value.
            var formatter = new BinaryFormatter();
            
            // Serialization is the process of converting an object into a stream
            // of bytes to store the object or transmit it to memory, a database,
            // or a file. Its main purpose is to save the state of an object in order to be able to 
            // recreate it when needed. The reverse process is called deserialization.
            formatter.Serialize(stream, self);
            
            // Sets the current position of this stream to the given value.
            stream.Seek(0, SeekOrigin.Begin);
            
            // Deserializes a stream into an object graph.
            object copy = formatter.Deserialize(stream);
            
            // Closes the current stream and releases any resources.
            stream.Close();
            
            return (T) copy;
        }

        public static T DeepCopyXml<T>(this T self)
        {
            // Initializes a new instance of the MemoryStream
            // class with an expandable capacity initialized to zero.
            using (var ms = new MemoryStream())
            {
                // Serializes and deserializes objects into and from XML documents.đ
                // The XmlSerializer enables you to control how objects are encoded into XML.
                var s = new XmlSerializer(typeof(T));
                
                // Serializes the specified Object and writes the XML document
                // to a file using the specified XmlWriter.
                s.Serialize(ms, self);
                
                // Gets or sets the current position within the stream.
                ms.Position = 0;
                
                // Deserializes the XML document contained by the specified Stream.
                return (T) s.Deserialize(ms);
            }
        }
    }
}