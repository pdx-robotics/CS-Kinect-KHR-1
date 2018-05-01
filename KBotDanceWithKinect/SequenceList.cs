using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace KBotDanceWithKinect
{
    // A SequenceList contains the set of sequences that are stored in an xml file.
    public class SequenceList
    {
        List<Sequence> sequenceList = new List<Sequence>();

        public SequenceList()
        {
        }

        public SequenceList(string sequenceFileName)
        {
            LoadFromXml(sequenceFileName);
        }

        public void AddSequence(Sequence newSequence)
        {
            sequenceList.Add(newSequence);
        }

        public List<Sequence> GetSequences()
        {
            return sequenceList;
        }

        public void SaveToXml(string fileName)
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(List<Sequence>));
            TextWriter WriteFileStream = new StreamWriter(fileName);
            SerializerObj.Serialize(WriteFileStream, sequenceList);
            WriteFileStream.Close();
        }

        public void LoadFromXml(string fileName)
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(List<Sequence>));
            FileStream ReadFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            sequenceList = (List<Sequence>)SerializerObj.Deserialize(ReadFileStream);
            ReadFileStream.Close();
        }
    }
}
