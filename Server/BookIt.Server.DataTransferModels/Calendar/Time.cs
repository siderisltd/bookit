using System.Runtime.Serialization;

namespace BookIt.Server.DataTransferModels.Calendar
{
    //TODO: Binding model / View model?
    [DataContract]
    public class Time
    {
        public Time(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
        }

        [DataMember]
        public int Hour { get; private set; }
        [DataMember]
        public int Minute { get; private set; }
    }
}