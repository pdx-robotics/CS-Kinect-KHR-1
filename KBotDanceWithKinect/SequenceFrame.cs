using System.Collections.Generic;
using System.Xml.Serialization;

namespace KBotDanceWithKinect
{
    // A Frame contains a command to speak with the synthesizer, delay for a 
    // length of time, or move a set of servos, or some combination of these.
    public class SequenceFrame
    {
        [XmlElement("ServoPosition")]
        public List<ServoPosition> servoPositionList = new List<ServoPosition>();

        [XmlAttribute("Name")]
        public string name;

        [XmlAttribute("TimeToDestination")]
        public double timeToDestination;

        [XmlAttribute("Speech")]
        public string speechString;

        [XmlAttribute("Delay")]
        public double delay;

        public SequenceFrame()
        {

        }

        public SequenceFrame(string name)
        {
            this.name = name;
        }

        public void AddServoPosition(ServoPosition servoPosition)
        {
            servoPositionList.Add(servoPosition);
        }

        public List<ServoPosition> GetServoPositions()
        {
            return servoPositionList;
        }
    }
}
