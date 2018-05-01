using System.Xml.Serialization;

namespace KBotDanceWithKinect
{
    // A ServoPosition consists of an index specifying the servo and a new
    // target position for this servo.
    public class ServoPosition
    {
        [XmlAttribute("Index")]
        public long index;

        [XmlAttribute("Position")]
        public double position;

        public ServoPosition()
        {
        }

        public ServoPosition(long index, double position)
        {
            this.index = index;
            this.position = position;
        }
    }
}
