using System.Collections.Generic;
using System.Xml.Serialization;

namespace KBotDanceWithKinect
{
    // A Sequence contains an ordered list of Frames.
    public class MotionSequence
    {
        [XmlElement("Frame")]
        public List<SequenceFrame> frameList = new List<SequenceFrame>();

        [XmlAttribute("Name")]
        public string name;

        public MotionSequence()
        {

        }

        public MotionSequence(string name)
        {
            this.name = name;
        }

        public void AddFrame(SequenceFrame newFrame)
        {
            frameList.Add(newFrame);
        }

        public List<SequenceFrame> GetFrames()
        {
            return frameList;
        }
    }
}
